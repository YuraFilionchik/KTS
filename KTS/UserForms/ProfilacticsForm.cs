using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTS.UserForms
{
    
    public partial class ProfilacticsForm : Form
    {
        MyContext DB;
        private BindingSource bsDevs = new BindingSource();
        private BindingSource bsProfs = new BindingSource();
        public ProfilacticsForm(MyContext db)
        {
            InitializeComponent();
            this.FormClosing += Users_FormClosing;
            this.dgvUSERS.EditingControlShowing += DgvUSERS_EditingControlShowing;
            this.dgvUSERS.DataBindingComplete += DgvUSERS_DataBindingComplete;
            //dgvUSERS.SelectionChanged += DgvUSERS_SelectionChanged;
            DB = db;
            DB.Profilactics.Load();
            DB.Users.Load();
            dgvUSERS.DataSource = DB.Profilactics.Local.ToBindingList();
            dgvUSERS.Columns[0].Visible = false;//ID
            //dgvUSERS.Columns[4].Visible = false;//user
            //dgvUSERS.Columns[5].Visible = false;//device
            dgvUSERS.Columns[3].HeaderText = "Периодичность (месяцев)";
            dgvUSERS.Columns[1].HeaderText = "Номер";
            dgvUSERS.Columns[2].HeaderText = "Описание";
           
            #region add comboboxColumn
            DataGridViewComboBoxColumn cbcUser = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn cbcDev = new DataGridViewComboBoxColumn();
            cbcUser.HeaderText= "Работник";
            cbcDev.HeaderText= "Оборудование";
            cbcUser.Name = "familia";
            cbcDev.Name = "device";
            cbcUser.Items.AddRange(DB.UserList());
            cbcDev.Items.AddRange(DB.DevList());
            //cbc.DisplayMember = "Familia";
            //TODO bind Combobox and DB
            dgvUSERS.Columns.Add(cbcDev);
            dgvUSERS.Columns.Add(cbcUser);
            #endregion
            bsDevs.DataSource = ObservableCollectionExtensions.ToBindingList(DB.Devices.Local);
           
        }
        //завершение загрузки данных datagridview
        //Fill ComboBoxes in dgvUsers
        private void DgvUSERS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            //foreach (DataGridViewRow row in dgvUSERS.Rows)
            //{
            //    row.Cells["familia"].Value = row.Cells[4].Value.ToString();//присваиваем начальное значение комбобоксу из скрытого столбца
            //    row.Cells["device"].Value = row.Cells[5].Value.ToString();//присваиваем начальное значение комбобоксу из скрытого столбца
            //}
        }

        //ComboboxSelected
        private void DgvUSERS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(cmb_SelectedIndexChanged);
                (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
            }
        }
        //combobox in DataGridView
        /// <summary>
        /// при выборе значения в комбобоксе вставляем это значение в скрытый столбец
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int rindex = dgvUSERS.CurrentCell.RowIndex;
                int Column = dgvUSERS.CurrentCell.ColumnIndex;
                if (dgvUSERS.Columns[Column].Name == "device")
                {
                    var selectedDev = (sender as ComboBox).SelectedItem.ToString();
                    var device = DB.Devices.FirstOrDefault(x => x.Name == selectedDev);
                    if (device == null) return;

                    dgvUSERS.Rows[rindex].Cells["device"].Value = device;
                }
                else if (dgvUSERS.Columns[Column].Name == "familia")
                {
                    var selectedUser = (sender as ComboBox).SelectedItem.ToString().Split(' ')[0];
                    var user = DB.Users.FirstOrDefault(x => x.Familia == selectedUser);
                    if (user == null) return;
                    var idUser = user.UserId;
                   
                    dgvUSERS.Rows[rindex].Cells["user"].Value = user;
                }
            }
            catch (Exception )
            {

            }
            
        }

        private void DgvUSERS_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SaveChanges();
        }
    }
}

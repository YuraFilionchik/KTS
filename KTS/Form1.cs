using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Entity;
namespace KTS
{
    public partial class Form1 : Form
    {
        
        MyContext DB = new MyContext();
        private BindingSource bsDevs=new BindingSource();
        private BindingSource bsUsers=new BindingSource();
        public Form1()
        {
            InitializeComponent();
            #region Подписка на события
            this.FormClosed += Form1_FormClosed;
            cbSelectUser.SelectedIndexChanged += CbSelectUser_SelectedIndexChanged;
            lbDevices.SelectedIndexChanged += LbDevices_SelectedIndexChanged;
            #endregion


            #region Вывод всех пользователей
            DB.Users.Load();
            bsUsers.DataSource= DB.Users.Local.ToBindingList();
            cbSelectUser.DataSource = bsUsers;
            #endregion



        }

        /// <summary>
        /// Select Device and Show profilactics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Device selectedDevice = (sender as ListBox).SelectedItem as Device; //выбранное оборудование
                //теперь ищем закрепленные профилактики для него
                DB.Profilactics.Load();
                DB.Devices.Load();
                DB.Users.Load();
                if (cbSelectUser.SelectedItem == null) return;                
                User user = cbSelectUser.SelectedItem as User;
                if (user == null) return;
                if (DB.Users.Count() == 0) return;
                var FixProf = DB.Profilactics.Local.Where(x => x.device.DeviceId == selectedDevice.DeviceId && x.user.UserId==user.UserId);
                if (FixProf == null) return;
                //вывод закрепленных профилактив в DataGridView dgvFix
                BindingSource bsFix = new BindingSource();
                bsFix.DataSource = FixProf;
                dgvFix.DataSource = bsFix;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при выборе оборудования из списка");
            }
        }

        //Select User -> Display devices
        private void CbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    lbDevices.Items.Clear();
            if (cbSelectUser.SelectedItem == null) return;
            DB.Users.Load();
            User user = cbSelectUser.SelectedItem as User;
            if (user == null) return;
            if (DB.Users.Count() == 0) return;
            var userDevs = DB.GetDevsByUser(user);
            //TODO trim Familia from combobox
            if (userDevs == null) return;
            lbDevices.Items.Clear();
            lbDevices.Items.AddRange(userDevs.ToArray());
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        //TODO check existing name-fam
        private void ДобавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             UserForms.UsersForm UserForm = new UserForms.UsersForm(DB);
            UserForm.ShowDialog();
            DB.Users.Load();

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        //Добавление -удаление оборудования
        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.DevicedForm DevsForm = new UserForms.DevicedForm(DB);
            DevsForm.ShowDialog();
            DB.Devices.Load();
        }

        private void профилактикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.ProfilacticsForm ProfForm = new UserForms.ProfilacticsForm(DB);
            ProfForm.ShowDialog();
            DB.Profilactics.Load();
        }
    }
}

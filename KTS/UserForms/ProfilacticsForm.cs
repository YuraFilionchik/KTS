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
            //dgvUSERS.SelectionChanged += DgvUSERS_SelectionChanged;
            DB = db;
            DB.Profilactics.Load();
            dgvUSERS.DataSource = DB.Profilactics.Local.ToBindingList();
            dgvUSERS.Columns[0].Visible = false;
            dgvUSERS.Columns[4].Visible = false;
            
            dgvUSERS.Columns[3].HeaderText = "Периодичность (месяцев)";
            dgvUSERS.Columns[1].HeaderText = "Номер";
            dgvUSERS.Columns[2].HeaderText = "Описание";
            
            bsDevs.DataSource = ObservableCollectionExtensions.ToBindingList(DB.Devices.Local);
            
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

﻿using System;
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
            #endregion


            #region Вывод всех пользователей
            DB.Users.Load();
            bsUsers.DataSource= DB.Users.Local.ToBindingList();
            cbSelectUser.DataSource = bsUsers;
            lbDevices.DataSource = bsDevs;

            #endregion



        }

        //Select User -> Display devices
        private void CbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    lbDevices.Items.Clear();
            if (cbSelectUser.SelectedItem == null) return;
            DB.Users.Load();
            string userFamil = cbSelectUser.SelectedItem.ToString().Split(' ').First();
            if (userFamil == "empty") return;
            if (DB.Users.Count() == 0) return;
            var userDevs = DB.Users.First(x=>x.Familia==userFamil).UserDevices;
            //TODO trim Familia from combobox
           if(userDevs!=null) bsDevs.DataSource=userDevs;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        //TODO check existing name-fam
        private void ДобавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserForms.UsersForm UserForm = new UserForms.UsersForm(DB);
            UserForm.ShowDialog();
            DB.Users.Load();


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

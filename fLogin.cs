﻿using PhanMemQLCafe.DAOModel;
using PhanMemQLCafe.DTOModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassword.Text;
            if (Login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không đúng!");
            }
        }
        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

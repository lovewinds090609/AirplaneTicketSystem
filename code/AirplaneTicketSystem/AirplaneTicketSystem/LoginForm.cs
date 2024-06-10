using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneTicketSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string acc = textAcc.Text;
            string pwd = textPwd.Text;
            SqlParameter[] paras = new SqlParameter[] //讓特殊字符變成一般字浮 避免SQL注入
            {
                new SqlParameter("@acc",acc),
                new SqlParameter("@pwd", pwd)
            };
            string sql = "select count(1) from Employees where id = @acc and pwd = @pwd";
            int result = (int)DBhelper.ExecuteScalar(sql, paras);
            if (result == 1) { 
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登入失敗 請重新輸入");
            }
        }
    }
}

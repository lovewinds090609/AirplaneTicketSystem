using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AirplaneTicketSystem
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 購買介面
        /// </summary>
        /// <param name="row"></param>
        DataGridViewRow Row; //預設private
        public OrderForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.Row = row; //擴大變數範圍
        }
        /// <summary>
        /// 購買event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.labelPlaneNo.Text = Row.Cells["planeNo"].Value.ToString();
            this.labelDepartureTime.Text = Convert.ToDateTime(Row.Cells["departureTime"].Value).ToString("yyyy/MM/dd HH:mm"); //把秒刪除
            this.labelStartStation.Text = Row.Cells["startStation"].Value.ToString();
            this.labelEndStation.Text = Row.Cells["endStation"].Value.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text.Trim();
            string phone = this.textPhone.Text.Trim();
            string id = this.textId.Text.Trim();
            string country = this.textCountry.Text.Trim();
            string planeNo = Row.Cells["planeNo"].Value.ToString();
            //MessageBox.Show(name);
            string sql = @"insert into Record(name,phone,id,country,planeNo) values(@name,@phone,@id,@country,@planeNo)";
            SqlParameter[] paras = new SqlParameter[] {
                new SqlParameter("@name",name),
                new SqlParameter("@phone",phone),
                new SqlParameter("@id",id),
                new SqlParameter("@country",country),
                new SqlParameter("@planeNo",planeNo)
            };
            int result = DBhelper.ExecuteNonQuery(sql,paras);
            if (result > 0)
            {
                MessageBox.Show("購買成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("購買失敗");
            }
        }
    }
}

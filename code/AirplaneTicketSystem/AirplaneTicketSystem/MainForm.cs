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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查詢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string start = this.cboStartStation.Text;
            string end = this.cboEndStation.Text;
            string date = this.dtpDate.Value.ToString("yyyy/MM/dd");
            string sql = $"select planeId, planeNo, departureTime, startStation, endStation, price, tickets from Tickets where convert(varchar,departureTime,111) = convert(varchar,'{date}',111)";
            if (start != "")
            {
                sql += $"and startStation = '{start}'";
            }
            if (end != "")
            {
                sql += $"and endStation = '{end}'";
            }
            /*SqlParameter[] paras = new SqlParameter[] {
                new SqlParameter("@date",date),
                new SqlParameter("@startStation",start),
                new SqlParameter("@endStation",end)
            };*/
            this.dgvTickets.DataSource= DBhelper.GetDataTable(sql);
        }

        private void tsmiBuy_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 滑鼠點擊event(左/右)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTickets_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex>=0) //e.RowIndex 沒有選到數據的話值為-1
            {
                this.dgvTickets.ClearSelection();//清除前一次選中的數據
                this.dgvTickets.Rows[e.RowIndex].Selected = true;//選取數據
            }
        }
    }
}

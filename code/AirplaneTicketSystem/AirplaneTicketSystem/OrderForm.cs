using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

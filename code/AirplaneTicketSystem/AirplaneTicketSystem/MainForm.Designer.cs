namespace AirplaneTicketSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStartStation = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEndStation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.planeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboEndStation);
            this.groupBox1.Controls.Add(this.cboStartStation);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢條件";
            // 
            // cboStartStation
            // 
            this.cboStartStation.FormattingEnabled = true;
            this.cboStartStation.Items.AddRange(new object[] {
            "台北",
            "桃園",
            "高雄",
            "台中"});
            this.cboStartStation.Location = new System.Drawing.Point(56, 34);
            this.cboStartStation.Name = "cboStartStation";
            this.cboStartStation.Size = new System.Drawing.Size(121, 20);
            this.cboStartStation.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(647, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "查詢";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "出發";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(183, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "抵達";
            // 
            // cboEndStation
            // 
            this.cboEndStation.FormattingEnabled = true;
            this.cboEndStation.Items.AddRange(new object[] {
            "岡山",
            "東京",
            "首爾",
            "大阪",
            "廈門",
            "京都"});
            this.cboEndStation.Location = new System.Drawing.Point(223, 35);
            this.cboEndStation.Name = "cboEndStation";
            this.cboEndStation.Size = new System.Drawing.Size(121, 20);
            this.cboEndStation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(364, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "出發時間";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(430, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeId,
            this.planeNo,
            this.departureTime,
            this.startStation,
            this.endStation,
            this.price,
            this.tickets});
            this.dgvTickets.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTickets.Location = new System.Drawing.Point(28, 123);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(745, 293);
            this.dgvTickets.TabIndex = 1;
            this.dgvTickets.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTickets_CellMouseDown);
            // 
            // planeId
            // 
            this.planeId.DataPropertyName = "planeId";
            this.planeId.HeaderText = "編號";
            this.planeId.Name = "planeId";
            this.planeId.ReadOnly = true;
            // 
            // planeNo
            // 
            this.planeNo.DataPropertyName = "planeNo";
            this.planeNo.HeaderText = "班次";
            this.planeNo.Name = "planeNo";
            this.planeNo.ReadOnly = true;
            // 
            // departureTime
            // 
            this.departureTime.DataPropertyName = "departureTime";
            this.departureTime.HeaderText = "出發時間";
            this.departureTime.Name = "departureTime";
            this.departureTime.ReadOnly = true;
            // 
            // startStation
            // 
            this.startStation.DataPropertyName = "startStation";
            this.startStation.HeaderText = "出發地點";
            this.startStation.Name = "startStation";
            this.startStation.ReadOnly = true;
            // 
            // endStation
            // 
            this.endStation.DataPropertyName = "endStation";
            this.endStation.HeaderText = "目的地";
            this.endStation.Name = "endStation";
            this.endStation.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "價格";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // tickets
            // 
            this.tickets.DataPropertyName = "tickets";
            this.tickets.HeaderText = "剩餘座位";
            this.tickets.Name = "tickets";
            this.tickets.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // tsmiBuy
            // 
            this.tsmiBuy.Name = "tsmiBuy";
            this.tsmiBuy.Size = new System.Drawing.Size(98, 22);
            this.tsmiBuy.Text = "購買";
            this.tsmiBuy.Click += new System.EventHandler(this.tsmiBuy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "售票系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboStartStation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEndStation;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickets;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuy;
    }
}
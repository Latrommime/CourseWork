namespace CourseWork
{
    partial class Auction
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
            this.Open_Account = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView_AvailableLots = new System.Windows.Forms.DataGridView();
            this.MyLot_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_CurrentBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_PlannedLots = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AvailableLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PlannedLots)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_Account
            // 
            this.Open_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open_Account.Location = new System.Drawing.Point(651, 34);
            this.Open_Account.Name = "Open_Account";
            this.Open_Account.Size = new System.Drawing.Size(106, 42);
            this.Open_Account.TabIndex = 3;
            this.Open_Account.Text = "Account";
            this.Open_Account.UseVisualStyleBackColor = true;
            this.Open_Account.Click += new System.EventHandler(this.Open_Account_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Planned auctions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Auctions";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(660, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Bid";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_AvailableLots
            // 
            this.dataGridView_AvailableLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AvailableLots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MyLot_Id,
            this.MyLot_Name,
            this.MyLot_StartTime,
            this.MyLot_Date,
            this.MyLot_CurrentBid});
            this.dataGridView_AvailableLots.Location = new System.Drawing.Point(69, 133);
            this.dataGridView_AvailableLots.Name = "dataGridView_AvailableLots";
            this.dataGridView_AvailableLots.Size = new System.Drawing.Size(543, 137);
            this.dataGridView_AvailableLots.TabIndex = 9;
            // 
            // MyLot_Id
            // 
            this.MyLot_Id.HeaderText = "Id";
            this.MyLot_Id.Name = "MyLot_Id";
            // 
            // MyLot_Name
            // 
            this.MyLot_Name.HeaderText = "Name";
            this.MyLot_Name.Name = "MyLot_Name";
            // 
            // MyLot_StartTime
            // 
            this.MyLot_StartTime.HeaderText = "StartTime";
            this.MyLot_StartTime.Name = "MyLot_StartTime";
            // 
            // MyLot_Date
            // 
            this.MyLot_Date.HeaderText = "Date";
            this.MyLot_Date.Name = "MyLot_Date";
            // 
            // MyLot_CurrentBid
            // 
            this.MyLot_CurrentBid.HeaderText = "CurrentBid";
            this.MyLot_CurrentBid.Name = "MyLot_CurrentBid";
            // 
            // dataGridView_PlannedLots
            // 
            this.dataGridView_PlannedLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PlannedLots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_PlannedLots.Location = new System.Drawing.Point(69, 341);
            this.dataGridView_PlannedLots.Name = "dataGridView_PlannedLots";
            this.dataGridView_PlannedLots.Size = new System.Drawing.Size(543, 140);
            this.dataGridView_PlannedLots.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CurrentBid";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Auction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.dataGridView_PlannedLots);
            this.Controls.Add(this.dataGridView_AvailableLots);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Open_Account);
            this.Name = "Auction";
            this.Text = "Auction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AvailableLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PlannedLots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_Account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView_AvailableLots;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_CurrentBid;
        private System.Windows.Forms.DataGridView dataGridView_PlannedLots;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
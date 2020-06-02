namespace CourseWork
{
    partial class Acccount
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
            this.dataGridView_MyLots = new System.Windows.Forms.DataGridView();
            this.MyLot_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyLot_CurrentBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Open_Auction = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.dataGridView_BoughtLots = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Balance_label = new System.Windows.Forms.Label();
            this.Replenish_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BoughtLots)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MyLots
            // 
            this.dataGridView_MyLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MyLots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MyLot_Id,
            this.MyLot_Name,
            this.MyLot_StartTime,
            this.MyLot_Date,
            this.MyLot_CurrentBid});
            this.dataGridView_MyLots.Location = new System.Drawing.Point(71, 155);
            this.dataGridView_MyLots.Name = "dataGridView_MyLots";
            this.dataGridView_MyLots.Size = new System.Drawing.Size(543, 125);
            this.dataGridView_MyLots.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyLots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bought lots";
            // 
            // Open_Auction
            // 
            this.Open_Auction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open_Auction.Location = new System.Drawing.Point(669, 26);
            this.Open_Auction.Name = "Open_Auction";
            this.Open_Auction.Size = new System.Drawing.Size(106, 42);
            this.Open_Auction.TabIndex = 2;
            this.Open_Auction.Text = "Auction";
            this.Open_Auction.UseVisualStyleBackColor = true;
            this.Open_Auction.Click += new System.EventHandler(this.Open_Auction_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(642, 164);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(84, 39);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click_1);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Enabled = false;
            this.Edit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Button.Location = new System.Drawing.Point(642, 234);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(84, 39);
            this.Edit_Button.TabIndex = 3;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "User name: ";
            // 
            // UserName_label
            // 
            this.UserName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName_label.Location = new System.Drawing.Point(185, 35);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(100, 23);
            this.UserName_label.TabIndex = 4;
            this.UserName_label.Text = "_____________";
            // 
            // dataGridView_BoughtLots
            // 
            this.dataGridView_BoughtLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BoughtLots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_BoughtLots.Location = new System.Drawing.Point(71, 362);
            this.dataGridView_BoughtLots.Name = "dataGridView_BoughtLots";
            this.dataGridView_BoughtLots.Size = new System.Drawing.Size(543, 125);
            this.dataGridView_BoughtLots.TabIndex = 5;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(67, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Balance:";
            // 
            // Balance_label
            // 
            this.Balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_label.Location = new System.Drawing.Point(185, 73);
            this.Balance_label.Name = "Balance_label";
            this.Balance_label.Size = new System.Drawing.Size(100, 24);
            this.Balance_label.TabIndex = 7;
            this.Balance_label.Text = "___________";
            // 
            // Replenish_Button
            // 
            this.Replenish_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Replenish_Button.Location = new System.Drawing.Point(302, 66);
            this.Replenish_Button.Name = "Replenish_Button";
            this.Replenish_Button.Size = new System.Drawing.Size(119, 39);
            this.Replenish_Button.TabIndex = 8;
            this.Replenish_Button.Text = "Replenish";
            this.Replenish_Button.UseVisualStyleBackColor = true;
            this.Replenish_Button.Click += new System.EventHandler(this.Replenish_Button_Click);
            // 
            // Acccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.Replenish_Button);
            this.Controls.Add(this.Balance_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_BoughtLots);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Open_Auction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_MyLots);
            this.Name = "Acccount";
            this.Text = "Acccount";
            this.Load += new System.EventHandler(this.Acccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BoughtLots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MyLots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Open_Auction;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyLot_CurrentBid;
        private System.Windows.Forms.DataGridView dataGridView_BoughtLots;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Button Replenish_Button;
    }
}
namespace SQL_ass1
{
    partial class Form_RentalContract
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
            this.dgv_rentalContract = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dormitoryManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_roomName_search = new System.Windows.Forms.TextBox();
            this.btn_contractID_search = new System.Windows.Forms.Button();
            this.txt_contractID = new System.Windows.Forms.TextBox();
            this.dtp_checkInDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_checkOutDay = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_studentName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_roomName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rentalContract)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_rentalContract
            // 
            this.dgv_rentalContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rentalContract.Location = new System.Drawing.Point(424, 55);
            this.dgv_rentalContract.Name = "dgv_rentalContract";
            this.dgv_rentalContract.RowHeadersWidth = 51;
            this.dgv_rentalContract.RowTemplate.Height = 24;
            this.dgv_rentalContract.Size = new System.Drawing.Size(540, 425);
            this.dgv_rentalContract.TabIndex = 20;
            this.dgv_rentalContract.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rentalContract_CellContentClick);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.classToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.dormitoryManagerToolStripMenuItem,
            this.rentalContractToolStripMenuItem,
            this.contractManagerToolStripMenuItem,
            this.roomManagerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(976, 28);
            this.menu.TabIndex = 21;
            this.menu.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.classToolStripMenuItem.Text = "Class";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // dormitoryManagerToolStripMenuItem
            // 
            this.dormitoryManagerToolStripMenuItem.Name = "dormitoryManagerToolStripMenuItem";
            this.dormitoryManagerToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.dormitoryManagerToolStripMenuItem.Text = "DormitoryManager";
            this.dormitoryManagerToolStripMenuItem.Click += new System.EventHandler(this.dormitoryManagerToolStripMenuItem_Click);
            // 
            // rentalContractToolStripMenuItem
            // 
            this.rentalContractToolStripMenuItem.Name = "rentalContractToolStripMenuItem";
            this.rentalContractToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.rentalContractToolStripMenuItem.Text = "RentalContract";
            this.rentalContractToolStripMenuItem.Click += new System.EventHandler(this.rentalContractToolStripMenuItem_Click);
            // 
            // contractManagerToolStripMenuItem
            // 
            this.contractManagerToolStripMenuItem.Name = "contractManagerToolStripMenuItem";
            this.contractManagerToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.contractManagerToolStripMenuItem.Text = "Contract_Manager";
            this.contractManagerToolStripMenuItem.Click += new System.EventHandler(this.contractManagerToolStripMenuItem_Click);
            // 
            // roomManagerToolStripMenuItem
            // 
            this.roomManagerToolStripMenuItem.Name = "roomManagerToolStripMenuItem";
            this.roomManagerToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.roomManagerToolStripMenuItem.Text = "Room_Manager";
            this.roomManagerToolStripMenuItem.Click += new System.EventHandler(this.roomManagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(140, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rental Contract";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Room Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Check Out Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Check In Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contract ID";
            // 
            // txt_roomName_search
            // 
            this.txt_roomName_search.Location = new System.Drawing.Point(175, 75);
            this.txt_roomName_search.Name = "txt_roomName_search";
            this.txt_roomName_search.Size = new System.Drawing.Size(187, 30);
            this.txt_roomName_search.TabIndex = 30;
            // 
            // btn_contractID_search
            // 
            this.btn_contractID_search.Location = new System.Drawing.Point(243, 111);
            this.btn_contractID_search.Name = "btn_contractID_search";
            this.btn_contractID_search.Size = new System.Drawing.Size(119, 40);
            this.btn_contractID_search.TabIndex = 31;
            this.btn_contractID_search.Text = "Search";
            this.btn_contractID_search.UseVisualStyleBackColor = true;
            this.btn_contractID_search.Click += new System.EventHandler(this.btn_contractID_search_Click);
            // 
            // txt_contractID
            // 
            this.txt_contractID.Location = new System.Drawing.Point(175, 175);
            this.txt_contractID.Name = "txt_contractID";
            this.txt_contractID.Size = new System.Drawing.Size(187, 30);
            this.txt_contractID.TabIndex = 32;
            // 
            // dtp_checkInDay
            // 
            this.dtp_checkInDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_checkInDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_checkInDay.Location = new System.Drawing.Point(175, 215);
            this.dtp_checkInDay.Name = "dtp_checkInDay";
            this.dtp_checkInDay.Size = new System.Drawing.Size(187, 30);
            this.dtp_checkInDay.TabIndex = 33;
            this.dtp_checkInDay.Tag = "";
            this.dtp_checkInDay.Value = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            // 
            // dtp_checkOutDay
            // 
            this.dtp_checkOutDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_checkOutDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_checkOutDay.Location = new System.Drawing.Point(175, 255);
            this.dtp_checkOutDay.Name = "dtp_checkOutDay";
            this.dtp_checkOutDay.Size = new System.Drawing.Size(187, 30);
            this.dtp_checkOutDay.TabIndex = 34;
            this.dtp_checkOutDay.Tag = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(119, 40);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(163, 440);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 440);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 40);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Student Name";
            // 
            // cbb_studentName
            // 
            this.cbb_studentName.FormattingEnabled = true;
            this.cbb_studentName.Location = new System.Drawing.Point(175, 292);
            this.cbb_studentName.Name = "cbb_studentName";
            this.cbb_studentName.Size = new System.Drawing.Size(187, 33);
            this.cbb_studentName.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Room Name";
            // 
            // cbb_roomName
            // 
            this.cbb_roomName.Enabled = false;
            this.cbb_roomName.FormattingEnabled = true;
            this.cbb_roomName.Location = new System.Drawing.Point(175, 333);
            this.cbb_roomName.Name = "cbb_roomName";
            this.cbb_roomName.Size = new System.Drawing.Size(187, 33);
            this.cbb_roomName.TabIndex = 42;
            // 
            // Form_RentalContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 492);
            this.Controls.Add(this.cbb_roomName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_studentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_checkOutDay);
            this.Controls.Add(this.dtp_checkInDay);
            this.Controls.Add(this.txt_contractID);
            this.Controls.Add(this.btn_contractID_search);
            this.Controls.Add(this.txt_roomName_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dgv_rentalContract);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_RentalContract";
            this.Text = "RentalContract";
            this.Load += new System.EventHandler(this.Form_RentalContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rentalContract)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rentalContract;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dormitoryManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_roomName_search;
        private System.Windows.Forms.Button btn_contractID_search;
        private System.Windows.Forms.TextBox txt_contractID;
        private System.Windows.Forms.DateTimePicker dtp_checkOutDay;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem roomManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractManagerToolStripMenuItem;
        public System.Windows.Forms.DateTimePicker dtp_checkInDay;
        private System.Windows.Forms.ComboBox cbb_studentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_roomName;
    }
}
namespace SQL_ass1
{
    partial class Form_Contract_Manager
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dormitoryManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_contract_manager = new System.Windows.Forms.DataGridView();
            this.txt_managerName_search = new System.Windows.Forms.TextBox();
            this.btn_contractID_search = new System.Windows.Forms.Button();
            this.txt_contractID = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_managerName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contract_manager)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.classToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.dormitoryManagerToolStripMenuItem,
            this.rentalContractToolStripMenuItem,
            this.contractManagerToolStripMenuItem,
            this.roomMagerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(976, 30);
            this.menu.TabIndex = 38;
            this.menu.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(113, 39);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(85, 39);
            this.classToolStripMenuItem.Text = "Class";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(95, 39);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // dormitoryManagerToolStripMenuItem
            // 
            this.dormitoryManagerToolStripMenuItem.Name = "dormitoryManagerToolStripMenuItem";
            this.dormitoryManagerToolStripMenuItem.Size = new System.Drawing.Size(242, 39);
            this.dormitoryManagerToolStripMenuItem.Text = "DormitoryManager";
            this.dormitoryManagerToolStripMenuItem.Click += new System.EventHandler(this.dormitoryManagerToolStripMenuItem_Click);
            // 
            // rentalContractToolStripMenuItem
            // 
            this.rentalContractToolStripMenuItem.Name = "rentalContractToolStripMenuItem";
            this.rentalContractToolStripMenuItem.Size = new System.Drawing.Size(191, 39);
            this.rentalContractToolStripMenuItem.Text = "RentalContract";
            this.rentalContractToolStripMenuItem.Click += new System.EventHandler(this.rentalContractToolStripMenuItem_Click);
            // 
            // contractManagerToolStripMenuItem
            // 
            this.contractManagerToolStripMenuItem.Name = "contractManagerToolStripMenuItem";
            this.contractManagerToolStripMenuItem.Size = new System.Drawing.Size(232, 39);
            this.contractManagerToolStripMenuItem.Text = "Contract_Manager";
            this.contractManagerToolStripMenuItem.Click += new System.EventHandler(this.contractManagerToolStripMenuItem_Click);
            // 
            // roomMagerToolStripMenuItem
            // 
            this.roomMagerToolStripMenuItem.Name = "roomMagerToolStripMenuItem";
            this.roomMagerToolStripMenuItem.Size = new System.Drawing.Size(204, 39);
            this.roomMagerToolStripMenuItem.Text = "Room_Manager";
            this.roomMagerToolStripMenuItem.Click += new System.EventHandler(this.roomMagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 39);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Manager Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Contract ID";
            // 
            // dgv_contract_manager
            // 
            this.dgv_contract_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contract_manager.Location = new System.Drawing.Point(424, 55);
            this.dgv_contract_manager.Name = "dgv_contract_manager";
            this.dgv_contract_manager.RowHeadersWidth = 51;
            this.dgv_contract_manager.RowTemplate.Height = 24;
            this.dgv_contract_manager.Size = new System.Drawing.Size(540, 425);
            this.dgv_contract_manager.TabIndex = 48;
            this.dgv_contract_manager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contract_manager_CellContentClick);
            // 
            // txt_managerName_search
            // 
            this.txt_managerName_search.Location = new System.Drawing.Point(183, 75);
            this.txt_managerName_search.Name = "txt_managerName_search";
            this.txt_managerName_search.Size = new System.Drawing.Size(183, 30);
            this.txt_managerName_search.TabIndex = 49;
            // 
            // btn_contractID_search
            // 
            this.btn_contractID_search.Location = new System.Drawing.Point(247, 111);
            this.btn_contractID_search.Name = "btn_contractID_search";
            this.btn_contractID_search.Size = new System.Drawing.Size(119, 40);
            this.btn_contractID_search.TabIndex = 50;
            this.btn_contractID_search.Text = "Search";
            this.btn_contractID_search.UseVisualStyleBackColor = true;
            this.btn_contractID_search.Click += new System.EventHandler(this.btn_contractID_search_Click);
            // 
            // txt_contractID
            // 
            this.txt_contractID.Location = new System.Drawing.Point(183, 175);
            this.txt_contractID.Name = "txt_contractID";
            this.txt_contractID.Size = new System.Drawing.Size(183, 30);
            this.txt_contractID.TabIndex = 52;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(119, 40);
            this.btn_add.TabIndex = 53;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(163, 440);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 54;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 440);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 40);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Manager Name";
            // 
            // cbb_managerName
            // 
            this.cbb_managerName.FormattingEnabled = true;
            this.cbb_managerName.Location = new System.Drawing.Point(183, 212);
            this.cbb_managerName.Name = "cbb_managerName";
            this.cbb_managerName.Size = new System.Drawing.Size(183, 33);
            this.cbb_managerName.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(140, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Contract_Manager";
            // 
            // Form_Contract_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_managerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_contractID);
            this.Controls.Add(this.btn_contractID_search);
            this.Controls.Add(this.txt_managerName_search);
            this.Controls.Add(this.dgv_contract_manager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_Contract_Manager";
            this.Text = "Contract_Manager";
            this.Load += new System.EventHandler(this.Form_Contract_Manager_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contract_manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dormitoryManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMagerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_contract_manager;
        private System.Windows.Forms.TextBox txt_managerName_search;
        private System.Windows.Forms.Button btn_contractID_search;
        private System.Windows.Forms.TextBox txt_contractID;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_managerName;
        private System.Windows.Forms.Label label6;
    }
}
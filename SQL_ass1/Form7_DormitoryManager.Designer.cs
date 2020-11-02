namespace SQL_ass1
{
    partial class Form_DormitoryManager
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
            this.dgv_dormitoryManager = new System.Windows.Forms.DataGridView();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_managerName_search = new System.Windows.Forms.TextBox();
            this.btn_managerName_search = new System.Windows.Forms.Button();
            this.txt_managerID = new System.Windows.Forms.TextBox();
            this.txt_managerName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dormitoryManager)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dormitoryManager
            // 
            this.dgv_dormitoryManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dormitoryManager.Location = new System.Drawing.Point(424, 55);
            this.dgv_dormitoryManager.Name = "dgv_dormitoryManager";
            this.dgv_dormitoryManager.RowHeadersWidth = 51;
            this.dgv_dormitoryManager.RowTemplate.Height = 24;
            this.dgv_dormitoryManager.Size = new System.Drawing.Size(540, 425);
            this.dgv_dormitoryManager.TabIndex = 20;
            this.dgv_dormitoryManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dormitoryManager_CellContentClick);
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
            this.menu.Size = new System.Drawing.Size(976, 30);
            this.menu.TabIndex = 21;
            this.menu.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.classToolStripMenuItem.Text = "Class";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // dormitoryManagerToolStripMenuItem
            // 
            this.dormitoryManagerToolStripMenuItem.Name = "dormitoryManagerToolStripMenuItem";
            this.dormitoryManagerToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.dormitoryManagerToolStripMenuItem.Text = "DormitoryManager";
            this.dormitoryManagerToolStripMenuItem.Click += new System.EventHandler(this.dormitoryManagerToolStripMenuItem_Click);
            // 
            // rentalContractToolStripMenuItem
            // 
            this.rentalContractToolStripMenuItem.Name = "rentalContractToolStripMenuItem";
            this.rentalContractToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.rentalContractToolStripMenuItem.Text = "RentalContract";
            this.rentalContractToolStripMenuItem.Click += new System.EventHandler(this.rentalContractToolStripMenuItem_Click);
            // 
            // contractManagerToolStripMenuItem
            // 
            this.contractManagerToolStripMenuItem.Name = "contractManagerToolStripMenuItem";
            this.contractManagerToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.contractManagerToolStripMenuItem.Text = "Contract_Manager";
            this.contractManagerToolStripMenuItem.Click += new System.EventHandler(this.contractManagerToolStripMenuItem_Click);
            // 
            // roomManagerToolStripMenuItem
            // 
            this.roomManagerToolStripMenuItem.Name = "roomManagerToolStripMenuItem";
            this.roomManagerToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.roomManagerToolStripMenuItem.Text = "Room_Manager";
            this.roomManagerToolStripMenuItem.Click += new System.EventHandler(this.roomManagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
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
            this.label6.Size = new System.Drawing.Size(229, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dormitory Manager";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Manager Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Manager ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Manager Name";
            // 
            // txt_managerName_search
            // 
            this.txt_managerName_search.Location = new System.Drawing.Point(183, 75);
            this.txt_managerName_search.Name = "txt_managerName_search";
            this.txt_managerName_search.Size = new System.Drawing.Size(187, 30);
            this.txt_managerName_search.TabIndex = 30;
            // 
            // btn_managerName_search
            // 
            this.btn_managerName_search.Location = new System.Drawing.Point(251, 111);
            this.btn_managerName_search.Name = "btn_managerName_search";
            this.btn_managerName_search.Size = new System.Drawing.Size(119, 40);
            this.btn_managerName_search.TabIndex = 31;
            this.btn_managerName_search.Text = "Search";
            this.btn_managerName_search.UseVisualStyleBackColor = true;
            this.btn_managerName_search.Click += new System.EventHandler(this.btn_managerName_search_Click);
            // 
            // txt_managerID
            // 
            this.txt_managerID.Location = new System.Drawing.Point(183, 175);
            this.txt_managerID.Name = "txt_managerID";
            this.txt_managerID.Size = new System.Drawing.Size(187, 30);
            this.txt_managerID.TabIndex = 32;
            // 
            // txt_managerName
            // 
            this.txt_managerName.Location = new System.Drawing.Point(183, 215);
            this.txt_managerName.Name = "txt_managerName";
            this.txt_managerName.Size = new System.Drawing.Size(187, 30);
            this.txt_managerName.TabIndex = 33;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(119, 40);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(163, 440);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 440);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 40);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_DormitoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 492);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_managerName);
            this.Controls.Add(this.txt_managerID);
            this.Controls.Add(this.btn_managerName_search);
            this.Controls.Add(this.txt_managerName_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dgv_dormitoryManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_DormitoryManager";
            this.Text = "DormitoryManager";
            this.Load += new System.EventHandler(this.Form_DormitoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dormitoryManager)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dormitoryManager;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dormitoryManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_managerName_search;
        private System.Windows.Forms.Button btn_managerName_search;
        private System.Windows.Forms.TextBox txt_managerID;
        private System.Windows.Forms.TextBox txt_managerName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolStripMenuItem roomManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractManagerToolStripMenuItem;
    }
}
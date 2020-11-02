namespace SQL_ass1
{
    partial class Form_Class
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
            this.roomManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_className_search = new System.Windows.Forms.TextBox();
            this.btn_className_search = new System.Windows.Forms.Button();
            this.txt_classID = new System.Windows.Forms.TextBox();
            this.txt_className = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            this.SuspendLayout();
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
            this.menu.TabIndex = 0;
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
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Class Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Class ID";
            // 
            // txt_className_search
            // 
            this.txt_className_search.Location = new System.Drawing.Point(183, 75);
            this.txt_className_search.Name = "txt_className_search";
            this.txt_className_search.Size = new System.Drawing.Size(187, 30);
            this.txt_className_search.TabIndex = 28;
            // 
            // btn_className_search
            // 
            this.btn_className_search.Location = new System.Drawing.Point(251, 111);
            this.btn_className_search.Name = "btn_className_search";
            this.btn_className_search.Size = new System.Drawing.Size(119, 40);
            this.btn_className_search.TabIndex = 29;
            this.btn_className_search.Text = "Search";
            this.btn_className_search.UseVisualStyleBackColor = true;
            this.btn_className_search.Click += new System.EventHandler(this.btn_className_search_Click);
            // 
            // txt_classID
            // 
            this.txt_classID.Location = new System.Drawing.Point(183, 175);
            this.txt_classID.Name = "txt_classID";
            this.txt_classID.Size = new System.Drawing.Size(187, 30);
            this.txt_classID.TabIndex = 30;
            // 
            // txt_className
            // 
            this.txt_className.Location = new System.Drawing.Point(183, 215);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(187, 30);
            this.txt_className.TabIndex = 31;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(119, 40);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(163, 440);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 34;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 440);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 40);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_class
            // 
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.Location = new System.Drawing.Point(424, 55);
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.RowHeadersWidth = 51;
            this.dgv_class.RowTemplate.Height = 24;
            this.dgv_class.Size = new System.Drawing.Size(540, 425);
            this.dgv_class.TabIndex = 19;
            this.dgv_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_class_CellContentClick);
            // 
            // Form_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 492);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_className);
            this.Controls.Add(this.txt_classID);
            this.Controls.Add(this.btn_className_search);
            this.Controls.Add(this.txt_className_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_class);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Form_Class_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_className_search;
        private System.Windows.Forms.Button btn_className_search;
        private System.Windows.Forms.TextBox txt_classID;
        private System.Windows.Forms.TextBox txt_className;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolStripMenuItem roomManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractManagerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_class;
    }
}
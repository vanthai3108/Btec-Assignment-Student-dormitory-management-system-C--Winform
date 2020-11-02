namespace SQL_ass1
{
    partial class Form_Room
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_roomID = new System.Windows.Forms.TextBox();
            this.txt_roomName = new System.Windows.Forms.TextBox();
            this.txt_roomArea = new System.Windows.Forms.TextBox();
            this.txt_roomRates = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_roomName_search = new System.Windows.Forms.TextBox();
            this.btn_roomName_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_numberOfBeds = new System.Windows.Forms.TextBox();
            this.dgv_room = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Rates";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number Of Beds";
            // 
            // txt_roomID
            // 
            this.txt_roomID.Location = new System.Drawing.Point(183, 175);
            this.txt_roomID.Name = "txt_roomID";
            this.txt_roomID.Size = new System.Drawing.Size(187, 30);
            this.txt_roomID.TabIndex = 6;
            // 
            // txt_roomName
            // 
            this.txt_roomName.Location = new System.Drawing.Point(183, 215);
            this.txt_roomName.Name = "txt_roomName";
            this.txt_roomName.Size = new System.Drawing.Size(187, 30);
            this.txt_roomName.TabIndex = 7;
            // 
            // txt_roomArea
            // 
            this.txt_roomArea.Location = new System.Drawing.Point(183, 255);
            this.txt_roomArea.Name = "txt_roomArea";
            this.txt_roomArea.Size = new System.Drawing.Size(187, 30);
            this.txt_roomArea.TabIndex = 8;
            // 
            // txt_roomRates
            // 
            this.txt_roomRates.Location = new System.Drawing.Point(183, 335);
            this.txt_roomRates.Name = "txt_roomRates";
            this.txt_roomRates.Size = new System.Drawing.Size(187, 30);
            this.txt_roomRates.TabIndex = 9;
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
            this.menu.TabIndex = 11;
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
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Room Name";
            // 
            // txt_roomName_search
            // 
            this.txt_roomName_search.Location = new System.Drawing.Point(183, 75);
            this.txt_roomName_search.Name = "txt_roomName_search";
            this.txt_roomName_search.Size = new System.Drawing.Size(187, 30);
            this.txt_roomName_search.TabIndex = 18;
            // 
            // btn_roomName_search
            // 
            this.btn_roomName_search.Location = new System.Drawing.Point(251, 111);
            this.btn_roomName_search.Name = "btn_roomName_search";
            this.btn_roomName_search.Size = new System.Drawing.Size(119, 40);
            this.btn_roomName_search.TabIndex = 19;
            this.btn_roomName_search.Text = "Search";
            this.btn_roomName_search.UseVisualStyleBackColor = true;
            this.btn_roomName_search.Click += new System.EventHandler(this.btn_roomName_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(119, 40);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 440);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 40);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(163, 440);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_numberOfBeds
            // 
            this.txt_numberOfBeds.Location = new System.Drawing.Point(183, 295);
            this.txt_numberOfBeds.Name = "txt_numberOfBeds";
            this.txt_numberOfBeds.Size = new System.Drawing.Size(187, 30);
            this.txt_numberOfBeds.TabIndex = 23;
            // 
            // dgv_room
            // 
            this.dgv_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_room.Location = new System.Drawing.Point(424, 55);
            this.dgv_room.Name = "dgv_room";
            this.dgv_room.RowHeadersWidth = 51;
            this.dgv_room.RowTemplate.Height = 24;
            this.dgv_room.Size = new System.Drawing.Size(540, 425);
            this.dgv_room.TabIndex = 0;
            this.dgv_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_room_CellContentClick);
            // 
            // Form_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 492);
            this.Controls.Add(this.txt_numberOfBeds);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_roomName_search);
            this.Controls.Add(this.txt_roomName_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_roomRates);
            this.Controls.Add(this.txt_roomArea);
            this.Controls.Add(this.txt_roomName);
            this.Controls.Add(this.txt_roomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_room);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Form_Room_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_roomID;
        private System.Windows.Forms.TextBox txt_roomName;
        private System.Windows.Forms.TextBox txt_roomArea;
        private System.Windows.Forms.TextBox txt_roomRates;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dormitoryManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_roomName_search;
        private System.Windows.Forms.Button btn_roomName_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_numberOfBeds;
        private System.Windows.Forms.ToolStripMenuItem roomManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractManagerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_room;
    }
}
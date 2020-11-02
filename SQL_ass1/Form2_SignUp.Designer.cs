namespace SQL_ass1
{
    partial class Form_SignUp
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
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_emailAddress = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(447, 225);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(76, 29);
            this.rdb_male.TabIndex = 6;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "Male";
            this.rdb_male.UseVisualStyleBackColor = true;
            this.rdb_male.CheckedChanged += new System.EventHandler(this.rdb_male_CheckedChanged);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(529, 225);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(98, 29);
            this.rdb_female.TabIndex = 7;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            this.rdb_female.CheckedChanged += new System.EventHandler(this.rdb_female_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(151, 70);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(183, 30);
            this.txt_userName.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(151, 120);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(183, 30);
            this.txt_password.TabIndex = 11;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(151, 170);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(183, 30);
            this.txt_lastName.TabIndex = 12;
            // 
            // txt_emailAddress
            // 
            this.txt_emailAddress.Location = new System.Drawing.Point(186, 320);
            this.txt_emailAddress.Name = "txt_emailAddress";
            this.txt_emailAddress.Size = new System.Drawing.Size(441, 30);
            this.txt_emailAddress.TabIndex = 14;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(186, 270);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(441, 30);
            this.txt_phoneNumber.TabIndex = 15;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(151, 220);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(183, 30);
            this.txt_firstName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date of Birth";
            // 
            // dtp_dateOfBirth
            // 
            this.dtp_dateOfBirth.Checked = false;
            this.dtp_dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtp_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateOfBirth.Location = new System.Drawing.Point(488, 170);
            this.dtp_dateOfBirth.Name = "dtp_dateOfBirth";
            this.dtp_dateOfBirth.Size = new System.Drawing.Size(139, 30);
            this.dtp_dateOfBirth.TabIndex = 18;
            this.dtp_dateOfBirth.Tag = "";
            // 
            // btn_signUp
            // 
            this.btn_signUp.Location = new System.Drawing.Point(45, 381);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(381, 36);
            this.btn_signUp.TabIndex = 19;
            this.btn_signUp.Text = "Sign up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQL_ass1.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(369, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 84);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(447, 381);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(180, 36);
            this.btn_return.TabIndex = 22;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 466);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.dtp_dateOfBirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_emailAddress);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_emailAddress;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_dateOfBirth;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_return;
    }
}
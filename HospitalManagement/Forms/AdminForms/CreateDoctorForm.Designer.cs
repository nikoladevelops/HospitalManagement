namespace HospitalManagement.Forms.AdminForms
{
    partial class CreateDoctorForm
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
            this.specialityListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createDoctorButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // specialityListBox
            // 
            this.specialityListBox.FormattingEnabled = true;
            this.specialityListBox.ItemHeight = 15;
            this.specialityListBox.Location = new System.Drawing.Point(442, 155);
            this.specialityListBox.Name = "specialityListBox";
            this.specialityListBox.Size = new System.Drawing.Size(157, 124);
            this.specialityListBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Имейл";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(256, 81);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(157, 23);
            this.emailTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Избери специалност";
            // 
            // createDoctorButton
            // 
            this.createDoctorButton.Location = new System.Drawing.Point(256, 322);
            this.createDoctorButton.Name = "createDoctorButton";
            this.createDoctorButton.Size = new System.Drawing.Size(134, 43);
            this.createDoctorButton.TabIndex = 14;
            this.createDoctorButton.Text = "Създай доктор";
            this.createDoctorButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Парола";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(256, 180);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.firstNameTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Име";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(256, 229);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.middleNameTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Презиме";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(256, 281);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.lastNameTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Фамилия";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(256, 129);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 23);
            this.passwordTextBox.TabIndex = 25;
            // 
            // CreateDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.specialityListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createDoctorButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "CreateDoctorForm";
            this.Text = "CreateDoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox specialityListBox;
        private Label label5;
        private TextBox emailTextBox;
        private Label label4;
        private Button createDoctorButton;
        private Label label6;
        private TextBox firstNameTextBox;
        private Label label1;
        private TextBox middleNameTextBox;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private TextBox passwordTextBox;
    }
}
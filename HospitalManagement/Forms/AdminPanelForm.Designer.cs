namespace HospitalManagement.Forms
{
    partial class AdminPanelForm
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
            this.createDoctorButton = new System.Windows.Forms.Button();
            this.displayEmailLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.specialityListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createSpecialityButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.specialityNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteSpecialityButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchDoctorButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.searchCriteriaListBox = new System.Windows.Forms.ListBox();
            this.foundDoctorsListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteSelectedDoctorButton = new System.Windows.Forms.Button();
            this.editSelectedDoctorButton = new System.Windows.Forms.Button();
            this.showSelectedDoctorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDoctorButton
            // 
            this.createDoctorButton.Location = new System.Drawing.Point(105, 321);
            this.createDoctorButton.Name = "createDoctorButton";
            this.createDoctorButton.Size = new System.Drawing.Size(134, 43);
            this.createDoctorButton.TabIndex = 0;
            this.createDoctorButton.Text = "Създай доктор";
            this.createDoctorButton.UseVisualStyleBackColor = true;
            this.createDoctorButton.Click += new System.EventHandler(this.createDoctorButton_Click);
            // 
            // displayEmailLabel
            // 
            this.displayEmailLabel.AutoSize = true;
            this.displayEmailLabel.Location = new System.Drawing.Point(12, 9);
            this.displayEmailLabel.Name = "displayEmailLabel";
            this.displayEmailLabel.Size = new System.Drawing.Size(190, 15);
            this.displayEmailLabel.TabIndex = 1;
            this.displayEmailLabel.Text = "имейла на админа се показва тук";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(33, 177);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Презиме";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(33, 226);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.middleNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(33, 278);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // specialityListBox
            // 
            this.specialityListBox.FormattingEnabled = true;
            this.specialityListBox.ItemHeight = 15;
            this.specialityListBox.Location = new System.Drawing.Point(212, 177);
            this.specialityListBox.Name = "specialityListBox";
            this.specialityListBox.Size = new System.Drawing.Size(157, 124);
            this.specialityListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Избери специалност";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имейл";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(33, 77);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(157, 23);
            this.emailTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Парола";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(33, 126);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 23);
            this.passwordTextBox.TabIndex = 12;
            // 
            // createSpecialityButton
            // 
            this.createSpecialityButton.Location = new System.Drawing.Point(212, 103);
            this.createSpecialityButton.Name = "createSpecialityButton";
            this.createSpecialityButton.Size = new System.Drawing.Size(157, 46);
            this.createSpecialityButton.TabIndex = 14;
            this.createSpecialityButton.Text = "Създай специалност";
            this.createSpecialityButton.UseVisualStyleBackColor = true;
            this.createSpecialityButton.Click += new System.EventHandler(this.createSpecialityButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Име на специалност";
            // 
            // specialityNameTextBox
            // 
            this.specialityNameTextBox.Location = new System.Drawing.Point(212, 67);
            this.specialityNameTextBox.Name = "specialityNameTextBox";
            this.specialityNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.specialityNameTextBox.TabIndex = 15;
            // 
            // deleteSpecialityButton
            // 
            this.deleteSpecialityButton.Location = new System.Drawing.Point(375, 260);
            this.deleteSpecialityButton.Name = "deleteSpecialityButton";
            this.deleteSpecialityButton.Size = new System.Drawing.Size(136, 41);
            this.deleteSpecialityButton.TabIndex = 17;
            this.deleteSpecialityButton.Text = "Изтрий избрана специалност";
            this.deleteSpecialityButton.UseVisualStyleBackColor = true;
            this.deleteSpecialityButton.Click += new System.EventHandler(this.deleteSpecialityButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Търси доктор";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(518, 56);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(157, 23);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchDoctorButton
            // 
            this.searchDoctorButton.Location = new System.Drawing.Point(518, 233);
            this.searchDoctorButton.Name = "searchDoctorButton";
            this.searchDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.searchDoctorButton.TabIndex = 18;
            this.searchDoctorButton.Text = "Намери доктор";
            this.searchDoctorButton.UseVisualStyleBackColor = true;
            this.searchDoctorButton.Click += new System.EventHandler(this.searchDoctorButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Избери по какво";
            // 
            // searchCriteriaListBox
            // 
            this.searchCriteriaListBox.FormattingEnabled = true;
            this.searchCriteriaListBox.ItemHeight = 15;
            this.searchCriteriaListBox.Location = new System.Drawing.Point(518, 103);
            this.searchCriteriaListBox.Name = "searchCriteriaListBox";
            this.searchCriteriaListBox.Size = new System.Drawing.Size(157, 124);
            this.searchCriteriaListBox.TabIndex = 21;
            // 
            // foundDoctorsListBox
            // 
            this.foundDoctorsListBox.FormattingEnabled = true;
            this.foundDoctorsListBox.ItemHeight = 15;
            this.foundDoctorsListBox.Location = new System.Drawing.Point(681, 103);
            this.foundDoctorsListBox.Name = "foundDoctorsListBox";
            this.foundDoctorsListBox.Size = new System.Drawing.Size(157, 124);
            this.foundDoctorsListBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(681, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Намерени доктори";
            // 
            // deleteSelectedDoctorButton
            // 
            this.deleteSelectedDoctorButton.Location = new System.Drawing.Point(681, 284);
            this.deleteSelectedDoctorButton.Name = "deleteSelectedDoctorButton";
            this.deleteSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.deleteSelectedDoctorButton.TabIndex = 25;
            this.deleteSelectedDoctorButton.Text = "Изтрий избрания";
            this.deleteSelectedDoctorButton.UseVisualStyleBackColor = true;
            // 
            // editSelectedDoctorButton
            // 
            this.editSelectedDoctorButton.Location = new System.Drawing.Point(681, 336);
            this.editSelectedDoctorButton.Name = "editSelectedDoctorButton";
            this.editSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.editSelectedDoctorButton.TabIndex = 26;
            this.editSelectedDoctorButton.Text = "Редактирай избрания";
            this.editSelectedDoctorButton.UseVisualStyleBackColor = true;
            // 
            // showSelectedDoctorButton
            // 
            this.showSelectedDoctorButton.Location = new System.Drawing.Point(681, 233);
            this.showSelectedDoctorButton.Name = "showSelectedDoctorButton";
            this.showSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.showSelectedDoctorButton.TabIndex = 27;
            this.showSelectedDoctorButton.Text = "Покажи избрания";
            this.showSelectedDoctorButton.UseVisualStyleBackColor = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.showSelectedDoctorButton);
            this.Controls.Add(this.editSelectedDoctorButton);
            this.Controls.Add(this.deleteSelectedDoctorButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.foundDoctorsListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchCriteriaListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchDoctorButton);
            this.Controls.Add(this.deleteSpecialityButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.specialityNameTextBox);
            this.Controls.Add(this.createSpecialityButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specialityListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.displayEmailLabel);
            this.Controls.Add(this.createDoctorButton);
            this.Name = "AdminPanelForm";
            this.Text = "Админ панел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createDoctorButton;
        private Label displayEmailLabel;
        private TextBox firstNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox middleNameTextBox;
        private Label label3;
        private TextBox lastNameTextBox;
        private ListBox specialityListBox;
        private Label label4;
        private Label label5;
        private TextBox emailTextBox;
        private Label label6;
        private TextBox passwordTextBox;
        private Button createSpecialityButton;
        private Label label7;
        private TextBox specialityNameTextBox;
        private Button deleteSpecialityButton;
        private Label label8;
        private TextBox searchTextBox;
        private Button searchDoctorButton;
        private Label label9;
        private ListBox searchCriteriaListBox;
        private ListBox foundDoctorsListBox;
        private Label label10;
        private Button deleteSelectedDoctorButton;
        private Button editSelectedDoctorButton;
        private Button showSelectedDoctorButton;
    }
}
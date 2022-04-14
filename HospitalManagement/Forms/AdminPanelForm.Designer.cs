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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorMenuButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createDoctorButton
            // 
            this.createDoctorButton.Location = new System.Drawing.Point(69, 307);
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
            this.displayEmailLabel.Location = new System.Drawing.Point(6, 9);
            this.displayEmailLabel.Name = "displayEmailLabel";
            this.displayEmailLabel.Size = new System.Drawing.Size(190, 15);
            this.displayEmailLabel.TabIndex = 1;
            this.displayEmailLabel.Text = "имейла на админа се показва тук";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(69, 165);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Презиме";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(69, 214);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.middleNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(69, 266);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // specialityListBox
            // 
            this.specialityListBox.FormattingEnabled = true;
            this.specialityListBox.ItemHeight = 15;
            this.specialityListBox.Location = new System.Drawing.Point(255, 140);
            this.specialityListBox.Name = "specialityListBox";
            this.specialityListBox.Size = new System.Drawing.Size(157, 124);
            this.specialityListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Избери специалност";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имейл";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(69, 66);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(157, 23);
            this.emailTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Парола";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(69, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 23);
            this.passwordTextBox.TabIndex = 12;
            // 
            // createSpecialityButton
            // 
            this.createSpecialityButton.Location = new System.Drawing.Point(255, 66);
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
            this.label7.Location = new System.Drawing.Point(255, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Име на специалност";
            // 
            // specialityNameTextBox
            // 
            this.specialityNameTextBox.Location = new System.Drawing.Point(255, 38);
            this.specialityNameTextBox.Name = "specialityNameTextBox";
            this.specialityNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.specialityNameTextBox.TabIndex = 15;
            // 
            // deleteSpecialityButton
            // 
            this.deleteSpecialityButton.Location = new System.Drawing.Point(418, 223);
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
            this.label8.Location = new System.Drawing.Point(564, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Търси доктор";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(564, 45);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(157, 23);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchDoctorButton
            // 
            this.searchDoctorButton.Location = new System.Drawing.Point(560, 236);
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
            this.label9.Location = new System.Drawing.Point(564, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Избери по какво";
            // 
            // searchCriteriaListBox
            // 
            this.searchCriteriaListBox.FormattingEnabled = true;
            this.searchCriteriaListBox.ItemHeight = 15;
            this.searchCriteriaListBox.Location = new System.Drawing.Point(564, 96);
            this.searchCriteriaListBox.Name = "searchCriteriaListBox";
            this.searchCriteriaListBox.Size = new System.Drawing.Size(157, 124);
            this.searchCriteriaListBox.TabIndex = 21;
            // 
            // foundDoctorsListBox
            // 
            this.foundDoctorsListBox.FormattingEnabled = true;
            this.foundDoctorsListBox.ItemHeight = 15;
            this.foundDoctorsListBox.Location = new System.Drawing.Point(740, 96);
            this.foundDoctorsListBox.Name = "foundDoctorsListBox";
            this.foundDoctorsListBox.Size = new System.Drawing.Size(157, 124);
            this.foundDoctorsListBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(740, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Намерени доктори";
            // 
            // deleteSelectedDoctorButton
            // 
            this.deleteSelectedDoctorButton.Location = new System.Drawing.Point(740, 337);
            this.deleteSelectedDoctorButton.Name = "deleteSelectedDoctorButton";
            this.deleteSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.deleteSelectedDoctorButton.TabIndex = 25;
            this.deleteSelectedDoctorButton.Text = "Изтрий избрания";
            this.deleteSelectedDoctorButton.UseVisualStyleBackColor = true;
            this.deleteSelectedDoctorButton.Click += new System.EventHandler(this.deleteSelectedDoctorButton_Click);
            // 
            // editSelectedDoctorButton
            // 
            this.editSelectedDoctorButton.Location = new System.Drawing.Point(740, 288);
            this.editSelectedDoctorButton.Name = "editSelectedDoctorButton";
            this.editSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.editSelectedDoctorButton.TabIndex = 26;
            this.editSelectedDoctorButton.Text = "Редактирай избрания";
            this.editSelectedDoctorButton.UseVisualStyleBackColor = true;
            this.editSelectedDoctorButton.Click += new System.EventHandler(this.editSelectedDoctorButton_Click);
            // 
            // showSelectedDoctorButton
            // 
            this.showSelectedDoctorButton.Location = new System.Drawing.Point(740, 236);
            this.showSelectedDoctorButton.Name = "showSelectedDoctorButton";
            this.showSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.showSelectedDoctorButton.TabIndex = 27;
            this.showSelectedDoctorButton.Text = "Покажи избрания";
            this.showSelectedDoctorButton.UseVisualStyleBackColor = true;
            this.showSelectedDoctorButton.Click += new System.EventHandler(this.showSelectedDoctorButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.doctorMenuButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 469);
            this.panelMenu.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.button2.Image = global::HospitalManagement.Properties.Resources.pencilIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(225, 60);
            this.button2.TabIndex = 31;
            this.button2.Text = "  Създай специалност";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.button1.Image = global::HospitalManagement.Properties.Resources.searchIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(225, 60);
            this.button1.TabIndex = 30;
            this.button1.Text = "  Търси доктор";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // doctorMenuButton
            // 
            this.doctorMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorMenuButton.FlatAppearance.BorderSize = 0;
            this.doctorMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctorMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.doctorMenuButton.Image = global::HospitalManagement.Properties.Resources.doctorIcon;
            this.doctorMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorMenuButton.Location = new System.Drawing.Point(0, 80);
            this.doctorMenuButton.Name = "doctorMenuButton";
            this.doctorMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.doctorMenuButton.Size = new System.Drawing.Size(225, 60);
            this.doctorMenuButton.TabIndex = 29;
            this.doctorMenuButton.Text = "  Създай доктор";
            this.doctorMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctorMenuButton.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.panelLogo.Controls.Add(this.logoLabel);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.logoLabel.Location = new System.Drawing.Point(0, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(225, 80);
            this.logoLabel.TabIndex = 31;
            this.logoLabel.Text = "Болница";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label11.Location = new System.Drawing.Point(447, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Начало";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 80);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.deleteSpecialityButton);
            this.contentPanel.Controls.Add(this.createSpecialityButton);
            this.contentPanel.Controls.Add(this.specialityListBox);
            this.contentPanel.Controls.Add(this.label8);
            this.contentPanel.Controls.Add(this.searchTextBox);
            this.contentPanel.Controls.Add(this.label10);
            this.contentPanel.Controls.Add(this.editSelectedDoctorButton);
            this.contentPanel.Controls.Add(this.label7);
            this.contentPanel.Controls.Add(this.specialityNameTextBox);
            this.contentPanel.Controls.Add(this.foundDoctorsListBox);
            this.contentPanel.Controls.Add(this.showSelectedDoctorButton);
            this.contentPanel.Controls.Add(this.label5);
            this.contentPanel.Controls.Add(this.emailTextBox);
            this.contentPanel.Controls.Add(this.label9);
            this.contentPanel.Controls.Add(this.deleteSelectedDoctorButton);
            this.contentPanel.Controls.Add(this.displayEmailLabel);
            this.contentPanel.Controls.Add(this.searchCriteriaListBox);
            this.contentPanel.Controls.Add(this.label4);
            this.contentPanel.Controls.Add(this.createDoctorButton);
            this.contentPanel.Controls.Add(this.label6);
            this.contentPanel.Controls.Add(this.firstNameTextBox);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.middleNameTextBox);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.lastNameTextBox);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.searchDoctorButton);
            this.contentPanel.Controls.Add(this.passwordTextBox);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(225, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(972, 389);
            this.contentPanel.TabIndex = 32;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 469);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminPanelForm";
            this.Text = "Админ панел";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panelMenu;
        private Button button2;
        private Button button1;
        private Button doctorMenuButton;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLogo;
        private Label logoLabel;
        private Panel contentPanel;
    }
}
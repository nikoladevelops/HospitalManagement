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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.createSpecialityMenuButton = new System.Windows.Forms.Button();
            this.searchDoctorMenuButton = new System.Windows.Forms.Button();
            this.createDoctorMenuButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.createSpecialityMenuButton);
            this.panelMenu.Controls.Add(this.searchDoctorMenuButton);
            this.panelMenu.Controls.Add(this.createDoctorMenuButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 569);
            this.panelMenu.TabIndex = 28;
            // 
            // createSpecialityMenuButton
            // 
            this.createSpecialityMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createSpecialityMenuButton.FlatAppearance.BorderSize = 0;
            this.createSpecialityMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSpecialityMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createSpecialityMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createSpecialityMenuButton.Image = global::HospitalManagement.Properties.Resources.pencilIcon;
            this.createSpecialityMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createSpecialityMenuButton.Location = new System.Drawing.Point(0, 200);
            this.createSpecialityMenuButton.Name = "createSpecialityMenuButton";
            this.createSpecialityMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.createSpecialityMenuButton.Size = new System.Drawing.Size(225, 60);
            this.createSpecialityMenuButton.TabIndex = 31;
            this.createSpecialityMenuButton.Text = "  Докторски специалности";
            this.createSpecialityMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createSpecialityMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createSpecialityMenuButton.UseVisualStyleBackColor = true;
            this.createSpecialityMenuButton.Click += new System.EventHandler(this.createSpecialityMenuButton_Click);
            // 
            // searchDoctorMenuButton
            // 
            this.searchDoctorMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchDoctorMenuButton.FlatAppearance.BorderSize = 0;
            this.searchDoctorMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchDoctorMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchDoctorMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.searchDoctorMenuButton.Image = global::HospitalManagement.Properties.Resources.searchIcon;
            this.searchDoctorMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDoctorMenuButton.Location = new System.Drawing.Point(0, 140);
            this.searchDoctorMenuButton.Name = "searchDoctorMenuButton";
            this.searchDoctorMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.searchDoctorMenuButton.Size = new System.Drawing.Size(225, 60);
            this.searchDoctorMenuButton.TabIndex = 30;
            this.searchDoctorMenuButton.Text = "  Търси доктор";
            this.searchDoctorMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDoctorMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchDoctorMenuButton.UseVisualStyleBackColor = true;
            this.searchDoctorMenuButton.Click += new System.EventHandler(this.searchDoctorMenuButton_Click);
            // 
            // createDoctorMenuButton
            // 
            this.createDoctorMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createDoctorMenuButton.FlatAppearance.BorderSize = 0;
            this.createDoctorMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDoctorMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDoctorMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createDoctorMenuButton.Image = global::HospitalManagement.Properties.Resources.doctorIcon;
            this.createDoctorMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createDoctorMenuButton.Location = new System.Drawing.Point(0, 80);
            this.createDoctorMenuButton.Name = "createDoctorMenuButton";
            this.createDoctorMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.createDoctorMenuButton.Size = new System.Drawing.Size(225, 60);
            this.createDoctorMenuButton.TabIndex = 29;
            this.createDoctorMenuButton.Text = "  Създай доктор";
            this.createDoctorMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createDoctorMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createDoctorMenuButton.UseVisualStyleBackColor = true;
            this.createDoctorMenuButton.Click += new System.EventHandler(this.createDoctorMenuButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(233)))));
            this.panelLogo.Controls.Add(this.label12);
            this.panelLogo.Controls.Add(this.logoLabel);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.label12.Location = new System.Drawing.Point(0, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 10);
            this.label12.TabIndex = 32;
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
            this.logoLabel.Text = "Болнично заведение";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.titleLabel.Location = new System.Drawing.Point(305, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(206, 25);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "отворена форма текст";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 80);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(225, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(816, 489);
            this.contentPanel.TabIndex = 32;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 569);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ панел";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private Button createSpecialityMenuButton;
        private Button searchDoctorMenuButton;
        private Button createDoctorMenuButton;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLogo;
        private Label logoLabel;
        private Label label12;
        private Panel contentPanel;
    }
}
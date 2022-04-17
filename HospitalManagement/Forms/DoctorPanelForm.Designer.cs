namespace HospitalManagement.Forms
{
    partial class DoctorPanelForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.searchPatientMenuButton = new System.Windows.Forms.Button();
            this.createPatientMenuButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.createPrescriptionMenuButton = new System.Windows.Forms.Button();
            this.medicalConditionsMenuButton = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.medicalConditionsMenuButton);
            this.panelMenu.Controls.Add(this.createPrescriptionMenuButton);
            this.panelMenu.Controls.Add(this.searchPatientMenuButton);
            this.panelMenu.Controls.Add(this.createPatientMenuButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 569);
            this.panelMenu.TabIndex = 28;
            // 
            // searchPatientMenuButton
            // 
            this.searchPatientMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPatientMenuButton.FlatAppearance.BorderSize = 0;
            this.searchPatientMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPatientMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchPatientMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.searchPatientMenuButton.Image = global::HospitalManagement.Properties.Resources.searchIcon;
            this.searchPatientMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchPatientMenuButton.Location = new System.Drawing.Point(0, 140);
            this.searchPatientMenuButton.Name = "searchPatientMenuButton";
            this.searchPatientMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.searchPatientMenuButton.Size = new System.Drawing.Size(225, 60);
            this.searchPatientMenuButton.TabIndex = 30;
            this.searchPatientMenuButton.Text = "  Търси пациент";
            this.searchPatientMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchPatientMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchPatientMenuButton.UseVisualStyleBackColor = true;
            // 
            // createPatientMenuButton
            // 
            this.createPatientMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPatientMenuButton.FlatAppearance.BorderSize = 0;
            this.createPatientMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPatientMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPatientMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createPatientMenuButton.Image = global::HospitalManagement.Properties.Resources.doctorIcon;
            this.createPatientMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPatientMenuButton.Location = new System.Drawing.Point(0, 80);
            this.createPatientMenuButton.Name = "createPatientMenuButton";
            this.createPatientMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.createPatientMenuButton.Size = new System.Drawing.Size(225, 60);
            this.createPatientMenuButton.TabIndex = 29;
            this.createPatientMenuButton.Text = "  Създай пациент";
            this.createPatientMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPatientMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createPatientMenuButton.UseVisualStyleBackColor = true;
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
            // createPrescriptionMenuButton
            // 
            this.createPrescriptionMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPrescriptionMenuButton.FlatAppearance.BorderSize = 0;
            this.createPrescriptionMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrescriptionMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrescriptionMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createPrescriptionMenuButton.Image = global::HospitalManagement.Properties.Resources.pencilIcon;
            this.createPrescriptionMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPrescriptionMenuButton.Location = new System.Drawing.Point(0, 200);
            this.createPrescriptionMenuButton.Name = "createPrescriptionMenuButton";
            this.createPrescriptionMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.createPrescriptionMenuButton.Size = new System.Drawing.Size(225, 60);
            this.createPrescriptionMenuButton.TabIndex = 31;
            this.createPrescriptionMenuButton.Text = "  Създай рецепта";
            this.createPrescriptionMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPrescriptionMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createPrescriptionMenuButton.UseVisualStyleBackColor = true;
            // 
            // medicalConditionsMenuButton
            // 
            this.medicalConditionsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicalConditionsMenuButton.FlatAppearance.BorderSize = 0;
            this.medicalConditionsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicalConditionsMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medicalConditionsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.medicalConditionsMenuButton.Image = global::HospitalManagement.Properties.Resources.pencilIcon;
            this.medicalConditionsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicalConditionsMenuButton.Location = new System.Drawing.Point(0, 260);
            this.medicalConditionsMenuButton.Name = "medicalConditionsMenuButton";
            this.medicalConditionsMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.medicalConditionsMenuButton.Size = new System.Drawing.Size(225, 60);
            this.medicalConditionsMenuButton.TabIndex = 32;
            this.medicalConditionsMenuButton.Text = "  Заболявания";
            this.medicalConditionsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicalConditionsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.medicalConditionsMenuButton.UseVisualStyleBackColor = true;
            // 
            // DoctorPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 569);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "DoctorPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Докторски панел";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private Button searchPatientMenuButton;
        private Button createPatientMenuButton;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLogo;
        private Label logoLabel;
        private Label label12;
        private Panel contentPanel;
        private Button createPrescriptionMenuButton;
        private Button medicalConditionsMenuButton;
    }
}
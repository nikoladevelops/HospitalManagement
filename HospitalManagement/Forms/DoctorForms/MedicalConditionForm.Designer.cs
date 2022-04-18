namespace HospitalManagement.Forms.DoctorForms
{
    partial class MedicalConditionForm
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
            this.deleteMedicalConditionButton = new System.Windows.Forms.Button();
            this.createMedicalConditionButton = new System.Windows.Forms.Button();
            this.medicalConditionListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.medicalConditionNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteMedicalConditionButton
            // 
            this.deleteMedicalConditionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteMedicalConditionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.deleteMedicalConditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMedicalConditionButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteMedicalConditionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.deleteMedicalConditionButton.Location = new System.Drawing.Point(288, 358);
            this.deleteMedicalConditionButton.Name = "deleteMedicalConditionButton";
            this.deleteMedicalConditionButton.Size = new System.Drawing.Size(193, 55);
            this.deleteMedicalConditionButton.TabIndex = 4;
            this.deleteMedicalConditionButton.Text = "Изтрий избрано заболяване";
            this.deleteMedicalConditionButton.UseVisualStyleBackColor = false;
            this.deleteMedicalConditionButton.Click += new System.EventHandler(this.deleteMedicalConditionButton_Click);
            // 
            // createMedicalConditionButton
            // 
            this.createMedicalConditionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createMedicalConditionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.createMedicalConditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMedicalConditionButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createMedicalConditionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createMedicalConditionButton.Location = new System.Drawing.Point(288, 111);
            this.createMedicalConditionButton.Name = "createMedicalConditionButton";
            this.createMedicalConditionButton.Size = new System.Drawing.Size(193, 46);
            this.createMedicalConditionButton.TabIndex = 2;
            this.createMedicalConditionButton.Text = "Създай заболяване";
            this.createMedicalConditionButton.UseVisualStyleBackColor = false;
            this.createMedicalConditionButton.Click += new System.EventHandler(this.createMedicalConditionButton_Click);
            // 
            // medicalConditionListBox
            // 
            this.medicalConditionListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.medicalConditionListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medicalConditionListBox.FormattingEnabled = true;
            this.medicalConditionListBox.ItemHeight = 20;
            this.medicalConditionListBox.Location = new System.Drawing.Point(288, 188);
            this.medicalConditionListBox.Name = "medicalConditionListBox";
            this.medicalConditionListBox.Size = new System.Drawing.Size(193, 164);
            this.medicalConditionListBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(288, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Име на заболяването";
            // 
            // medicalConditionNameTextBox
            // 
            this.medicalConditionNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.medicalConditionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medicalConditionNameTextBox.Location = new System.Drawing.Point(288, 76);
            this.medicalConditionNameTextBox.Name = "medicalConditionNameTextBox";
            this.medicalConditionNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.medicalConditionNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(288, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Избери заболяване";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.medicalConditionNameTextBox);
            this.panel1.Controls.Add(this.deleteMedicalConditionButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.createMedicalConditionButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.medicalConditionListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 444);
            this.panel1.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.076716F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.92329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // MedicalConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MedicalConditionForm";
            this.Text = "Заболявания";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button deleteMedicalConditionButton;
        private Button createMedicalConditionButton;
        private ListBox medicalConditionListBox;
        private Label label7;
        private TextBox medicalConditionNameTextBox;
        private Label label4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
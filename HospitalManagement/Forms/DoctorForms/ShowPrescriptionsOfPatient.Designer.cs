namespace HospitalManagement.Forms.DoctorForms
{
    partial class ShowPrescriptionsOfPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.allPatientPrescriptionsListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.egnTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.prescriptionTextBox);
            this.panel1.Controls.Add(this.allPatientPrescriptionsListBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.egnTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 444);
            this.panel1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(246, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "№";
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prescriptionTextBox.Location = new System.Drawing.Point(369, 132);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.ReadOnly = true;
            this.prescriptionTextBox.Size = new System.Drawing.Size(192, 224);
            this.prescriptionTextBox.TabIndex = 42;
            // 
            // allPatientPrescriptionsListBox
            // 
            this.allPatientPrescriptionsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allPatientPrescriptionsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.allPatientPrescriptionsListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allPatientPrescriptionsListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.allPatientPrescriptionsListBox.FormattingEnabled = true;
            this.allPatientPrescriptionsListBox.ItemHeight = 20;
            this.allPatientPrescriptionsListBox.Location = new System.Drawing.Point(246, 132);
            this.allPatientPrescriptionsListBox.Name = "allPatientPrescriptionsListBox";
            this.allPatientPrescriptionsListBox.Size = new System.Drawing.Size(117, 224);
            this.allPatientPrescriptionsListBox.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(369, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Рецепта";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label9.Location = new System.Drawing.Point(296, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "ЕГН";
            // 
            // egnTextBox
            // 
            this.egnTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.egnTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.egnTextBox.Location = new System.Drawing.Point(296, 77);
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.ReadOnly = true;
            this.egnTextBox.Size = new System.Drawing.Size(187, 27);
            this.egnTextBox.TabIndex = 2;
            this.egnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.99005F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.00995F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel7.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel7.TabIndex = 33;
            // 
            // ShowPrescriptionsOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Name = "ShowPrescriptionsOfPatient";
            this.Text = "Всички рецепти на пациента";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label9;
        private TextBox egnTextBox;
        private TableLayoutPanel tableLayoutPanel7;
        private ListBox allPatientPrescriptionsListBox;
        private TextBox prescriptionTextBox;
        private Label label8;
    }
}
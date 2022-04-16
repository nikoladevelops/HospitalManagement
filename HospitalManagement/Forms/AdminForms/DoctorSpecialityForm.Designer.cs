namespace HospitalManagement.Forms.AdminForms
{
    partial class DoctorSpecialityForm
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
            this.deleteSpecialityButton = new System.Windows.Forms.Button();
            this.createSpecialityButton = new System.Windows.Forms.Button();
            this.specialityListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.specialityNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteSpecialityButton
            // 
            this.deleteSpecialityButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSpecialityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.deleteSpecialityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSpecialityButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSpecialityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.deleteSpecialityButton.Location = new System.Drawing.Point(288, 358);
            this.deleteSpecialityButton.Name = "deleteSpecialityButton";
            this.deleteSpecialityButton.Size = new System.Drawing.Size(193, 55);
            this.deleteSpecialityButton.TabIndex = 4;
            this.deleteSpecialityButton.Text = "Изтрий избрана специалност";
            this.deleteSpecialityButton.UseVisualStyleBackColor = false;
            this.deleteSpecialityButton.Click += new System.EventHandler(this.deleteSpecialityButton_Click);
            // 
            // createSpecialityButton
            // 
            this.createSpecialityButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createSpecialityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.createSpecialityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSpecialityButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createSpecialityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createSpecialityButton.Location = new System.Drawing.Point(288, 111);
            this.createSpecialityButton.Name = "createSpecialityButton";
            this.createSpecialityButton.Size = new System.Drawing.Size(193, 46);
            this.createSpecialityButton.TabIndex = 2;
            this.createSpecialityButton.Text = "Създай специалност";
            this.createSpecialityButton.UseVisualStyleBackColor = false;
            this.createSpecialityButton.Click += new System.EventHandler(this.createSpecialityButton_Click);
            // 
            // specialityListBox
            // 
            this.specialityListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialityListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialityListBox.FormattingEnabled = true;
            this.specialityListBox.ItemHeight = 20;
            this.specialityListBox.Location = new System.Drawing.Point(288, 188);
            this.specialityListBox.Name = "specialityListBox";
            this.specialityListBox.Size = new System.Drawing.Size(193, 164);
            this.specialityListBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(288, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Име на специалност";
            // 
            // specialityNameTextBox
            // 
            this.specialityNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialityNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialityNameTextBox.Location = new System.Drawing.Point(288, 76);
            this.specialityNameTextBox.Name = "specialityNameTextBox";
            this.specialityNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.specialityNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(288, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Избери специалност";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.specialityNameTextBox);
            this.panel1.Controls.Add(this.deleteSpecialityButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.createSpecialityButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.specialityListBox);
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
            // DoctorSpecialityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoctorSpecialityForm";
            this.Text = "Докторски специалности";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button deleteSpecialityButton;
        private Button createSpecialityButton;
        private ListBox specialityListBox;
        private Label label7;
        private TextBox specialityNameTextBox;
        private Label label4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
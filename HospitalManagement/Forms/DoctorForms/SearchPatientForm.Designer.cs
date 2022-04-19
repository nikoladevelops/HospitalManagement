namespace HospitalManagement.Forms.DoctorForms
{
    partial class SearchPatientForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editSelectedPatientButton = new System.Windows.Forms.Button();
            this.foundPatientsListBox = new System.Windows.Forms.ListBox();
            this.showSelectedPatientButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteSelectedPatientButton = new System.Windows.Forms.Button();
            this.searchCriteriaListBox = new System.Windows.Forms.ListBox();
            this.searchDoctorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showSelectedPatientPrescriptionsButton = new System.Windows.Forms.Button();
            this.createSelectedPatientPrescription = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(178, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Търси пациент";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(178, 76);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(195, 27);
            this.searchTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label10.Location = new System.Drawing.Point(379, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Намерени пациенти";
            // 
            // editSelectedPatientButton
            // 
            this.editSelectedPatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editSelectedPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.editSelectedPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSelectedPatientButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSelectedPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.editSelectedPatientButton.Location = new System.Drawing.Point(379, 334);
            this.editSelectedPatientButton.Name = "editSelectedPatientButton";
            this.editSelectedPatientButton.Size = new System.Drawing.Size(195, 32);
            this.editSelectedPatientButton.TabIndex = 7;
            this.editSelectedPatientButton.Text = "Редактирай избрания";
            this.editSelectedPatientButton.UseVisualStyleBackColor = false;
            this.editSelectedPatientButton.Click += new System.EventHandler(this.editSelectedPatientButton_Click);
            // 
            // foundPatientsListBox
            // 
            this.foundPatientsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foundPatientsListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foundPatientsListBox.FormattingEnabled = true;
            this.foundPatientsListBox.ItemHeight = 20;
            this.foundPatientsListBox.Location = new System.Drawing.Point(379, 76);
            this.foundPatientsListBox.Name = "foundPatientsListBox";
            this.foundPatientsListBox.Size = new System.Drawing.Size(195, 184);
            this.foundPatientsListBox.TabIndex = 4;
            // 
            // showSelectedPatientButton
            // 
            this.showSelectedPatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showSelectedPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.showSelectedPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSelectedPatientButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showSelectedPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.showSelectedPatientButton.Location = new System.Drawing.Point(379, 266);
            this.showSelectedPatientButton.Name = "showSelectedPatientButton";
            this.showSelectedPatientButton.Size = new System.Drawing.Size(195, 32);
            this.showSelectedPatientButton.TabIndex = 5;
            this.showSelectedPatientButton.Text = "Покажи избрания";
            this.showSelectedPatientButton.UseVisualStyleBackColor = false;
            this.showSelectedPatientButton.Click += new System.EventHandler(this.showSelectedPatientButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label9.Location = new System.Drawing.Point(178, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Избери по какво";
            // 
            // deleteSelectedPatientButton
            // 
            this.deleteSelectedPatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSelectedPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.deleteSelectedPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPatientButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.deleteSelectedPatientButton.Location = new System.Drawing.Point(379, 300);
            this.deleteSelectedPatientButton.Name = "deleteSelectedPatientButton";
            this.deleteSelectedPatientButton.Size = new System.Drawing.Size(195, 32);
            this.deleteSelectedPatientButton.TabIndex = 6;
            this.deleteSelectedPatientButton.Text = "Изтрий избрания";
            this.deleteSelectedPatientButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPatientButton.Click += new System.EventHandler(this.deleteSelectedPatientButton_Click);
            // 
            // searchCriteriaListBox
            // 
            this.searchCriteriaListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchCriteriaListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCriteriaListBox.FormattingEnabled = true;
            this.searchCriteriaListBox.ItemHeight = 20;
            this.searchCriteriaListBox.Location = new System.Drawing.Point(178, 134);
            this.searchCriteriaListBox.Name = "searchCriteriaListBox";
            this.searchCriteriaListBox.Size = new System.Drawing.Size(195, 184);
            this.searchCriteriaListBox.TabIndex = 2;
            // 
            // searchDoctorButton
            // 
            this.searchDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.searchDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchDoctorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchDoctorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.searchDoctorButton.Location = new System.Drawing.Point(178, 324);
            this.searchDoctorButton.Name = "searchDoctorButton";
            this.searchDoctorButton.Size = new System.Drawing.Size(195, 46);
            this.searchDoctorButton.TabIndex = 3;
            this.searchDoctorButton.Text = "Намери пациент";
            this.searchDoctorButton.UseVisualStyleBackColor = false;
            this.searchDoctorButton.Click += new System.EventHandler(this.searchPatientButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.026958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.97305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showSelectedPatientPrescriptionsButton);
            this.panel1.Controls.Add(this.createSelectedPatientPrescription);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.editSelectedPatientButton);
            this.panel1.Controls.Add(this.searchCriteriaListBox);
            this.panel1.Controls.Add(this.foundPatientsListBox);
            this.panel1.Controls.Add(this.showSelectedPatientButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.deleteSelectedPatientButton);
            this.panel1.Controls.Add(this.searchDoctorButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 444);
            this.panel1.TabIndex = 0;
            // 
            // showSelectedPatientPrescriptionsButton
            // 
            this.showSelectedPatientPrescriptionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showSelectedPatientPrescriptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.showSelectedPatientPrescriptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSelectedPatientPrescriptionsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showSelectedPatientPrescriptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.showSelectedPatientPrescriptionsButton.Location = new System.Drawing.Point(379, 403);
            this.showSelectedPatientPrescriptionsButton.Name = "showSelectedPatientPrescriptionsButton";
            this.showSelectedPatientPrescriptionsButton.Size = new System.Drawing.Size(195, 32);
            this.showSelectedPatientPrescriptionsButton.TabIndex = 9;
            this.showSelectedPatientPrescriptionsButton.Text = "Виж всички рецепти";
            this.showSelectedPatientPrescriptionsButton.UseVisualStyleBackColor = false;
            this.showSelectedPatientPrescriptionsButton.Click += new System.EventHandler(this.showSelectedPatientPrescriptionsButton_Click);
            // 
            // createSelectedPatientPrescription
            // 
            this.createSelectedPatientPrescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createSelectedPatientPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.createSelectedPatientPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSelectedPatientPrescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createSelectedPatientPrescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.createSelectedPatientPrescription.Location = new System.Drawing.Point(379, 368);
            this.createSelectedPatientPrescription.Name = "createSelectedPatientPrescription";
            this.createSelectedPatientPrescription.Size = new System.Drawing.Size(195, 32);
            this.createSelectedPatientPrescription.TabIndex = 8;
            this.createSelectedPatientPrescription.Text = "Създай рецепта";
            this.createSelectedPatientPrescription.UseVisualStyleBackColor = false;
            this.createSelectedPatientPrescription.Click += new System.EventHandler(this.createSelectedPatientPrescription_Click);
            // 
            // SearchPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchPatientForm";
            this.Text = "Търси пациент";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label8;
        private TextBox searchTextBox;
        private Label label10;
        private Button editSelectedPatientButton;
        private ListBox foundPatientsListBox;
        private Button showSelectedPatientButton;
        private Label label9;
        private Button deleteSelectedPatientButton;
        private ListBox searchCriteriaListBox;
        private Button searchDoctorButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button createSelectedPatientPrescription;
        private Button showSelectedPatientPrescriptionsButton;
    }
}
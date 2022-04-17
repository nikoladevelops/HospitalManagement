namespace HospitalManagement.Forms.AdminForms
{
    partial class SearchDoctorForm
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
            this.editSelectedDoctorButton = new System.Windows.Forms.Button();
            this.foundDoctorsListBox = new System.Windows.Forms.ListBox();
            this.showSelectedDoctorButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteSelectedDoctorButton = new System.Windows.Forms.Button();
            this.searchCriteriaListBox = new System.Windows.Forms.ListBox();
            this.searchDoctorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Търси доктор";
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
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Намерени доктори";
            // 
            // editSelectedDoctorButton
            // 
            this.editSelectedDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editSelectedDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.editSelectedDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSelectedDoctorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSelectedDoctorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.editSelectedDoctorButton.Location = new System.Drawing.Point(379, 324);
            this.editSelectedDoctorButton.Name = "editSelectedDoctorButton";
            this.editSelectedDoctorButton.Size = new System.Drawing.Size(195, 46);
            this.editSelectedDoctorButton.TabIndex = 6;
            this.editSelectedDoctorButton.Text = "Редактирай избрания";
            this.editSelectedDoctorButton.UseVisualStyleBackColor = false;
            this.editSelectedDoctorButton.Click += new System.EventHandler(this.editSelectedDoctorButton_Click);
            // 
            // foundDoctorsListBox
            // 
            this.foundDoctorsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foundDoctorsListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foundDoctorsListBox.FormattingEnabled = true;
            this.foundDoctorsListBox.ItemHeight = 20;
            this.foundDoctorsListBox.Location = new System.Drawing.Point(379, 76);
            this.foundDoctorsListBox.Name = "foundDoctorsListBox";
            this.foundDoctorsListBox.Size = new System.Drawing.Size(195, 184);
            this.foundDoctorsListBox.TabIndex = 4;
            // 
            // showSelectedDoctorButton
            // 
            this.showSelectedDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showSelectedDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.showSelectedDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSelectedDoctorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showSelectedDoctorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.showSelectedDoctorButton.Location = new System.Drawing.Point(379, 272);
            this.showSelectedDoctorButton.Name = "showSelectedDoctorButton";
            this.showSelectedDoctorButton.Size = new System.Drawing.Size(195, 46);
            this.showSelectedDoctorButton.TabIndex = 5;
            this.showSelectedDoctorButton.Text = "Покажи избрания";
            this.showSelectedDoctorButton.UseVisualStyleBackColor = false;
            this.showSelectedDoctorButton.Click += new System.EventHandler(this.showSelectedDoctorButton_Click);
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
            // deleteSelectedDoctorButton
            // 
            this.deleteSelectedDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSelectedDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.deleteSelectedDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedDoctorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedDoctorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.deleteSelectedDoctorButton.Location = new System.Drawing.Point(379, 376);
            this.deleteSelectedDoctorButton.Name = "deleteSelectedDoctorButton";
            this.deleteSelectedDoctorButton.Size = new System.Drawing.Size(195, 48);
            this.deleteSelectedDoctorButton.TabIndex = 7;
            this.deleteSelectedDoctorButton.Text = "Изтрий избрания";
            this.deleteSelectedDoctorButton.UseVisualStyleBackColor = false;
            this.deleteSelectedDoctorButton.Click += new System.EventHandler(this.deleteSelectedDoctorButton_Click);
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
            this.searchDoctorButton.Text = "Намери доктор";
            this.searchDoctorButton.UseVisualStyleBackColor = false;
            this.searchDoctorButton.Click += new System.EventHandler(this.searchDoctorButton_Click);
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
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.editSelectedDoctorButton);
            this.panel1.Controls.Add(this.searchCriteriaListBox);
            this.panel1.Controls.Add(this.foundDoctorsListBox);
            this.panel1.Controls.Add(this.showSelectedDoctorButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.deleteSelectedDoctorButton);
            this.panel1.Controls.Add(this.searchDoctorButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 444);
            this.panel1.TabIndex = 0;
            // 
            // SearchDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchDoctorForm";
            this.Text = "Търси доктор";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label8;
        private TextBox searchTextBox;
        private Label label10;
        private Button editSelectedDoctorButton;
        private ListBox foundDoctorsListBox;
        private Button showSelectedDoctorButton;
        private Label label9;
        private Button deleteSelectedDoctorButton;
        private ListBox searchCriteriaListBox;
        private Button searchDoctorButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
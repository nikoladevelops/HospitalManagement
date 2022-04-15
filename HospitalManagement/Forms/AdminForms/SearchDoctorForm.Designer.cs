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
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Търси доктор";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(236, 65);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(157, 23);
            this.searchTextBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Намерени доктори";
            // 
            // editSelectedDoctorButton
            // 
            this.editSelectedDoctorButton.Location = new System.Drawing.Point(412, 308);
            this.editSelectedDoctorButton.Name = "editSelectedDoctorButton";
            this.editSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.editSelectedDoctorButton.TabIndex = 36;
            this.editSelectedDoctorButton.Text = "Редактирай избрания";
            this.editSelectedDoctorButton.UseVisualStyleBackColor = true;
            // 
            // foundDoctorsListBox
            // 
            this.foundDoctorsListBox.FormattingEnabled = true;
            this.foundDoctorsListBox.ItemHeight = 15;
            this.foundDoctorsListBox.Location = new System.Drawing.Point(412, 116);
            this.foundDoctorsListBox.Name = "foundDoctorsListBox";
            this.foundDoctorsListBox.Size = new System.Drawing.Size(157, 124);
            this.foundDoctorsListBox.TabIndex = 33;
            // 
            // showSelectedDoctorButton
            // 
            this.showSelectedDoctorButton.Location = new System.Drawing.Point(412, 256);
            this.showSelectedDoctorButton.Name = "showSelectedDoctorButton";
            this.showSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.showSelectedDoctorButton.TabIndex = 37;
            this.showSelectedDoctorButton.Text = "Покажи избрания";
            this.showSelectedDoctorButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Избери по какво";
            // 
            // deleteSelectedDoctorButton
            // 
            this.deleteSelectedDoctorButton.Location = new System.Drawing.Point(412, 357);
            this.deleteSelectedDoctorButton.Name = "deleteSelectedDoctorButton";
            this.deleteSelectedDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.deleteSelectedDoctorButton.TabIndex = 35;
            this.deleteSelectedDoctorButton.Text = "Изтрий избрания";
            this.deleteSelectedDoctorButton.UseVisualStyleBackColor = true;
            // 
            // searchCriteriaListBox
            // 
            this.searchCriteriaListBox.FormattingEnabled = true;
            this.searchCriteriaListBox.ItemHeight = 15;
            this.searchCriteriaListBox.Location = new System.Drawing.Point(236, 116);
            this.searchCriteriaListBox.Name = "searchCriteriaListBox";
            this.searchCriteriaListBox.Size = new System.Drawing.Size(157, 124);
            this.searchCriteriaListBox.TabIndex = 31;
            // 
            // searchDoctorButton
            // 
            this.searchDoctorButton.Location = new System.Drawing.Point(232, 256);
            this.searchDoctorButton.Name = "searchDoctorButton";
            this.searchDoctorButton.Size = new System.Drawing.Size(157, 46);
            this.searchDoctorButton.TabIndex = 28;
            this.searchDoctorButton.Text = "Намери доктор";
            this.searchDoctorButton.UseVisualStyleBackColor = true;
            // 
            // SearchDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.editSelectedDoctorButton);
            this.Controls.Add(this.foundDoctorsListBox);
            this.Controls.Add(this.showSelectedDoctorButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteSelectedDoctorButton);
            this.Controls.Add(this.searchCriteriaListBox);
            this.Controls.Add(this.searchDoctorButton);
            this.Name = "SearchDoctorForm";
            this.Text = "SearchDoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
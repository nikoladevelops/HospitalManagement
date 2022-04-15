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
            this.SuspendLayout();
            // 
            // deleteSpecialityButton
            // 
            this.deleteSpecialityButton.Location = new System.Drawing.Point(441, 283);
            this.deleteSpecialityButton.Name = "deleteSpecialityButton";
            this.deleteSpecialityButton.Size = new System.Drawing.Size(136, 41);
            this.deleteSpecialityButton.TabIndex = 4;
            this.deleteSpecialityButton.Text = "Изтрий избрана специалност";
            this.deleteSpecialityButton.UseVisualStyleBackColor = true;
            this.deleteSpecialityButton.Click += new System.EventHandler(this.deleteSpecialityButton_Click);
            // 
            // createSpecialityButton
            // 
            this.createSpecialityButton.Location = new System.Drawing.Point(278, 126);
            this.createSpecialityButton.Name = "createSpecialityButton";
            this.createSpecialityButton.Size = new System.Drawing.Size(157, 46);
            this.createSpecialityButton.TabIndex = 2;
            this.createSpecialityButton.Text = "Създай специалност";
            this.createSpecialityButton.UseVisualStyleBackColor = true;
            this.createSpecialityButton.Click += new System.EventHandler(this.createSpecialityButton_Click);
            // 
            // specialityListBox
            // 
            this.specialityListBox.FormattingEnabled = true;
            this.specialityListBox.ItemHeight = 15;
            this.specialityListBox.Location = new System.Drawing.Point(278, 200);
            this.specialityListBox.Name = "specialityListBox";
            this.specialityListBox.Size = new System.Drawing.Size(157, 124);
            this.specialityListBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Име на специалност";
            // 
            // specialityNameTextBox
            // 
            this.specialityNameTextBox.Location = new System.Drawing.Point(278, 98);
            this.specialityNameTextBox.Name = "specialityNameTextBox";
            this.specialityNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.specialityNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Избери специалност";
            // 
            // DoctorSpecialityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteSpecialityButton);
            this.Controls.Add(this.createSpecialityButton);
            this.Controls.Add(this.specialityListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.specialityNameTextBox);
            this.Controls.Add(this.label4);
            this.Name = "DoctorSpecialityForm";
            this.Text = "Докторски специалности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteSpecialityButton;
        private Button createSpecialityButton;
        private ListBox specialityListBox;
        private Label label7;
        private TextBox specialityNameTextBox;
        private Label label4;
    }
}
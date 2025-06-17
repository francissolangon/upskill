namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.btnComputeSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRatePerHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComputeSalary
            // 
            this.btnComputeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnComputeSalary.Location = new System.Drawing.Point(172, 245);
            this.btnComputeSalary.Name = "btnComputeSalary";
            this.btnComputeSalary.Size = new System.Drawing.Size(135, 33);
            this.btnComputeSalary.TabIndex = 0;
            this.btnComputeSalary.Text = "Compute Salary";
            this.btnComputeSalary.UseVisualStyleBackColor = true;
            this.btnComputeSalary.Click += new System.EventHandler(this.btnComputeSalary_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(25, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(209, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.Location = new System.Drawing.Point(243, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(209, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(239, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJobTitle.Location = new System.Drawing.Point(243, 109);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(209, 26);
            this.txtJobTitle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(239, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Job Title";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepartment.Location = new System.Drawing.Point(25, 109);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(209, 26);
            this.txtDepartment.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoursWorked.Location = new System.Drawing.Point(243, 203);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(209, 26);
            this.txtHoursWorked.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(239, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = " Total hours worked";
            // 
            // txtRatePerHour
            // 
            this.txtRatePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRatePerHour.Location = new System.Drawing.Point(25, 203);
            this.txtRatePerHour.Name = "txtRatePerHour";
            this.txtRatePerHour.Size = new System.Drawing.Size(209, 26);
            this.txtRatePerHour.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(21, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rate per hour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(21, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "First name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(21, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(19, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(115, 306);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(133, 20);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "<first name here>";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.Location = new System.Drawing.Point(115, 343);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(132, 20);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "<last name here>";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBasicSalary.Location = new System.Drawing.Point(115, 381);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(49, 20);
            this.lblBasicSalary.TabIndex = 18;
            this.lblBasicSalary.Text = "00.00";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 461);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRatePerHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComputeSalary);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComputeSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRatePerHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBasicSalary;
    }
}


namespace SCD_Frontend
{
    partial class AdminForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.department_tabPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parent_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Parent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.department_treeView = new System.Windows.Forms.TreeView();
            this.employee_tabPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.employee_textBox = new System.Windows.Forms.TextBox();
            this.manager_textBox = new System.Windows.Forms.TextBox();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.delete_employee_button = new System.Windows.Forms.Button();
            this.edit_employee_button = new System.Windows.Forms.Button();
            this.add_employeee_button = new System.Windows.Forms.Button();
            this.employee_treeView = new System.Windows.Forms.TreeView();
            this.department_comboBox = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.department_tabPage.SuspendLayout();
            this.employee_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.department_tabPage);
            this.tabControl.Controls.Add(this.employee_tabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1127, 504);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // department_tabPage
            // 
            this.department_tabPage.Controls.Add(this.label9);
            this.department_tabPage.Controls.Add(this.label6);
            this.department_tabPage.Controls.Add(this.label5);
            this.department_tabPage.Controls.Add(this.label4);
            this.department_tabPage.Controls.Add(this.parent_textBox);
            this.department_tabPage.Controls.Add(this.description_textBox);
            this.department_tabPage.Controls.Add(this.name_textBox);
            this.department_tabPage.Controls.Add(this.Email);
            this.department_tabPage.Controls.Add(this.label8);
            this.department_tabPage.Controls.Add(this.label7);
            this.department_tabPage.Controls.Add(this.Parent);
            this.department_tabPage.Controls.Add(this.label3);
            this.department_tabPage.Controls.Add(this.label2);
            this.department_tabPage.Controls.Add(this.delete_button);
            this.department_tabPage.Controls.Add(this.modify_button);
            this.department_tabPage.Controls.Add(this.add_button);
            this.department_tabPage.Controls.Add(this.label1);
            this.department_tabPage.Controls.Add(this.department_treeView);
            this.department_tabPage.Location = new System.Drawing.Point(4, 25);
            this.department_tabPage.Name = "department_tabPage";
            this.department_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.department_tabPage.Size = new System.Drawing.Size(1119, 475);
            this.department_tabPage.TabIndex = 0;
            this.department_tabPage.Text = "Department";
            this.department_tabPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Parent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Department";
            // 
            // parent_textBox
            // 
            this.parent_textBox.Location = new System.Drawing.Point(423, 59);
            this.parent_textBox.Name = "parent_textBox";
            this.parent_textBox.Size = new System.Drawing.Size(300, 22);
            this.parent_textBox.TabIndex = 10;
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(425, 189);
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(298, 22);
            this.description_textBox.TabIndex = 6;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(423, 122);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(300, 22);
            this.name_textBox.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(689, 508);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(0, 16);
            this.Email.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 13;
            // 
            // Parent
            // 
            this.Parent.AutoSize = true;
            this.Parent.Location = new System.Drawing.Point(420, 40);
            this.Parent.Name = "Parent";
            this.Parent.Size = new System.Drawing.Size(0, 16);
            this.Parent.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(812, 207);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(115, 60);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(812, 127);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(115, 56);
            this.modify_button.TabIndex = 3;
            this.modify_button.Text = "MODIFY";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(812, 41);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(115, 58);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // department_treeView
            // 
            this.department_treeView.Location = new System.Drawing.Point(20, 40);
            this.department_treeView.Name = "department_treeView";
            this.department_treeView.Size = new System.Drawing.Size(352, 338);
            this.department_treeView.TabIndex = 0;
            this.department_treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.department_treeView_NodeMouseClick);
            // 
            // employee_tabPage
            // 
            this.employee_tabPage.Controls.Add(this.label15);
            this.employee_tabPage.Controls.Add(this.label12);
            this.employee_tabPage.Controls.Add(this.label14);
            this.employee_tabPage.Controls.Add(this.label13);
            this.employee_tabPage.Controls.Add(this.label11);
            this.employee_tabPage.Controls.Add(this.label10);
            this.employee_tabPage.Controls.Add(this.email_textBox);
            this.employee_tabPage.Controls.Add(this.employee_textBox);
            this.employee_tabPage.Controls.Add(this.manager_textBox);
            this.employee_tabPage.Controls.Add(this.department_textBox);
            this.employee_tabPage.Controls.Add(this.delete_employee_button);
            this.employee_tabPage.Controls.Add(this.edit_employee_button);
            this.employee_tabPage.Controls.Add(this.add_employeee_button);
            this.employee_tabPage.Controls.Add(this.employee_treeView);
            this.employee_tabPage.Controls.Add(this.department_comboBox);
            this.employee_tabPage.Location = new System.Drawing.Point(4, 25);
            this.employee_tabPage.Name = "employee_tabPage";
            this.employee_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employee_tabPage.Size = new System.Drawing.Size(1119, 475);
            this.employee_tabPage.TabIndex = 1;
            this.employee_tabPage.Text = "Employee";
            this.employee_tabPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Departments";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Employees";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Employee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Manager";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Departament";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(375, 322);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(269, 22);
            this.email_textBox.TabIndex = 8;
            // 
            // employee_textBox
            // 
            this.employee_textBox.Location = new System.Drawing.Point(375, 235);
            this.employee_textBox.Name = "employee_textBox";
            this.employee_textBox.Size = new System.Drawing.Size(269, 22);
            this.employee_textBox.TabIndex = 7;
            // 
            // manager_textBox
            // 
            this.manager_textBox.Location = new System.Drawing.Point(375, 152);
            this.manager_textBox.Name = "manager_textBox";
            this.manager_textBox.Size = new System.Drawing.Size(269, 22);
            this.manager_textBox.TabIndex = 6;
            // 
            // department_textBox
            // 
            this.department_textBox.Location = new System.Drawing.Point(375, 68);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(269, 22);
            this.department_textBox.TabIndex = 5;
            // 
            // delete_employee_button
            // 
            this.delete_employee_button.Location = new System.Drawing.Point(864, 303);
            this.delete_employee_button.Name = "delete_employee_button";
            this.delete_employee_button.Size = new System.Drawing.Size(106, 54);
            this.delete_employee_button.TabIndex = 4;
            this.delete_employee_button.Text = "DELETE";
            this.delete_employee_button.UseVisualStyleBackColor = true;
            this.delete_employee_button.Click += new System.EventHandler(this.delete_employee_button_Click);
            // 
            // edit_employee_button
            // 
            this.edit_employee_button.Location = new System.Drawing.Point(870, 196);
            this.edit_employee_button.Name = "edit_employee_button";
            this.edit_employee_button.Size = new System.Drawing.Size(100, 57);
            this.edit_employee_button.TabIndex = 3;
            this.edit_employee_button.Text = "EDIT";
            this.edit_employee_button.UseVisualStyleBackColor = true;
            this.edit_employee_button.Click += new System.EventHandler(this.edit_employee_button_Click);
            // 
            // add_employeee_button
            // 
            this.add_employeee_button.Location = new System.Drawing.Point(870, 102);
            this.add_employeee_button.Name = "add_employeee_button";
            this.add_employeee_button.Size = new System.Drawing.Size(100, 56);
            this.add_employeee_button.TabIndex = 2;
            this.add_employeee_button.Text = "ADD";
            this.add_employeee_button.UseVisualStyleBackColor = true;
            this.add_employeee_button.Click += new System.EventHandler(this.add_employeee_button_Click);
            // 
            // employee_treeView
            // 
            this.employee_treeView.Location = new System.Drawing.Point(36, 112);
            this.employee_treeView.Name = "employee_treeView";
            this.employee_treeView.Size = new System.Drawing.Size(264, 336);
            this.employee_treeView.TabIndex = 1;
            this.employee_treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.employee_treeView_NodeMouseClick);
            // 
            // department_comboBox
            // 
            this.department_comboBox.FormattingEnabled = true;
            this.department_comboBox.Location = new System.Drawing.Point(36, 40);
            this.department_comboBox.Name = "department_comboBox";
            this.department_comboBox.Size = new System.Drawing.Size(143, 24);
            this.department_comboBox.TabIndex = 0;
            this.department_comboBox.SelectedIndexChanged += new System.EventHandler(this.department_comboBox_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 539);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl.ResumeLayout(false);
            this.department_tabPage.ResumeLayout(false);
            this.department_tabPage.PerformLayout();
            this.employee_tabPage.ResumeLayout(false);
            this.employee_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage department_tabPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parent_textBox;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Parent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView department_treeView;
        private System.Windows.Forms.TabPage employee_tabPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox employee_textBox;
        private System.Windows.Forms.TextBox manager_textBox;
        private System.Windows.Forms.TextBox department_textBox;
        private System.Windows.Forms.Button delete_employee_button;
        private System.Windows.Forms.Button edit_employee_button;
        private System.Windows.Forms.Button add_employeee_button;
        private System.Windows.Forms.TreeView employee_treeView;
        private System.Windows.Forms.ComboBox department_comboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
    }
}
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
            this.logout_button = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.department_treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Parent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.parent_textBox = new System.Windows.Forms.TextBox();
            this.department_tabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.employee_tabPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.department_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(1001, 8);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(126, 48);
            this.logout_button.TabIndex = 0;
            this.logout_button.Text = "LOGOUT";
            this.logout_button.UseVisualStyleBackColor = true;
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
            // department_treeView
            // 
            this.department_treeView.Location = new System.Drawing.Point(20, 40);
            this.department_treeView.Name = "department_treeView";
            this.department_treeView.Size = new System.Drawing.Size(352, 338);
            this.department_treeView.TabIndex = 0;
            this.department_treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.department_treeView_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // Parent
            // 
            this.Parent.AutoSize = true;
            this.Parent.Location = new System.Drawing.Point(420, 40);
            this.Parent.Name = "Parent";
            this.Parent.Size = new System.Drawing.Size(0, 16);
            this.Parent.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 14;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(689, 508);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(0, 16);
            this.Email.TabIndex = 15;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(423, 122);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(300, 22);
            this.name_textBox.TabIndex = 5;
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(425, 189);
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(298, 22);
            this.description_textBox.TabIndex = 6;
            // 
            // parent_textBox
            // 
            this.parent_textBox.Location = new System.Drawing.Point(423, 59);
            this.parent_textBox.Name = "parent_textBox";
            this.parent_textBox.Size = new System.Drawing.Size(300, 22);
            this.parent_textBox.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Department";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name";
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
            // employee_tabPage
            // 
            this.employee_tabPage.Location = new System.Drawing.Point(4, 25);
            this.employee_tabPage.Name = "employee_tabPage";
            this.employee_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employee_tabPage.Size = new System.Drawing.Size(1126, 600);
            this.employee_tabPage.TabIndex = 1;
            this.employee_tabPage.Text = "Employee";
            this.employee_tabPage.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 539);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl.ResumeLayout(false);
            this.department_tabPage.ResumeLayout(false);
            this.department_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logout_button;
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
    }
}
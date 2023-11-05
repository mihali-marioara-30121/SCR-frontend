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
            this.employee_tabPage = new System.Windows.Forms.TabPage();
            this.logout_button = new System.Windows.Forms.Button();
            this.department_treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.department_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.department_tabPage);
            this.tabControl.Controls.Add(this.employee_tabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(799, 414);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // department_tabPage
            // 
            this.department_tabPage.Controls.Add(this.delete_button);
            this.department_tabPage.Controls.Add(this.modify_button);
            this.department_tabPage.Controls.Add(this.add_button);
            this.department_tabPage.Controls.Add(this.label1);
            this.department_tabPage.Controls.Add(this.department_treeView1);
            this.department_tabPage.Location = new System.Drawing.Point(4, 25);
            this.department_tabPage.Name = "department_tabPage";
            this.department_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.department_tabPage.Size = new System.Drawing.Size(791, 385);
            this.department_tabPage.TabIndex = 0;
            this.department_tabPage.Text = "Department";
            this.department_tabPage.UseVisualStyleBackColor = true;
            // 
            // employee_tabPage
            // 
            this.employee_tabPage.Location = new System.Drawing.Point(4, 25);
            this.employee_tabPage.Name = "employee_tabPage";
            this.employee_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employee_tabPage.Size = new System.Drawing.Size(791, 385);
            this.employee_tabPage.TabIndex = 1;
            this.employee_tabPage.Text = "Employee";
            this.employee_tabPage.UseVisualStyleBackColor = true;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(666, 8);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(126, 48);
            this.logout_button.TabIndex = 0;
            this.logout_button.Text = "LOGOUT";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // department_treeView1
            // 
            this.department_treeView1.Location = new System.Drawing.Point(20, 40);
            this.department_treeView1.Name = "department_treeView1";
            this.department_treeView1.Size = new System.Drawing.Size(329, 303);
            this.department_treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departments:";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(492, 78);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(115, 58);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(492, 170);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(115, 56);
            this.modify_button.TabIndex = 3;
            this.modify_button.Text = "button2";
            this.modify_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(492, 259);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(115, 60);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage department_tabPage;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView department_treeView1;
        private System.Windows.Forms.TabPage employee_tabPage;
        private System.Windows.Forms.Button logout_button;
    }
}
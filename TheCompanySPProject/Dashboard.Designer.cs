namespace TheCompanySPProject
{
    partial class Dashboard
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
            this.DepartmentEmployeesList = new System.Windows.Forms.ListBox();
            this.DepartmentText = new System.Windows.Forms.TextBox();
            this.Departmentlbl = new System.Windows.Forms.Label();
            this.getDataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getAllDepBtn = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditDepBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.managertextbox = new System.Windows.Forms.TextBox();
            this.ManagerText = new System.Windows.Forms.Label();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartmentEmployeesList
            // 
            this.DepartmentEmployeesList.FormattingEnabled = true;
            this.DepartmentEmployeesList.ItemHeight = 25;
            this.DepartmentEmployeesList.Location = new System.Drawing.Point(29, 143);
            this.DepartmentEmployeesList.Name = "DepartmentEmployeesList";
            this.DepartmentEmployeesList.Size = new System.Drawing.Size(314, 279);
            this.DepartmentEmployeesList.TabIndex = 0;
            // 
            // DepartmentText
            // 
            this.DepartmentText.Location = new System.Drawing.Point(192, 60);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(125, 31);
            this.DepartmentText.TabIndex = 1;
            this.DepartmentText.TextChanged += new System.EventHandler(this.DepartmentText_TextChanged);
            // 
            // Departmentlbl
            // 
            this.Departmentlbl.AutoSize = true;
            this.Departmentlbl.Location = new System.Drawing.Point(24, 60);
            this.Departmentlbl.Name = "Departmentlbl";
            this.Departmentlbl.Size = new System.Drawing.Size(146, 25);
            this.Departmentlbl.TabIndex = 2;
            this.Departmentlbl.Text = "Department id";
            // 
            // getDataBtn
            // 
            this.getDataBtn.Location = new System.Drawing.Point(210, 97);
            this.getDataBtn.Name = "getDataBtn";
            this.getDataBtn.Size = new System.Drawing.Size(133, 40);
            this.getDataBtn.TabIndex = 3;
            this.getDataBtn.Text = "getDepById";
            this.getDataBtn.UseVisualStyleBackColor = true;
            this.getDataBtn.Click += new System.EventHandler(this.getDataBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "GetSP\'s";
            // 
            // getAllDepBtn
            // 
            this.getAllDepBtn.Location = new System.Drawing.Point(67, 97);
            this.getAllDepBtn.Name = "getAllDepBtn";
            this.getAllDepBtn.Size = new System.Drawing.Size(127, 40);
            this.getAllDepBtn.TabIndex = 5;
            this.getAllDepBtn.Text = "getAllDep";
            this.getAllDepBtn.UseVisualStyleBackColor = true;
            this.getAllDepBtn.Click += new System.EventHandler(this.getAllDepBtn_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(525, 60);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(100, 31);
            this.editTextBox.TabIndex = 6;
            this.editTextBox.TextChanged += new System.EventHandler(this.editTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // EditDepBtn
            // 
            this.EditDepBtn.Location = new System.Drawing.Point(631, 59);
            this.EditDepBtn.Name = "EditDepBtn";
            this.EditDepBtn.Size = new System.Drawing.Size(106, 33);
            this.EditDepBtn.TabIndex = 8;
            this.EditDepBtn.Text = "edit";
            this.EditDepBtn.UseVisualStyleBackColor = true;
            this.EditDepBtn.Click += new System.EventHandler(this.EditDepBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Create/ Edit SP";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(631, 97);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 38);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // managertextbox
            // 
            this.managertextbox.Location = new System.Drawing.Point(525, 97);
            this.managertextbox.Name = "managertextbox";
            this.managertextbox.Size = new System.Drawing.Size(100, 31);
            this.managertextbox.TabIndex = 11;
            // 
            // ManagerText
            // 
            this.ManagerText.AutoSize = true;
            this.ManagerText.Location = new System.Drawing.Point(422, 100);
            this.ManagerText.Name = "ManagerText";
            this.ManagerText.Size = new System.Drawing.Size(97, 25);
            this.ManagerText.TabIndex = 12;
            this.ManagerText.Text = "Manager";
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Location = new System.Drawing.Point(349, 378);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(170, 33);
            this.deleteSelectedBtn.TabIndex = 13;
            this.deleteSelectedBtn.Text = "Delete selected";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedBtn.Click += new System.EventHandler(this.deleteSelectedBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 423);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.ManagerText);
            this.Controls.Add(this.managertextbox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditDepBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.getAllDepBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getDataBtn);
            this.Controls.Add(this.Departmentlbl);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.DepartmentEmployeesList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "StoredProcedures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DepartmentEmployeesList;
        private System.Windows.Forms.TextBox DepartmentText;
        private System.Windows.Forms.Label Departmentlbl;
        private System.Windows.Forms.Button getDataBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getAllDepBtn;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditDepBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox managertextbox;
        private System.Windows.Forms.Label ManagerText;
        private System.Windows.Forms.Button deleteSelectedBtn;
    }
}


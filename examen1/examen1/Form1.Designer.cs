namespace examen1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSalary = new TextBox();
            txtId = new TextBox();
            txtName = new TextBox();
            btnAddEmployee = new Button();
            btnCalculateTotalSalary = new Button();
            btnSaveToFile = new Button();
            btnLoadFromFile = new Button();
            lstEmployees = new ListBox();
            lblTotalSalary = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClearList = new Button();
            SuspendLayout();
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(393, 82);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(47, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(47, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(205, 82);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(111, 23);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Añadir Empleado";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnCalculateTotalSalary
            // 
            btnCalculateTotalSalary.Location = new Point(516, 82);
            btnCalculateTotalSalary.Name = "btnCalculateTotalSalary";
            btnCalculateTotalSalary.Size = new Size(146, 23);
            btnCalculateTotalSalary.TabIndex = 4;
            btnCalculateTotalSalary.Text = "Calcular total de salario";
            btnCalculateTotalSalary.UseVisualStyleBackColor = true;
            btnCalculateTotalSalary.Click += btnCalculateTotalSalary_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(47, 373);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(103, 23);
            btnSaveToFile.TabIndex = 5;
            btnSaveToFile.Text = "Guardar Archivo";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(193, 373);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(97, 23);
            btnLoadFromFile.TabIndex = 6;
            btnLoadFromFile.Text = "Cargar Archivo";
            btnLoadFromFile.UseVisualStyleBackColor = true;
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(47, 167);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(615, 184);
            lstEmployees.TabIndex = 7;
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.AutoSize = true;
            lblTotalSalary.Location = new Point(462, 377);
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(0, 15);
            lblTotalSalary.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 25);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 9;
            label1.Text = "Id del empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 91);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre del empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 57);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 11;
            label3.Text = "Salario:";
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(329, 373);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(83, 23);
            btnClearList.TabIndex = 12;
            btnClearList.Text = "Limpiar lista";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 450);
            Controls.Add(btnClearList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalSalary);
            Controls.Add(lstEmployees);
            Controls.Add(btnLoadFromFile);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnCalculateTotalSalary);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(txtSalary);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalary;
        private TextBox txtId;
        private TextBox txtName;
        private Button btnAddEmployee;
        private Button btnCalculateTotalSalary;
        private Button btnSaveToFile;
        private Button btnLoadFromFile;
        private ListBox lstEmployees;
        private Label lblTotalSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClearList;
    }
}

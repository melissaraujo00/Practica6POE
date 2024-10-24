namespace PresentationLayer.Forms
{
    partial class StudentForm
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
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            dgvStudent = new DataGridView();
            label3 = new Label();
            txtNameStudent = new TextBox();
            label2 = new Label();
            adminTitleLabel = new Label();
            txtLastnameStudent = new TextBox();
            label1 = new Label();
            btnShowCareers = new Button();
            cbxCareerStudent = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(424, 663);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(230, 663);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 663);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(590, 148);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.Size = new Size(610, 482);
            dgvStudent.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 353);
            label3.Name = "label3";
            label3.Size = new Size(303, 32);
            label3.TabIndex = 12;
            label3.Text = "Apellidos del Estudiante:";
            // 
            // txtNameStudent
            // 
            txtNameStudent.Location = new Point(52, 264);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(421, 31);
            txtNameStudent.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 209);
            label2.Name = "label2";
            label2.Size = new Size(289, 32);
            label2.TabIndex = 10;
            label2.Text = "Nombre del Estudiante:";
            // 
            // adminTitleLabel
            // 
            adminTitleLabel.AutoSize = true;
            adminTitleLabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminTitleLabel.Location = new Point(384, 43);
            adminTitleLabel.Name = "adminTitleLabel";
            adminTitleLabel.Size = new Size(433, 38);
            adminTitleLabel.TabIndex = 9;
            adminTitleLabel.Text = "Administrador de Estudiantes";
            // 
            // txtLastnameStudent
            // 
            txtLastnameStudent.Location = new Point(52, 414);
            txtLastnameStudent.Name = "txtLastnameStudent";
            txtLastnameStudent.Size = new Size(421, 31);
            txtLastnameStudent.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 500);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 19;
            label1.Text = "Carrera del Estudiante";
            // 
            // btnShowCareers
            // 
            btnShowCareers.Location = new Point(343, 741);
            btnShowCareers.Name = "btnShowCareers";
            btnShowCareers.Size = new Size(597, 34);
            btnShowCareers.TabIndex = 21;
            btnShowCareers.Text = "Ver Carreras";
            btnShowCareers.UseVisualStyleBackColor = true;
            btnShowCareers.Click += btnShowCareers_Click;
            // 
            // cbxCareerStudent
            // 
            cbxCareerStudent.FormattingEnabled = true;
            cbxCareerStudent.Location = new Point(52, 567);
            cbxCareerStudent.Name = "cbxCareerStudent";
            cbxCareerStudent.Size = new Size(421, 33);
            cbxCareerStudent.TabIndex = 22;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 805);
            Controls.Add(cbxCareerStudent);
            Controls.Add(btnShowCareers);
            Controls.Add(label1);
            Controls.Add(txtLastnameStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(dgvStudent);
            Controls.Add(label3);
            Controls.Add(txtNameStudent);
            Controls.Add(label2);
            Controls.Add(adminTitleLabel);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private DataGridView dgvStudent;
        private Label label3;
        private TextBox txtNameStudent;
        private Label label2;
        private Label adminTitleLabel;
        private TextBox txtLastnameStudent;
        private TextBox textBox1;
        private Label label1;
        private Button btnShowCareers;
        private ComboBox cbxCareerStudent;
    }
}
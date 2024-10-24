namespace PresentationLayer.Forms
{
    partial class CareerForm
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
            label1 = new Label();
            label2 = new Label();
            txtNameCareer = new TextBox();
            label3 = new Label();
            txtDescriptionCarrer = new TextBox();
            dgvCareers = new DataGridView();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCareers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 29);
            label1.Name = "label1";
            label1.Size = new Size(387, 38);
            label1.TabIndex = 0;
            label1.Text = "Administrador de Carreras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 195);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la Carrera:";
            // 
            // txtNameCareer
            // 
            txtNameCareer.Location = new Point(42, 254);
            txtNameCareer.Name = "txtNameCareer";
            txtNameCareer.Size = new Size(421, 31);
            txtNameCareer.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 341);
            label3.Name = "label3";
            label3.Size = new Size(318, 32);
            label3.TabIndex = 3;
            label3.Text = "Descripcion de la Carrera: ";
            // 
            // txtDescriptionCarrer
            // 
            txtDescriptionCarrer.Location = new Point(42, 407);
            txtDescriptionCarrer.Multiline = true;
            txtDescriptionCarrer.Name = "txtDescriptionCarrer";
            txtDescriptionCarrer.Size = new Size(524, 257);
            txtDescriptionCarrer.TabIndex = 4;
            // 
            // dgvCareers
            // 
            dgvCareers.AllowUserToAddRows = false;
            dgvCareers.AllowUserToDeleteRows = false;
            dgvCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCareers.Location = new Point(607, 164);
            dgvCareers.Name = "dgvCareers";
            dgvCareers.ReadOnly = true;
            dgvCareers.RowHeadersWidth = 62;
            dgvCareers.Size = new Size(643, 654);
            dgvCareers.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(42, 784);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(248, 784);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(442, 784);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CareerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 908);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(dgvCareers);
            Controls.Add(txtDescriptionCarrer);
            Controls.Add(label3);
            Controls.Add(txtNameCareer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CareerForm";
            Text = "CareerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCareers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNameCareer;
        private Label label3;
        private TextBox txtDescriptionCarrer;
        private DataGridView dgvCareers;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
    }
}
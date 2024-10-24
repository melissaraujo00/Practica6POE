using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class StudentForm : Form
    {
        private readonly StudentService _studentService;
        private readonly CarrerService _carrerService;
        bool isEdit = false;
        public StudentForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _carrerService = new CarrerService();

            loadStudentData();
            loadCbxCareers();
        }

        private void loadStudentData()
        {
            dgvStudent.DataSource = _studentService.GetAllStudent();
        }

        private void loadCbxCareers()
        {
            cbxCareerStudent.DataSource = _carrerService.GetAllCarrers();
            cbxCareerStudent.DisplayMember = "nameCareer";
            cbxCareerStudent.ValueMember = "idCareer";

        }
        private void CleanParameter()
        {
            txtNameStudent.Clear();
            txtLastnameStudent.Clear();
            cbxCareerStudent.SelectedValue = 0;
            txtNameStudent.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Studen studen = new Studen();
            if (isEdit)
            {
                studen.idStudent = int.Parse(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                studen.nameStudent = txtNameStudent.Text;
                studen.lastnameStudent = txtLastnameStudent.Text;
                studen.idCareerStudent = Convert.ToInt32(cbxCareerStudent.SelectedValue);

                _studentService.UpdateStudent(studen);
                isEdit = false;
            }
            else
            {
                studen.nameStudent = txtNameStudent.Text;
                studen.lastnameStudent = txtLastnameStudent.Text;
                studen.idCareerStudent = Convert.ToInt32(cbxCareerStudent.SelectedValue);

                _studentService.AddStudent(studen);
            }
            loadStudentData();
            CleanParameter();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                txtNameStudent.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                txtLastnameStudent.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
                cbxCareerStudent.SelectedValue = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                isEdit = true;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe sekeccionar una fila a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Esta seguro que desea eliminar este dato? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                    _studentService.DeleteStudent(id);
                }
            }
        }

        private void btnShowCareers_Click(object sender, EventArgs e)
        {
            CareerForm career = new CareerForm();
            career.FormClosed += (s, args) => loadCbxCareers();
            career.ShowDialog();
        }
    }
}

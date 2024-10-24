using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Services;
using CommonLayer;
using CommonLayer.Entities;


namespace PresentationLayer.Forms
{
    public partial class CareerForm : Form
    {
        private CarrerService _carrerService;
        private bool isEditing = false;

        public CareerForm()
        {
            _carrerService = new CarrerService();
            InitializeComponent();

            LoadCareerData();
        }

        public void LoadCareerData()
        {
            dgvCareers.DataSource = _carrerService.GetAllCarrers();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Career carrer = new Career();
                carrer.nameCareer = txtNameCareer.Text;
                carrer.descriptionCareer = txtDescriptionCarrer.Text;
                carrer.idCareer = int.Parse(dgvCareers.CurrentRow.Cells[0].Value.ToString());

                _carrerService.UpdateCareer(carrer);
                LoadCareerData();
                cleanParamenters();

                isEditing = false;
            }
            else
            {
                Career carrer = new Career();
                carrer.nameCareer = txtNameCareer.Text;
                carrer.descriptionCareer = txtDescriptionCarrer.Text;

                _carrerService.AddCareers(carrer);
                LoadCareerData();
                cleanParamenters();
            }
        }

        public void cleanParamenters()
        {
            txtNameCareer.Clear();
            txtDescriptionCarrer.Clear();
            txtNameCareer.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCareers.SelectedRows.Count > 0)
            {
                txtNameCareer.Text = dgvCareers.CurrentRow.Cells[1].Value.ToString();
                txtDescriptionCarrer.Text = dgvCareers.CurrentRow.Cells[2].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCareers.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe sleccionar una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleteConfirm = new DialogResult();
                deleteConfirm = MessageBox.Show("Desea borrar el registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(dgvCareers.CurrentRow.Cells[0].Value.ToString());
                    _carrerService.DeleteCareer(id);

                    LoadCareerData();
                    cleanParamenters();
                }
            }
        }
    }
}

using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmProfessores : Form
    {
        BindingSource info;
        public frmProfessores()
        {
            InitializeComponent();
            info = new BindingSource();
            dtGridProfessores.DataSource = info;
        }

        private void dtGridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        private void txtturno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtnomecurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtidcurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntcadastrarcurso_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade prof = new ProfessoresEntidade();
            prof.Id = Convert.ToInt32(numericidprof.Text);
            prof.Nome = txtnomeprofessor.Text;
            prof.Apelido = txtapelidoprof.Text;
            info.Add(prof);
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnlimparprof_Click(object sender, EventArgs e)
        {
            txtnomeprofessor.Text = "";
            txtapelidoprof.Text = "";

        }
    }
}

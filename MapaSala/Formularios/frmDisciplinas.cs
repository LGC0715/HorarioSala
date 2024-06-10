
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
    public partial class frmDisciplinas : Form
    {
        public frmDisciplinas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtidprofessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntcadastrardisciplina_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade disc = new DisciplinasEntidade();
            disc.Id = Convert.ToInt32(txtiddisciplinas.Text);
            disc.NomeDisciplina = txtnomedisciplina.Text;
            disc.Area = txtarea.Text;

            dados.Add(curso);
        }
    }
}

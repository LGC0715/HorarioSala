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
    public partial class frmCursos : Form
    {
        BindingSource dados;
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCursos.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = new CursosEntidade();
            curso.Id = Convert.ToInt32(txtidcurso.Text);
            curso.NomeCurso = txtnomecurso.Text;
            curso.Turno = txtturno.Text;
            curso.Ativo = chkativo.Checked;

            dados.Add(curso);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

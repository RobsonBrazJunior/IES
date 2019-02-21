using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class DisciplinaForm : Form
    {
        DisciplinaServico disciplinaServico;
        string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;

        public DisciplinaForm()
        {
            InitializeComponent();
            disciplinaServico = new DisciplinaServico(new SqlConnection(connectionString));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disciplinaServico.Inserir(new Disciplina()
            {
                Nome = txtNome.Text,
                CargaHoraria = Convert.ToInt16(txtCargaHoraria.Text)
            });
            //AtualizarDataGridView();
            MessageBox.Show("Inserção realizada com sucesso!");
        }

        //private void AtualizarDataGridView()
        //{
        //    dgvDisciplinas.DataSource = null;
        //    dgvDisciplinas.DataSource = disciplinaServico.ObterTodas();
        //}
    }
}

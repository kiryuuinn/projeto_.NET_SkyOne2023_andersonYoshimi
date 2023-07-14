using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste04
{
    public partial class LancamentoNotas : Form
    {
        public LancamentoNotas()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Teste1;Trusted_Connection=True;");
            connection.Open();


            string nome = txtNome.Text;
            string nota1 = txtNota1.Text;
            double nota1Double = double.Parse(txtNota1.Text);
            string nota2 = txtNota2.Text;
            double nota2Double = double.Parse(txtNota2.Text);
            int ano = DateTime.Today.Year;

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES (@nome, @ano, @nota1, @nota2)", connection);
                command.Parameters.Add(new SqlParameter("@nome", nome));
                command.Parameters.Add(new SqlParameter("@ano", ano));
                command.Parameters.Add(new SqlParameter("@nota1", nota1Double));
                command.Parameters.Add(new SqlParameter("@nota2", nota2Double));

                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
        }
    }
}

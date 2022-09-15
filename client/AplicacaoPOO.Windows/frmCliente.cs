using AplicacaoPOO.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPOO.Windows
{
    public partial class frmCliente : Form
    {
        private object txtnome;

        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.Nome = "Shamyra Messias";
            txtNome.Text = cliente.Nome;
            txtCPF.Text = "568.357.845-00";
            lblSaldoInicialValor.Text = "1000";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            var credito = new Credito();
            


        }
    }
}

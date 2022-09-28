using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmConversorMoeda : Form
    {

        public frmConversorMoeda()
        {
            InitializeComponent();
            btnConverterEmReal.Enabled = false;
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
            txtValorEmDolar.Text = "1";

            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libras);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {

            if (txtValorEmDolar.Text == "")
            {
                cmbMoedas.Enabled = false;
                return;
            }
            cmbMoedas.Enabled = true;
            EfetuarConversaoMoeda();
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfetuarConversaoMoeda();
        }

        private void EfetuarConversaoMoeda()
        {
            try
            {
                #region Calculo da Conversao
                if (txtValorEmDolar.Text == "") return;

                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moedaService = new ConverterMoedaServices();

                switch (cmbMoedas.SelectedValue)
                {
                    case MoedaHelper.Dolar:
                        {
                            var valorConvertido = moedaService.ConverterDolarEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Euro:
                        {
                            var valorConvertido = moedaService.ConverterEuroEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Libras:
                        {
                            var valorConvertido = moedaService.ConverterLibraEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                }
                  #endregion
            }  
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar o valor númerico");
                txtValorEmDolar.Text = String.Empty;
                txtValorEmDolar.Focus();
            }


        }
    }
}
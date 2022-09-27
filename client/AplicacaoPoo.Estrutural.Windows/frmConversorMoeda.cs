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

            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Real);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libras);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;



        }                      


        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
           
             try
              {
                if (txtValorEmDolar.Text == "") return;
                 
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

                var moeda = new ConverterMoedaServices();
                var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";


            }
                catch (Exception)
                {
                    MessageBox.Show("A cotação do dalor é um valor decimal");
                    txtValorEmDolar.Focus();
                    btnConverterEmReal.Enabled = false;

                }
            
        }

  
        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtValorEmDolar.Text == "") return;

            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moedaService = new ConverterMoedaServices(); 
            switch (cmbMoedas.SelectedValue)
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaService.ConverterDolarEmReal(decimal.Parse(txtValorEmDolar.Text));
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }

               case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(decimal.Parse(txtValorEmDolar.Text));
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }

               case MoedaHelper.Libras:
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(decimal.Parse(txtValorEmDolar.Text));
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
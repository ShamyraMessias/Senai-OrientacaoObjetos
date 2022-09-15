namespace AplicacaoPOO.Windows
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.lblSaldoInicialValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(311, 63);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 23);
            this.txtCredito.TabIndex = 0;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(262, 12);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(149, 23);
            this.txtCPF.TabIndex = 1;
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(99, 60);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(100, 23);
            this.txtDebito.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 23);
            this.txtNome.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nome.Location = new System.Drawing.Point(2, 12);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(41, 15);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(219, 15);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 15);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDebito.Location = new System.Drawing.Point(2, 63);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(91, 15);
            this.lblDebito.TabIndex = 6;
            this.lblDebito.Text = "Valor de debito";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCredito.Location = new System.Drawing.Point(210, 66);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(95, 15);
            this.lblCredito.TabIndex = 7;
            this.lblCredito.Text = "Valor de credito";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(129, 108);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 40);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = " Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(468, 20);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(84, 15);
            this.lblSaldoInicial.TabIndex = 9;
            this.lblSaldoInicial.Text = "SALDO INCIAL";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(487, 89);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 15);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "SALDO";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.Location = new System.Drawing.Point(502, 133);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoValor.TabIndex = 11;
            this.lblSaldoValor.Text = "0";
            // 
            // lblSaldoInicialValor
            // 
            this.lblSaldoInicialValor.AutoSize = true;
            this.lblSaldoInicialValor.Location = new System.Drawing.Point(502, 50);
            this.lblSaldoInicialValor.Name = "lblSaldoInicialValor";
            this.lblSaldoInicialValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoInicialValor.TabIndex = 12;
            this.lblSaldoInicialValor.Text = "0";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 208);
            this.Controls.Add(this.lblSaldoInicialValor);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCredito);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCredito;
        private TextBox txtCPF;
        private TextBox txtDebito;
        private TextBox txtNome;
        private Label Nome;
        private Label lblCPF;
        private Label lblDebito;
        private Label lblCredito;
        private Button btnCalcular;
        private Label lblSaldoInicial;
        private Label lblSaldo;
        private Label lblSaldoValor;
        private Label lblSaldoInicialValor;
    }
}
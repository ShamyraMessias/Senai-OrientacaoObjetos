namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.btnConverterEmReal = new System.Windows.Forms.Button();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorEmDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorEmDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEmDolar.ForeColor = System.Drawing.Color.White;
            this.txtValorEmDolar.Location = new System.Drawing.Point(23, 110);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "informe o valor em dolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(213, 22);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // btnConverterEmReal
            // 
            this.btnConverterEmReal.BackColor = System.Drawing.Color.Cyan;
            this.btnConverterEmReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterEmReal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverterEmReal.Location = new System.Drawing.Point(151, 148);
            this.btnConverterEmReal.Name = "btnConverterEmReal";
            this.btnConverterEmReal.Size = new System.Drawing.Size(142, 30);
            this.btnConverterEmReal.TabIndex = 2;
            this.btnConverterEmReal.Text = "Converter em Reais";
            this.btnConverterEmReal.UseVisualStyleBackColor = false;
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(46, 22);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 17);
            this.lblPrimeiroValor.TabIndex = 3;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(23, 55);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 30);
            this.lblSegundoValor.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            this.comboBox1.BackColorChanged += new System.EventHandler(this.comboBox1_BackColorChanged);
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.btnConverterEmReal);
            this.Controls.Add(this.txtValorEmDolar);
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Button btnConverterEmReal;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private ComboBox comboBox1;
    }
}
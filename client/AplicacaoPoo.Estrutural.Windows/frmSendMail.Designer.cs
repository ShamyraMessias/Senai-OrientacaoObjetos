namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmSendMail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblSuporteContato = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(30, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(30, 63);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(340, 23);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lblSuporteContato
            // 
            this.lblSuporteContato.AutoSize = true;
            this.lblSuporteContato.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuporteContato.Location = new System.Drawing.Point(133, 9);
            this.lblSuporteContato.Name = "lblSuporteContato";
            this.lblSuporteContato.Size = new System.Drawing.Size(120, 18);
            this.lblSuporteContato.TabIndex = 2;
            this.lblSuporteContato.Text = "Suporte e Contato";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(30, 205);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(340, 96);
            this.txtMensagem.TabIndex = 3;
            this.txtMensagem.Text = "";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(30, 151);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(340, 23);
            this.txtAssunto.TabIndex = 4;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(30, 45);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(96, 15);
            this.lblNomeCompleto.TabIndex = 5;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(30, 133);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(50, 15);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(30, 187);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(66, 15);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "Mensagem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "ENVIAR MENSAGEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(390, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblSuporteContato);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmSendMail";
            this.Text = "frmSendMail";
            this.Load += new System.EventHandler(this.frmSendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtNomeCompleto;
        private Label lblSuporteContato;
        private RichTextBox txtMensagem;
        private TextBox txtAssunto;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private Label lblAssunto;
        private Label lblMensagem;
        private Button button1;
    }
}
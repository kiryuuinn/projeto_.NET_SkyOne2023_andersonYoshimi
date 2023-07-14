namespace Teste04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntrar = new Button();
            label1 = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            lblValidacao = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(367, 168);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 151);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(261, 169);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(155, 169);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 151);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // lblValidacao
            // 
            lblValidacao.AutoSize = true;
            lblValidacao.ForeColor = Color.Red;
            lblValidacao.Location = new Point(155, 195);
            lblValidacao.Name = "lblValidacao";
            lblValidacao.Size = new Size(0, 15);
            lblValidacao.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidacao);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Name = "Form1";
            Text = "Login do Professor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label2;
        private Label lblValidacao;
    }
}
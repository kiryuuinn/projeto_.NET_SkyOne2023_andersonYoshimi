namespace Teste04
{
    partial class LancamentoNotas
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNota1 = new TextBox();
            label3 = new Label();
            txtNota2 = new TextBox();
            btnEnviar = new Button();
            btnLimparCampos = new Button();
            label4 = new Label();
            lblStatusAluno = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(55, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(394, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 27);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 91);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Nota do 1 Semestre";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(55, 109);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(168, 23);
            txtNota1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 91);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota do 2 Semestre";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(276, 109);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(173, 23);
            txtNota2.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(55, 167);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(168, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Location = new Point(276, 167);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(173, 23);
            btnLimparCampos.TabIndex = 7;
            btnLimparCampos.Text = "Limpar Campos";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 233);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 8;
            label4.Text = "Status do Aluno:";
            // 
            // lblStatusAluno
            // 
            lblStatusAluno.AutoSize = true;
            lblStatusAluno.Location = new Point(155, 233);
            lblStatusAluno.Name = "lblStatusAluno";
            lblStatusAluno.Size = new Size(103, 15);
            lblStatusAluno.TabIndex = 9;
            lblStatusAluno.Text = "Nota não enviada.";
            // 
            // LancamentoNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatusAluno);
            Controls.Add(label4);
            Controls.Add(btnLimparCampos);
            Controls.Add(btnEnviar);
            Controls.Add(txtNota2);
            Controls.Add(label3);
            Controls.Add(txtNota1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "LancamentoNotas";
            Text = "LancamentoNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtNota1;
        private Label label3;
        private TextBox txtNota2;
        private Button btnEnviar;
        private Button btnLimparCampos;
        private Label label4;
        private Label lblStatusAluno;
    }
}
namespace TP_03_PROJETO_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtLocal = new TextBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnMostrar = new Button();
            txtAnoEdicao = new TextBox();
            txtEditora = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 69);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 109);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 148);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Editora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 189);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Ano Edição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 226);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Local:";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(182, 226);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(332, 23);
            txtLocal.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(156, 288);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(113, 46);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(301, 288);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(113, 46);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(445, 288);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(113, 46);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtAnoEdicao
            // 
            txtAnoEdicao.Location = new Point(182, 186);
            txtAnoEdicao.Name = "txtAnoEdicao";
            txtAnoEdicao.Size = new Size(137, 23);
            txtAnoEdicao.TabIndex = 9;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(182, 145);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(397, 23);
            txtEditora.TabIndex = 10;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(182, 106);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(397, 23);
            txtAutor.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(182, 66);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(397, 23);
            txtTitulo.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 407);
            Controls.Add(txtTitulo);
            Controls.Add(txtAutor);
            Controls.Add(txtEditora);
            Controls.Add(txtAnoEdicao);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(txtLocal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtLocal;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnMostrar;
        private TextBox txtAnoEdicao;
        private TextBox txtEditora;
        private TextBox txtAutor;
        private TextBox txtTitulo;
    }
}
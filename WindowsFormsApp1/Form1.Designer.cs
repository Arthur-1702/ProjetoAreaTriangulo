namespace WindowsFormsApp1
{
    partial class FmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.tituloBase = new System.Windows.Forms.Label();
            this.tituloAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.Button();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.tituloArea = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBase
            // 
            this.textBoxBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBase.Location = new System.Drawing.Point(105, 98);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(153, 20);
            this.textBoxBase.TabIndex = 0;
            // 
            // tituloBase
            // 
            this.tituloBase.AutoSize = true;
            this.tituloBase.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloBase.Location = new System.Drawing.Point(108, 75);
            this.tituloBase.Name = "tituloBase";
            this.tituloBase.Size = new System.Drawing.Size(38, 16);
            this.tituloBase.TabIndex = 1;
            this.tituloBase.Text = "Base";
            // 
            // tituloAltura
            // 
            this.tituloAltura.AutoSize = true;
            this.tituloAltura.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAltura.Location = new System.Drawing.Point(108, 137);
            this.tituloAltura.Name = "tituloAltura";
            this.tituloAltura.Size = new System.Drawing.Size(46, 16);
            this.tituloAltura.TabIndex = 3;
            this.tituloAltura.Text = "Altura";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAltura.Location = new System.Drawing.Point(105, 160);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(153, 20);
            this.textBoxAltura.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(43, 24);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(263, 26);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Área do triângulo";
            this.Titulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArea.Location = new System.Drawing.Point(87, 229);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(188, 34);
            this.buttonArea.TabIndex = 5;
            this.buttonArea.Text = "ENCONTRAR ÁREA";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // textBoxArea
            // 
            this.textBoxArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxArea.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArea.Location = new System.Drawing.Point(39, 330);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(278, 28);
            this.textBoxArea.TabIndex = 6;
            // 
            // tituloArea
            // 
            this.tituloArea.AutoSize = true;
            this.tituloArea.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloArea.Location = new System.Drawing.Point(149, 307);
            this.tituloArea.Name = "tituloArea";
            this.tituloArea.Size = new System.Drawing.Size(46, 20);
            this.tituloArea.TabIndex = 7;
            this.tituloArea.Text = "Área";
            this.tituloArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(129, 364);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(90, 34);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(45, 400);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(0, 13);
            this.labelMsg.TabIndex = 9;
            // 
            // FmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.tituloArea);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.tituloAltura);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.tituloBase);
            this.Controls.Add(this.textBoxBase);
            this.Name = "FmInicio";
            this.Text = "Calcula área triangulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Label tituloBase;
        private System.Windows.Forms.Label tituloAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label tituloArea;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelMsg;
    }
}


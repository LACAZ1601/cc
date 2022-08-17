namespace EXERCICIO3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.R1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia percorrida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Combustível gasto:";
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(198, 147);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(36, 13);
            this.R1.TabIndex = 3;
            this.R1.Text = "Média";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(201, 55);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(100, 20);
            this.T1.TabIndex = 5;
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(201, 102);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(100, 20);
            this.T2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label R1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
    }
}


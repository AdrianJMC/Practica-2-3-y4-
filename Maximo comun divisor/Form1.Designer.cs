namespace Maximo_comun_divisor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.Instruccion_1 = new System.Windows.Forms.Label();
            this.Instrucciom_2 = new System.Windows.Forms.Label();
            this.numero_1 = new System.Windows.Forms.TextBox();
            this.numero_2 = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.Titulo.Location = new System.Drawing.Point(137, 20);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(500, 38);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Calcular maximo comun divisor";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Instruccion_1
            // 
            this.Instruccion_1.AutoSize = true;
            this.Instruccion_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.Instruccion_1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruccion_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.Instruccion_1.Location = new System.Drawing.Point(227, 86);
            this.Instruccion_1.Name = "Instruccion_1";
            this.Instruccion_1.Size = new System.Drawing.Size(307, 23);
            this.Instruccion_1.TabIndex = 1;
            this.Instruccion_1.Text = "Introduce el primer numero:";
            this.Instruccion_1.Click += new System.EventHandler(this.Instruccion_1_Click);
            // 
            // Instrucciom_2
            // 
            this.Instrucciom_2.AutoSize = true;
            this.Instrucciom_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.Instrucciom_2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrucciom_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.Instrucciom_2.Location = new System.Drawing.Point(227, 166);
            this.Instrucciom_2.Name = "Instrucciom_2";
            this.Instrucciom_2.Size = new System.Drawing.Size(318, 23);
            this.Instrucciom_2.TabIndex = 2;
            this.Instrucciom_2.Text = "Introduce el segundo numero:";
            this.Instrucciom_2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numero_1
            // 
            this.numero_1.Location = new System.Drawing.Point(240, 122);
            this.numero_1.Name = "numero_1";
            this.numero_1.Size = new System.Drawing.Size(278, 22);
            this.numero_1.TabIndex = 3;
            this.numero_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numero_1.TextChanged += new System.EventHandler(this.numero_1_TextChanged);
            // 
            // numero_2
            // 
            this.numero_2.Location = new System.Drawing.Point(240, 212);
            this.numero_2.Name = "numero_2";
            this.numero_2.Size = new System.Drawing.Size(278, 22);
            this.numero_2.TabIndex = 4;
            this.numero_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numero_2.TextChanged += new System.EventHandler(this.numero_2_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calcular.Location = new System.Drawing.Point(238, 262);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(284, 30);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "calcular maximo comun divisor";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.flowLayoutPanel1.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 429);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.Resultado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.Resultado.Location = new System.Drawing.Point(171, 335);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(64, 29);
            this.Resultado.TabIndex = 7;
            this.Resultado.Text = ".....";
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resultado.UseCompatibleTextRendering = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.numero_2);
            this.Controls.Add(this.numero_1);
            this.Controls.Add(this.Instrucciom_2);
            this.Controls.Add(this.Instruccion_1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calcular maximo comun divisor";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Instruccion_1;
        private System.Windows.Forms.Label Instrucciom_2;
        private System.Windows.Forms.TextBox numero_1;
        private System.Windows.Forms.TextBox numero_2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label Resultado;
    }
}


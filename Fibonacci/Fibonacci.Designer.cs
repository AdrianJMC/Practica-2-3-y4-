namespace Fibonacci
{
    partial class Fibonacci
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
            this.Instrucción = new System.Windows.Forms.Label();
            this.ingresar_valor = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.Label();
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(283, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(188, 42);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Fibonacci";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // Instrucción
            // 
            this.Instrucción.AutoSize = true;
            this.Instrucción.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrucción.Location = new System.Drawing.Point(296, 80);
            this.Instrucción.Name = "Instrucción";
            this.Instrucción.Size = new System.Drawing.Size(163, 25);
            this.Instrucción.TabIndex = 1;
            this.Instrucción.Text = "Ingresa un valor:";
            this.Instrucción.Click += new System.EventHandler(this.Instrucción_Click);
            // 
            // ingresar_valor
            // 
            this.ingresar_valor.Location = new System.Drawing.Point(231, 117);
            this.ingresar_valor.Name = "ingresar_valor";
            this.ingresar_valor.Size = new System.Drawing.Size(306, 22);
            this.ingresar_valor.TabIndex = 2;
            this.ingresar_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ingresar_valor.TextChanged += new System.EventHandler(this.ingresar_valor_TextChanged);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(328, 213);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(107, 25);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "Resultado:";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(35, 275);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(32, 25);
            this.respuesta.TabIndex = 4;
            this.respuesta.Text = "....";
            this.respuesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.respuesta.Click += new System.EventHandler(this.respuesta_Click);
            // 
            // boton_Calcular
            // 
            this.boton_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Calcular.Location = new System.Drawing.Point(316, 145);
            this.boton_Calcular.Name = "boton_Calcular";
            this.boton_Calcular.Size = new System.Drawing.Size(119, 43);
            this.boton_Calcular.TabIndex = 5;
            this.boton_Calcular.Text = "Calcular";
            this.boton_Calcular.UseVisualStyleBackColor = true;
            this.boton_Calcular.Click += new System.EventHandler(this.boton_Calcular_Click);
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_Calcular);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.ingresar_valor);
            this.Controls.Add(this.Instrucción);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Instrucción;
        private System.Windows.Forms.TextBox ingresar_valor;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Button boton_Calcular;
    }
}


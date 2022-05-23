namespace Phrases
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Entender = new System.Windows.Forms.Button();
            this.Escribir = new System.Windows.Forms.Button();
            this.Traducir = new System.Windows.Forms.Button();
            this.Selecciona = new System.Windows.Forms.CheckedListBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Entrada = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Button();
            this.LR = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.GroupBox();
            this.Regresar = new System.Windows.Forms.Button();
            this.Restantes = new System.Windows.Forms.Label();
            this.Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entender
            // 
            this.Entender.Location = new System.Drawing.Point(84, 30);
            this.Entender.Name = "Entender";
            this.Entender.Size = new System.Drawing.Size(109, 60);
            this.Entender.TabIndex = 0;
            this.Entender.Tag = "";
            this.Entender.Text = "Entender";
            this.Entender.UseVisualStyleBackColor = true;
            this.Entender.Click += new System.EventHandler(this.Entender_Click);
            // 
            // Escribir
            // 
            this.Escribir.Location = new System.Drawing.Point(84, 96);
            this.Escribir.Name = "Escribir";
            this.Escribir.Size = new System.Drawing.Size(109, 60);
            this.Escribir.TabIndex = 1;
            this.Escribir.Text = "Escribir";
            this.Escribir.UseVisualStyleBackColor = true;
            this.Escribir.Click += new System.EventHandler(this.Escribir_Click);
            // 
            // Traducir
            // 
            this.Traducir.Location = new System.Drawing.Point(84, 162);
            this.Traducir.Name = "Traducir";
            this.Traducir.Size = new System.Drawing.Size(109, 60);
            this.Traducir.TabIndex = 2;
            this.Traducir.Text = "Traducir";
            this.Traducir.UseVisualStyleBackColor = true;
            this.Traducir.Click += new System.EventHandler(this.Traducir_Click);
            // 
            // Selecciona
            // 
            this.Selecciona.FormattingEnabled = true;
            this.Selecciona.Location = new System.Drawing.Point(12, 12);
            this.Selecciona.Name = "Selecciona";
            this.Selecciona.Size = new System.Drawing.Size(181, 229);
            this.Selecciona.TabIndex = 3;
            this.Selecciona.Visible = false;
            this.Selecciona.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Selecciona_ItemCheck);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(197, 226);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Visible = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(6, 19);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(40, 37);
            this.Play.TabIndex = 5;
            this.Play.Text = "Reproducir";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Visible = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Entrada
            // 
            this.Entrada.Location = new System.Drawing.Point(12, 183);
            this.Entrada.Multiline = true;
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(260, 20);
            this.Entrada.TabIndex = 7;
            this.Entrada.Visible = false;
            this.Entrada.TextChanged += new System.EventHandler(this.Entrada_TextChanged);
            // 
            // R
            // 
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(52, 19);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(40, 37);
            this.R.TabIndex = 9;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Visible = false;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Location = new System.Drawing.Point(12, 153);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(58, 13);
            this.LR.TabIndex = 10;
            this.LR.Text = "Respuesta";
            this.LR.Visible = false;
            // 
            // Opciones
            // 
            this.Opciones.Controls.Add(this.Play);
            this.Opciones.Controls.Add(this.R);
            this.Opciones.Location = new System.Drawing.Point(12, 63);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(100, 67);
            this.Opciones.TabIndex = 11;
            this.Opciones.TabStop = false;
            this.Opciones.Text = "Opciones";
            this.Opciones.Visible = false;
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(199, 12);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 12;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Visible = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Restantes
            // 
            this.Restantes.AutoSize = true;
            this.Restantes.Location = new System.Drawing.Point(200, 42);
            this.Restantes.Name = "Restantes";
            this.Restantes.Size = new System.Drawing.Size(67, 13);
            this.Restantes.TabIndex = 13;
            this.Restantes.Text = "Restantes: ?";
            this.Restantes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Restantes);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Selecciona);
            this.Controls.Add(this.Traducir);
            this.Controls.Add(this.Escribir);
            this.Controls.Add(this.Entender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Opciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entender;
        private System.Windows.Forms.Button Escribir;
        private System.Windows.Forms.Button Traducir;
        private System.Windows.Forms.CheckedListBox Selecciona;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.TextBox Entrada;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.GroupBox Opciones;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label Restantes;
    }
}


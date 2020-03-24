namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bIzquierdo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 163);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bIzquierdo
            // 
            this.bIzquierdo.Location = new System.Drawing.Point(26, 193);
            this.bIzquierdo.Name = "bIzquierdo";
            this.bIzquierdo.Size = new System.Drawing.Size(30, 30);
            this.bIzquierdo.TabIndex = 1;
            this.bIzquierdo.Text = "<";
            this.bIzquierdo.UseVisualStyleBackColor = true;
            this.bIzquierdo.Click += new System.EventHandler(this.bIzquierdo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(249, 27);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(192, 56);
            this.nombre.TabIndex = 3;
            // 
            // VentanaPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(614, 429);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bIzquierdo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bIzquierda;
        private System.Windows.Forms.Button bderecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bIzquierdo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nombre;
    }
}


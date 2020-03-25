namespace PokedexC_sharp
{
    partial class Buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.BuscaId = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buscaNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(292, 164);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(141, 22);
            this.textBoxID.TabIndex = 0;
            // 
            // BuscaId
            // 
            this.BuscaId.Location = new System.Drawing.Point(470, 164);
            this.BuscaId.Name = "BuscaId";
            this.BuscaId.Size = new System.Drawing.Size(75, 23);
            this.BuscaId.TabIndex = 1;
            this.BuscaId.Text = "button1";
            this.BuscaId.UseVisualStyleBackColor = true;
            this.BuscaId.Click += new System.EventHandler(this.BuscaId_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(292, 217);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(144, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // buscaNombre
            // 
            this.buscaNombre.Location = new System.Drawing.Point(470, 216);
            this.buscaNombre.Name = "buscaNombre";
            this.buscaNombre.Size = new System.Drawing.Size(75, 23);
            this.buscaNombre.TabIndex = 3;
            this.buscaNombre.Text = "bnombre";
            this.buscaNombre.UseVisualStyleBackColor = true;
            this.buscaNombre.Click += new System.EventHandler(this.buscaNombre_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscaNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.BuscaId);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscador";
            this.Text = "Pokedex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button BuscaId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buscaNombre;
    }
}

namespace appEquiposfutbol
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnFutbolistas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEquipos.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnEquipos.FlatAppearance.BorderSize = 3;
            this.btnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEquipos.Location = new System.Drawing.Point(276, 103);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(268, 80);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.Text = "Registrar Equipos";
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnFutbolistas
            // 
            this.btnFutbolistas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFutbolistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFutbolistas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFutbolistas.Location = new System.Drawing.Point(276, 207);
            this.btnFutbolistas.Name = "btnFutbolistas";
            this.btnFutbolistas.Size = new System.Drawing.Size(268, 80);
            this.btnFutbolistas.TabIndex = 1;
            this.btnFutbolistas.Text = "Registar Futbolistas";
            this.btnFutbolistas.UseVisualStyleBackColor = false;
            this.btnFutbolistas.Click += new System.EventHandler(this.btnFutbolistas_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFutbolistas);
            this.Controls.Add(this.btnEquipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPrincipal";
            this.Text = "appEquiposFutbol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnFutbolistas;
    }
}


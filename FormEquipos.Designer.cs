
namespace appEquiposfutbol
{
    partial class FormEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipos));
            this.lbInformacion = new System.Windows.Forms.Label();
            this.lblCodigoEqui = new System.Windows.Forms.Label();
            this.lblNombreEqui = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAnioFundacion = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtCodigoEqui = new System.Windows.Forms.TextBox();
            this.txtNombreEqui = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtAnioFundacion = new System.Windows.Forms.TextBox();
            this.btnGuardarEqui = new System.Windows.Forms.Button();
            this.btnListadoEqui = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbInformacion.Location = new System.Drawing.Point(282, 42);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(324, 26);
            this.lbInformacion.TabIndex = 0;
            this.lbInformacion.Text = "Información Equipo de Futbol";
            this.lbInformacion.Click += new System.EventHandler(this.lbInformacion_Click);
            // 
            // lblCodigoEqui
            // 
            this.lblCodigoEqui.AutoSize = true;
            this.lblCodigoEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEqui.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCodigoEqui.Location = new System.Drawing.Point(142, 106);
            this.lblCodigoEqui.Name = "lblCodigoEqui";
            this.lblCodigoEqui.Size = new System.Drawing.Size(147, 22);
            this.lblCodigoEqui.TabIndex = 1;
            this.lblCodigoEqui.Text = "Código Equipo:";
            // 
            // lblNombreEqui
            // 
            this.lblNombreEqui.AutoSize = true;
            this.lblNombreEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEqui.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNombreEqui.Location = new System.Drawing.Point(142, 146);
            this.lblNombreEqui.Name = "lblNombreEqui";
            this.lblNombreEqui.Size = new System.Drawing.Size(159, 22);
            this.lblNombreEqui.TabIndex = 2;
            this.lblNombreEqui.Text = "Nombre Equipo: ";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPais.Location = new System.Drawing.Point(142, 192);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(55, 22);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "País:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCategoria.Location = new System.Drawing.Point(142, 230);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(103, 22);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblAnioFundacion
            // 
            this.lblAnioFundacion.AutoSize = true;
            this.lblAnioFundacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFundacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAnioFundacion.Location = new System.Drawing.Point(142, 267);
            this.lblAnioFundacion.Name = "lblAnioFundacion";
            this.lblAnioFundacion.Size = new System.Drawing.Size(150, 22);
            this.lblAnioFundacion.TabIndex = 5;
            this.lblAnioFundacion.Text = "Año fundación: ";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPresupuesto.Location = new System.Drawing.Point(142, 307);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(128, 22);
            this.lblPresupuesto.TabIndex = 6;
            this.lblPresupuesto.Text = "Presupuesto:";
            // 
            // txtCodigoEqui
            // 
            this.txtCodigoEqui.Location = new System.Drawing.Point(302, 100);
            this.txtCodigoEqui.Name = "txtCodigoEqui";
            this.txtCodigoEqui.Size = new System.Drawing.Size(333, 26);
            this.txtCodigoEqui.TabIndex = 7;
            // 
            // txtNombreEqui
            // 
            this.txtNombreEqui.Location = new System.Drawing.Point(302, 146);
            this.txtNombreEqui.Name = "txtNombreEqui";
            this.txtNombreEqui.Size = new System.Drawing.Size(333, 26);
            this.txtNombreEqui.TabIndex = 8;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(302, 192);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(333, 26);
            this.txtPais.TabIndex = 9;
            // 
            // txtAnioFundacion
            // 
            this.txtAnioFundacion.Location = new System.Drawing.Point(302, 267);
            this.txtAnioFundacion.Name = "txtAnioFundacion";
            this.txtAnioFundacion.Size = new System.Drawing.Size(333, 26);
            this.txtAnioFundacion.TabIndex = 11;
            // 
            // btnGuardarEqui
            // 
            this.btnGuardarEqui.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEqui.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarEqui.Location = new System.Drawing.Point(294, 396);
            this.btnGuardarEqui.Name = "btnGuardarEqui";
            this.btnGuardarEqui.Size = new System.Drawing.Size(152, 49);
            this.btnGuardarEqui.TabIndex = 13;
            this.btnGuardarEqui.Text = "Guardar";
            this.btnGuardarEqui.UseVisualStyleBackColor = false;
            this.btnGuardarEqui.Click += new System.EventHandler(this.btnGuardarEqui_Click);
            // 
            // btnListadoEqui
            // 
            this.btnListadoEqui.BackColor = System.Drawing.Color.LimeGreen;
            this.btnListadoEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoEqui.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnListadoEqui.Location = new System.Drawing.Point(483, 396);
            this.btnListadoEqui.Name = "btnListadoEqui";
            this.btnListadoEqui.Size = new System.Drawing.Size(152, 49);
            this.btnListadoEqui.TabIndex = 14;
            this.btnListadoEqui.Text = "Ver Listado";
            this.btnListadoEqui.UseVisualStyleBackColor = false;
            this.btnListadoEqui.Click += new System.EventHandler(this.btnListadoEqui_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxCategoria.Location = new System.Drawing.Point(302, 227);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(333, 28);
            this.cbxCategoria.TabIndex = 15;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(302, 307);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(333, 26);
            this.txtPresupuesto.TabIndex = 16;
            // 
            // FormEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnListadoEqui);
            this.Controls.Add(this.btnGuardarEqui);
            this.Controls.Add(this.txtAnioFundacion);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombreEqui);
            this.Controls.Add(this.txtCodigoEqui);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.lblAnioFundacion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblNombreEqui);
            this.Controls.Add(this.lblCodigoEqui);
            this.Controls.Add(this.lbInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEquipos";
            this.Text = "Formulario Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInformacion;
        private System.Windows.Forms.Label lblCodigoEqui;
        private System.Windows.Forms.Label lblNombreEqui;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAnioFundacion;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtCodigoEqui;
        private System.Windows.Forms.TextBox txtNombreEqui;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtAnioFundacion;
        private System.Windows.Forms.Button btnGuardarEqui;
        private System.Windows.Forms.Button btnListadoEqui;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtPresupuesto;
    }
}

namespace appEquiposfutbol
{
    partial class FormFutbolistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFutbolistas));
            this.lbInformacion = new System.Windows.Forms.Label();
            this.cbxPosicion = new System.Windows.Forms.ComboBox();
            this.txtGolesAnotados = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEquipoFut = new System.Windows.Forms.TextBox();
            this.txtNombreFut = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblGolesAnotados = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEquipoFut = new System.Windows.Forms.Label();
            this.lblNombreFut = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblLesiones = new System.Windows.Forms.Label();
            this.btnListadoFut = new System.Windows.Forms.Button();
            this.btnGuardarFut = new System.Windows.Forms.Button();
            this.cbxLesiones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbInformacion.Location = new System.Drawing.Point(261, 28);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(248, 26);
            this.lbInformacion.TabIndex = 1;
            this.lbInformacion.Text = "Información Futbolista";
            this.lbInformacion.Click += new System.EventHandler(this.lbInformacion_Click);
            // 
            // cbxPosicion
            // 
            this.cbxPosicion.FormattingEnabled = true;
            this.cbxPosicion.Items.AddRange(new object[] {
            "Arquero",
            "Medio",
            "Defensa",
            "Delantero"});
            this.cbxPosicion.Location = new System.Drawing.Point(397, 335);
            this.cbxPosicion.Name = "cbxPosicion";
            this.cbxPosicion.Size = new System.Drawing.Size(321, 28);
            this.cbxPosicion.TabIndex = 24;
            // 
            // txtGolesAnotados
            // 
            this.txtGolesAnotados.Location = new System.Drawing.Point(397, 251);
            this.txtGolesAnotados.Name = "txtGolesAnotados";
            this.txtGolesAnotados.Size = new System.Drawing.Size(321, 26);
            this.txtGolesAnotados.TabIndex = 23;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(397, 210);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(321, 26);
            this.txtEdad.TabIndex = 22;
            // 
            // txtEquipoFut
            // 
            this.txtEquipoFut.Location = new System.Drawing.Point(397, 172);
            this.txtEquipoFut.Name = "txtEquipoFut";
            this.txtEquipoFut.Size = new System.Drawing.Size(321, 26);
            this.txtEquipoFut.TabIndex = 21;
            // 
            // txtNombreFut
            // 
            this.txtNombreFut.Location = new System.Drawing.Point(397, 126);
            this.txtNombreFut.Name = "txtNombreFut";
            this.txtNombreFut.Size = new System.Drawing.Size(321, 26);
            this.txtNombreFut.TabIndex = 20;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(397, 80);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(321, 26);
            this.txtIdentificacion.TabIndex = 19;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNacionalidad.Location = new System.Drawing.Point(108, 293);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(132, 22);
            this.lblNacionalidad.TabIndex = 18;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblGolesAnotados
            // 
            this.lblGolesAnotados.AutoSize = true;
            this.lblGolesAnotados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolesAnotados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGolesAnotados.Location = new System.Drawing.Point(108, 252);
            this.lblGolesAnotados.Name = "lblGolesAnotados";
            this.lblGolesAnotados.Size = new System.Drawing.Size(264, 22);
            this.lblGolesAnotados.TabIndex = 17;
            this.lblGolesAnotados.Text = "Goles Anotados temporada: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEdad.Location = new System.Drawing.Point(108, 210);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(62, 22);
            this.lblEdad.TabIndex = 16;
            this.lblEdad.Text = "Edad:";
            // 
            // lblEquipoFut
            // 
            this.lblEquipoFut.AutoSize = true;
            this.lblEquipoFut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoFut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEquipoFut.Location = new System.Drawing.Point(108, 172);
            this.lblEquipoFut.Name = "lblEquipoFut";
            this.lblEquipoFut.Size = new System.Drawing.Size(168, 22);
            this.lblEquipoFut.TabIndex = 15;
            this.lblEquipoFut.Text = "Equipo de Futbol:";
            // 
            // lblNombreFut
            // 
            this.lblNombreFut.AutoSize = true;
            this.lblNombreFut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNombreFut.Location = new System.Drawing.Point(108, 126);
            this.lblNombreFut.Name = "lblNombreFut";
            this.lblNombreFut.Size = new System.Drawing.Size(91, 22);
            this.lblNombreFut.TabIndex = 14;
            this.lblNombreFut.Text = "Nombre: ";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIdentificacion.Location = new System.Drawing.Point(108, 86);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(134, 22);
            this.lblIdentificacion.TabIndex = 13;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(397, 287);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(321, 26);
            this.txtNacionalidad.TabIndex = 25;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPosicion.Location = new System.Drawing.Point(108, 338);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(92, 22);
            this.lblPosicion.TabIndex = 26;
            this.lblPosicion.Text = "Posición:";
            // 
            // lblLesiones
            // 
            this.lblLesiones.AutoSize = true;
            this.lblLesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesiones.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLesiones.Location = new System.Drawing.Point(104, 372);
            this.lblLesiones.Name = "lblLesiones";
            this.lblLesiones.Size = new System.Drawing.Size(268, 22);
            this.lblLesiones.TabIndex = 27;
            this.lblLesiones.Text = "¿Lesiones en la temporada? ";
            // 
            // btnListadoFut
            // 
            this.btnListadoFut.BackColor = System.Drawing.Color.LimeGreen;
            this.btnListadoFut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoFut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnListadoFut.Location = new System.Drawing.Point(434, 478);
            this.btnListadoFut.Name = "btnListadoFut";
            this.btnListadoFut.Size = new System.Drawing.Size(148, 46);
            this.btnListadoFut.TabIndex = 31;
            this.btnListadoFut.Text = "Ver Listado";
            this.btnListadoFut.UseVisualStyleBackColor = false;
            this.btnListadoFut.Click += new System.EventHandler(this.btnListadoFut_Click);
            // 
            // btnGuardarFut
            // 
            this.btnGuardarFut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarFut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarFut.Location = new System.Drawing.Point(245, 478);
            this.btnGuardarFut.Name = "btnGuardarFut";
            this.btnGuardarFut.Size = new System.Drawing.Size(148, 46);
            this.btnGuardarFut.TabIndex = 30;
            this.btnGuardarFut.Text = "Guardar";
            this.btnGuardarFut.UseVisualStyleBackColor = false;
            this.btnGuardarFut.Click += new System.EventHandler(this.btnGuardarFut_Click);
            // 
            // cbxLesiones
            // 
            this.cbxLesiones.FormattingEnabled = true;
            this.cbxLesiones.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxLesiones.Location = new System.Drawing.Point(397, 372);
            this.cbxLesiones.Name = "cbxLesiones";
            this.cbxLesiones.Size = new System.Drawing.Size(321, 28);
            this.cbxLesiones.TabIndex = 32;
            // 
            // FormFutbolistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.cbxLesiones);
            this.Controls.Add(this.btnListadoFut);
            this.Controls.Add(this.btnGuardarFut);
            this.Controls.Add(this.lblLesiones);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.cbxPosicion);
            this.Controls.Add(this.txtGolesAnotados);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtEquipoFut);
            this.Controls.Add(this.txtNombreFut);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblGolesAnotados);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEquipoFut);
            this.Controls.Add(this.lblNombreFut);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lbInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFutbolistas";
            this.Text = "Formulario Futbolista";
            this.Load += new System.EventHandler(this.FormFutbolistas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInformacion;
        private System.Windows.Forms.ComboBox cbxPosicion;
        private System.Windows.Forms.TextBox txtGolesAnotados;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtEquipoFut;
        private System.Windows.Forms.TextBox txtNombreFut;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblGolesAnotados;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEquipoFut;
        private System.Windows.Forms.Label lblNombreFut;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblLesiones;
        private System.Windows.Forms.Button btnListadoFut;
        private System.Windows.Forms.Button btnGuardarFut;
        private System.Windows.Forms.ComboBox cbxLesiones;
    }
}

namespace appEquiposfutbol
{
    partial class FormListadoEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListadoEquipos));
            this.dtgvConsulta2 = new System.Windows.Forms.DataGridView();
            this.lblconsulta1 = new System.Windows.Forms.Label();
            this.dtgvConsulta3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvConsulta2
            // 
            this.dtgvConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsulta2.Location = new System.Drawing.Point(98, 79);
            this.dtgvConsulta2.Name = "dtgvConsulta2";
            this.dtgvConsulta2.RowHeadersWidth = 62;
            this.dtgvConsulta2.RowTemplate.Height = 28;
            this.dtgvConsulta2.Size = new System.Drawing.Size(712, 186);
            this.dtgvConsulta2.TabIndex = 0;
            // 
            // lblconsulta1
            // 
            this.lblconsulta1.AutoSize = true;
            this.lblconsulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblconsulta1.Location = new System.Drawing.Point(98, 42);
            this.lblconsulta1.Name = "lblconsulta1";
            this.lblconsulta1.Size = new System.Drawing.Size(495, 25);
            this.lblconsulta1.TabIndex = 1;
            this.lblconsulta1.Text = "Listado de los equipos entre los años 1900 y 1950";
            // 
            // dtgvConsulta3
            // 
            this.dtgvConsulta3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsulta3.Location = new System.Drawing.Point(98, 326);
            this.dtgvConsulta3.Name = "dtgvConsulta3";
            this.dtgvConsulta3.RowHeadersWidth = 62;
            this.dtgvConsulta3.RowTemplate.Height = 28;
            this.dtgvConsulta3.Size = new System.Drawing.Size(712, 186);
            this.dtgvConsulta3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(98, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de los jugadores con más de 10 goles en equipos de categoría A";
            // 
            // FormListadoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(909, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvConsulta3);
            this.Controls.Add(this.lblconsulta1);
            this.Controls.Add(this.dtgvConsulta2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListadoEquipos";
            this.Text = "FormListadoEquipos";
            this.Load += new System.EventHandler(this.FormListadoEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvConsulta2;
        private System.Windows.Forms.Label lblconsulta1;
        private System.Windows.Forms.DataGridView dtgvConsulta3;
        private System.Windows.Forms.Label label1;
    }
}
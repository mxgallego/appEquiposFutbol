
namespace appEquiposfutbol
{
    partial class FormListadoFutbolistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListadoFutbolistas));
            this.lblconsulta1 = new System.Windows.Forms.Label();
            this.dtgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.dtgvConsulta4 = new System.Windows.Forms.DataGridView();
            this.lblConsulta3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconsulta1
            // 
            this.lblconsulta1.AutoSize = true;
            this.lblconsulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblconsulta1.Location = new System.Drawing.Point(64, 48);
            this.lblconsulta1.Name = "lblconsulta1";
            this.lblconsulta1.Size = new System.Drawing.Size(785, 25);
            this.lblconsulta1.TabIndex = 3;
            this.lblconsulta1.Text = "Listado de número de veces que se repite la letra “a” en el nombre del futbolista" +
    " ";
            // 
            // dtgvConsulta1
            // 
            this.dtgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsulta1.Location = new System.Drawing.Point(59, 89);
            this.dtgvConsulta1.Name = "dtgvConsulta1";
            this.dtgvConsulta1.RowHeadersWidth = 62;
            this.dtgvConsulta1.RowTemplate.Height = 28;
            this.dtgvConsulta1.Size = new System.Drawing.Size(735, 186);
            this.dtgvConsulta1.TabIndex = 2;
            // 
            // dtgvConsulta4
            // 
            this.dtgvConsulta4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsulta4.Location = new System.Drawing.Point(59, 340);
            this.dtgvConsulta4.Name = "dtgvConsulta4";
            this.dtgvConsulta4.RowHeadersWidth = 62;
            this.dtgvConsulta4.RowTemplate.Height = 28;
            this.dtgvConsulta4.Size = new System.Drawing.Size(735, 166);
            this.dtgvConsulta4.TabIndex = 4;
            // 
            // lblConsulta3
            // 
            this.lblConsulta3.AutoSize = true;
            this.lblConsulta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblConsulta3.Location = new System.Drawing.Point(64, 305);
            this.lblConsulta3.Name = "lblConsulta3";
            this.lblConsulta3.Size = new System.Drawing.Size(730, 25);
            this.lblConsulta3.TabIndex = 5;
            this.lblConsulta3.Text = "Listado de Arqueros lesionados pertenecientes a un equipo de categoría C";
            // 
            // FormListadoFutbolistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(912, 547);
            this.Controls.Add(this.lblConsulta3);
            this.Controls.Add(this.dtgvConsulta4);
            this.Controls.Add(this.lblconsulta1);
            this.Controls.Add(this.dtgvConsulta1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListadoFutbolistas";
            this.Text = "FormListadoFutbolistas";
            this.Load += new System.EventHandler(this.FormListadoFutbolistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconsulta1;
        private System.Windows.Forms.DataGridView dtgvConsulta1;
        private System.Windows.Forms.DataGridView dtgvConsulta4;
        private System.Windows.Forms.Label lblConsulta3;
    }
}
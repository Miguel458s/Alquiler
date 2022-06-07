namespace Alquilar
{
    partial class ConsultarVehiculosAlquilados
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
            this.dataGridConsultar = new System.Windows.Forms.DataGridView();
            this.btn_CargarTabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultar
            // 
            this.dataGridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultar.Location = new System.Drawing.Point(-1, 0);
            this.dataGridConsultar.Name = "dataGridConsultar";
            this.dataGridConsultar.Size = new System.Drawing.Size(670, 327);
            this.dataGridConsultar.TabIndex = 0;
            // 
            // btn_CargarTabla
            // 
            this.btn_CargarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarTabla.Location = new System.Drawing.Point(243, 333);
            this.btn_CargarTabla.Name = "btn_CargarTabla";
            this.btn_CargarTabla.Size = new System.Drawing.Size(159, 43);
            this.btn_CargarTabla.TabIndex = 14;
            this.btn_CargarTabla.Text = "CargarTabla";
            this.btn_CargarTabla.UseVisualStyleBackColor = true;
            this.btn_CargarTabla.Click += new System.EventHandler(this.btn_CargarTabla_Click);
            // 
            // ConsultarVehiculosAlquilados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 388);
            this.Controls.Add(this.btn_CargarTabla);
            this.Controls.Add(this.dataGridConsultar);
            this.Name = "ConsultarVehiculosAlquilados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarVehiculosAlquilados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultar;
        private System.Windows.Forms.Button btn_CargarTabla;
    }
}
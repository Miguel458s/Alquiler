namespace Alquilar
{
    partial class ConsultarVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVehiculos));
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btns_PlacaBuscar = new System.Windows.Forms.Label();
            this.txtValorKM = new System.Windows.Forms.TextBox();
            this.dataGridMostrar = new System.Windows.Forms.DataGridView();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(431, 361);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(120, 23);
            this.Btn_Volver.TabIndex = 42;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(293, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Datos de los Vehiculos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha: ";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Buscar.Location = new System.Drawing.Point(431, 261);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(134, 24);
            this.Btn_Buscar.TabIndex = 38;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Btns_PlacaBuscar
            // 
            this.Btns_PlacaBuscar.AutoSize = true;
            this.Btns_PlacaBuscar.Location = new System.Drawing.Point(12, 74);
            this.Btns_PlacaBuscar.Name = "Btns_PlacaBuscar";
            this.Btns_PlacaBuscar.Size = new System.Drawing.Size(40, 13);
            this.Btns_PlacaBuscar.TabIndex = 36;
            this.Btns_PlacaBuscar.Text = "Placa: ";
            // 
            // txtValorKM
            // 
            this.txtValorKM.Location = new System.Drawing.Point(72, 71);
            this.txtValorKM.Name = "txtValorKM";
            this.txtValorKM.Size = new System.Drawing.Size(149, 20);
            this.txtValorKM.TabIndex = 35;
            // 
            // dataGridMostrar
            // 
            this.dataGridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMostrar.Location = new System.Drawing.Point(72, 168);
            this.dataGridMostrar.Name = "dataGridMostrar";
            this.dataGridMostrar.Size = new System.Drawing.Size(353, 229);
            this.dataGridMostrar.TabIndex = 33;
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(384, 71);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(149, 20);
            this.FechaTxt.TabIndex = 43;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Consultar.Location = new System.Drawing.Point(431, 168);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(134, 24);
            this.Btn_Consultar.TabIndex = 44;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // ConsultarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.FechaTxt);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btns_PlacaBuscar);
            this.Controls.Add(this.txtValorKM);
            this.Controls.Add(this.dataGridMostrar);
            this.Name = "ConsultarVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Btns_PlacaBuscar;
        private System.Windows.Forms.TextBox txtValorKM;
        private System.Windows.Forms.DataGridView dataGridMostrar;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.Button Btn_Consultar;
    }
}
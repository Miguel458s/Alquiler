namespace Alquilar
{
    partial class ConsultarPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPersonas));
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btns_IdClienteBuscar = new System.Windows.Forms.Label();
            this.txtValorKM = new System.Windows.Forms.TextBox();
            this.dataGridMostrar2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Consultar.Location = new System.Drawing.Point(468, 185);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(134, 24);
            this.Btn_Consultar.TabIndex = 53;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(468, 391);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(120, 23);
            this.Btn_Volver.TabIndex = 51;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Datos de los Clientes";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Buscar.Location = new System.Drawing.Point(468, 278);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(134, 24);
            this.Btn_Buscar.TabIndex = 48;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Btns_IdClienteBuscar
            // 
            this.Btns_IdClienteBuscar.AutoSize = true;
            this.Btns_IdClienteBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btns_IdClienteBuscar.Location = new System.Drawing.Point(49, 91);
            this.Btns_IdClienteBuscar.Name = "Btns_IdClienteBuscar";
            this.Btns_IdClienteBuscar.Size = new System.Drawing.Size(54, 13);
            this.Btns_IdClienteBuscar.TabIndex = 47;
            this.Btns_IdClienteBuscar.Text = "IdCliente: ";
            // 
            // txtValorKM
            // 
            this.txtValorKM.Location = new System.Drawing.Point(109, 88);
            this.txtValorKM.Name = "txtValorKM";
            this.txtValorKM.Size = new System.Drawing.Size(149, 20);
            this.txtValorKM.TabIndex = 46;
            // 
            // dataGridMostrar2
            // 
            this.dataGridMostrar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMostrar2.Location = new System.Drawing.Point(109, 185);
            this.dataGridMostrar2.Name = "dataGridMostrar2";
            this.dataGridMostrar2.Size = new System.Drawing.Size(353, 229);
            this.dataGridMostrar2.TabIndex = 45;
            // 
            // ConsultarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btns_IdClienteBuscar);
            this.Controls.Add(this.txtValorKM);
            this.Controls.Add(this.dataGridMostrar2);
            this.Name = "ConsultarPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Btns_IdClienteBuscar;
        private System.Windows.Forms.TextBox txtValorKM;
        private System.Windows.Forms.DataGridView dataGridMostrar2;
    }
}
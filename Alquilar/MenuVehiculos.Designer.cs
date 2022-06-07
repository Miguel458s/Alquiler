namespace Alquilar
{
    partial class MenuVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVehiculos));
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.BtnEliminar_Vehi = new System.Windows.Forms.Button();
            this.Btnconsultar_Vehi = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(456, 399);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(138, 44);
            this.Btn_Volver.TabIndex = 8;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // BtnEliminar_Vehi
            // 
            this.BtnEliminar_Vehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar_Vehi.Location = new System.Drawing.Point(12, 315);
            this.BtnEliminar_Vehi.Name = "BtnEliminar_Vehi";
            this.BtnEliminar_Vehi.Size = new System.Drawing.Size(171, 54);
            this.BtnEliminar_Vehi.TabIndex = 7;
            this.BtnEliminar_Vehi.Text = "Eliminar";
            this.BtnEliminar_Vehi.UseVisualStyleBackColor = true;
            this.BtnEliminar_Vehi.Click += new System.EventHandler(this.BtnEliminar_Vehi_Click);
            // 
            // Btnconsultar_Vehi
            // 
            this.Btnconsultar_Vehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnconsultar_Vehi.Location = new System.Drawing.Point(12, 190);
            this.Btnconsultar_Vehi.Name = "Btnconsultar_Vehi";
            this.Btnconsultar_Vehi.Size = new System.Drawing.Size(171, 52);
            this.Btnconsultar_Vehi.TabIndex = 6;
            this.Btnconsultar_Vehi.Text = "Consultar";
            this.Btnconsultar_Vehi.UseVisualStyleBackColor = true;
            this.Btnconsultar_Vehi.Click += new System.EventHandler(this.Btnconsultar_Vehi_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(12, 63);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(171, 57);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar Vehiculo";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.Btn_Volver);
            this.groupBox1.Location = new System.Drawing.Point(199, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 449);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MenuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEliminar_Vehi);
            this.Controls.Add(this.Btnconsultar_Vehi);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "MenuVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVehiculos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button BtnEliminar_Vehi;
        private System.Windows.Forms.Button Btnconsultar_Vehi;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
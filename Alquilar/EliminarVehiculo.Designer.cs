namespace Alquilar
{
    partial class EliminarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarVehiculo));
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KmTxt = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.PlacaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MarcaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(174, 316);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(138, 24);
            this.Btn_Volver.TabIndex = 21;
            this.Btn_Volver.Text = "Cancelar";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Eliminar Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kilometraje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Placa:";
            // 
            // KmTxt
            // 
            this.KmTxt.Location = new System.Drawing.Point(346, 218);
            this.KmTxt.Name = "KmTxt";
            this.KmTxt.Size = new System.Drawing.Size(124, 20);
            this.KmTxt.TabIndex = 17;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.Location = new System.Drawing.Point(441, 317);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(159, 23);
            this.btn_Confirmar.TabIndex = 23;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Consig_Click);
            // 
            // PlacaTxt
            // 
            this.PlacaTxt.Location = new System.Drawing.Point(346, 123);
            this.PlacaTxt.Name = "PlacaTxt";
            this.PlacaTxt.Size = new System.Drawing.Size(124, 20);
            this.PlacaTxt.TabIndex = 24;
            this.PlacaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlacaTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Marca:";
            // 
            // MarcaTxt
            // 
            this.MarcaTxt.Location = new System.Drawing.Point(346, 182);
            this.MarcaTxt.Name = "MarcaTxt";
            this.MarcaTxt.Size = new System.Drawing.Size(124, 20);
            this.MarcaTxt.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Presionar Enter para cargar datos del Vehiculo";
            // 
            // EliminarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MarcaTxt);
            this.Controls.Add(this.PlacaTxt);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KmTxt);
            this.Name = "EliminarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarVehiculo";
            this.Load += new System.EventHandler(this.EliminarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KmTxt;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox PlacaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MarcaTxt;
        private System.Windows.Forms.Label label9;
    }
}
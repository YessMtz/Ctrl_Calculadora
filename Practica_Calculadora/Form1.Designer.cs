
namespace Practica_Calculadora
{
    partial class Form1
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
            this.plantillaCalculadora1 = new Practica_Calculadora.PlantillaCalculadora();
            this.SuspendLayout();
            // 
            // plantillaCalculadora1
            // 
            this.plantillaCalculadora1.BackColor = System.Drawing.Color.Black;
            this.plantillaCalculadora1.Location = new System.Drawing.Point(58, 22);
            this.plantillaCalculadora1.Name = "plantillaCalculadora1";
            this.plantillaCalculadora1.Size = new System.Drawing.Size(371, 503);
            this.plantillaCalculadora1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 622);
            this.Controls.Add(this.plantillaCalculadora1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PlantillaCalculadora plantillaCalculadora1;
    }
}


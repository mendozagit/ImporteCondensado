﻿
namespace ImporteCondensado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nnumero = new System.Windows.Forms.NumericUpDown();
            this.Nfactor = new System.Windows.Forms.NumericUpDown();
            this.Nresultado = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nnumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nfactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // Nnumero
            // 
            this.Nnumero.DecimalPlaces = 2;
            this.Nnumero.Location = new System.Drawing.Point(27, 80);
            this.Nnumero.Maximum = new decimal(new int[] {
            999000000,
            0,
            0,
            0});
            this.Nnumero.Name = "Nnumero";
            this.Nnumero.Size = new System.Drawing.Size(120, 20);
            this.Nnumero.TabIndex = 0;
            this.Nnumero.Value = new decimal(new int[] {
            562050,
            0,
            0,
            131072});
            // 
            // Nfactor
            // 
            this.Nfactor.Location = new System.Drawing.Point(153, 80);
            this.Nfactor.Maximum = new decimal(new int[] {
            999000000,
            0,
            0,
            0});
            this.Nfactor.Name = "Nfactor";
            this.Nfactor.Size = new System.Drawing.Size(120, 20);
            this.Nfactor.TabIndex = 1;
            this.Nfactor.Value = new decimal(new int[] {
            731,
            0,
            0,
            0});
            // 
            // Nresultado
            // 
            this.Nresultado.Location = new System.Drawing.Point(279, 80);
            this.Nresultado.Name = "Nresultado";
            this.Nresultado.Size = new System.Drawing.Size(120, 20);
            this.Nresultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FACTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RESULTADO";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(153, 131);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(120, 56);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 210);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nresultado);
            this.Controls.Add(this.Nfactor);
            this.Controls.Add(this.Nnumero);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Nnumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nfactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nresultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Nnumero;
        private System.Windows.Forms.NumericUpDown Nfactor;
        private System.Windows.Forms.NumericUpDown Nresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalcular;
    }
}


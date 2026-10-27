/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 27/10/2026
 * Hora: 07:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Calcu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMul = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnMod = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(43, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Número 1:";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(210, 38);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 22);
			this.txt1.TabIndex = 1;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(210, 99);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 22);
			this.txt2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(43, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Número 2:";
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(68, 164);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(100, 66);
			this.btnSuma.TabIndex = 4;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(198, 164);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(100, 66);
			this.btnResta.TabIndex = 5;
			this.btnResta.Text = "-";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMul
			// 
			this.btnMul.Location = new System.Drawing.Point(12, 249);
			this.btnMul.Name = "btnMul";
			this.btnMul.Size = new System.Drawing.Size(100, 66);
			this.btnMul.TabIndex = 6;
			this.btnMul.Text = "x";
			this.btnMul.UseVisualStyleBackColor = true;
			this.btnMul.Click += new System.EventHandler(this.BtnMulClick);
			// 
			// btnDiv
			// 
			this.btnDiv.Location = new System.Drawing.Point(134, 249);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(100, 66);
			this.btnDiv.TabIndex = 7;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.BtnDivClick);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(33, 336);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(294, 86);
			this.lblRespuesta.TabIndex = 8;
			// 
			// btnMod
			// 
			this.btnMod.Location = new System.Drawing.Point(249, 249);
			this.btnMod.Name = "btnMod";
			this.btnMod.Size = new System.Drawing.Size(100, 66);
			this.btnMod.TabIndex = 9;
			this.btnMod.Text = "%";
			this.btnMod.UseVisualStyleBackColor = true;
			this.btnMod.Click += new System.EventHandler(this.BtnModClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 469);
			this.Controls.Add(this.btnMod);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnMul);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calcu";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnMod;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnMul;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label1;
	}
}

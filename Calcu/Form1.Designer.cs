/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 27/10/2026
 * Hora: 07:36 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Calcu
{
	partial class Form1
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblX1 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblX2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(35, 301);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(103, 74);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "A";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(214, 58);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 22);
			this.txtA.TabIndex = 2;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(214, 100);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 22);
			this.txtB.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "B";
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(214, 145);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 22);
			this.txtC.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(38, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "C";
			// 
			// lblX1
			// 
			this.lblX1.Location = new System.Drawing.Point(142, 201);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(172, 32);
			this.lblX1.TabIndex = 7;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(188, 301);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(103, 74);
			this.btnRegresar.TabIndex = 8;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblX2
			// 
			this.lblX2.Location = new System.Drawing.Point(144, 255);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(172, 32);
			this.lblX2.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(38, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "X1";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(35, 255);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 22);
			this.label5.TabIndex = 11;
			this.label5.Text = "X2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 387);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
	}
}

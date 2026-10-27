/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 27/10/2026
 * Hora: 07:36 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calcu
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a, b, c, d, x1, x2;
			a = Convert.ToDouble(txtA.Text);
			b = Convert.ToDouble(txtB.Text);
			c = Convert.ToDouble(txtC.Text);
			if (a != 0)
			{
			    d = b * b - 4 * a * c;
			    if (d >= 0)
			    {
			        x1 = (-b + Math.Sqrt(d)) / (2 * a);
			        x2 = (-b - Math.Sqrt(d)) / (2 * a);
			
			        lblX1.Text = "X1: " + x1.ToString();
			        lblX2.Text = "X2: " + x2.ToString();
			    }
			    else
			    {
			        lblX1.Text = "No hay soluciones reales";
			        lblX2.Text = "";
			    }
			}
			else
			{
			    lblX1.Text = "A no puede ser cero";
			    lblX2.Text = "";
			}
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

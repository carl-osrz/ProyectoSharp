/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 27/10/2026
 * Hora: 07:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calcu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnMulClick(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txt1.Text);
			num2 = Convert.ToDouble(txt2.Text);
			resultado = num1 * num2;
			lblRespuesta.Text = resultado.ToString();
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txt1.Text);
			num2 = Convert.ToDouble(txt2.Text);
			resultado = num1 + num2;
			lblRespuesta.Text = resultado.ToString();
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txt1.Text);
			num2 = Convert.ToDouble(txt2.Text);
			resultado = num1 - num2;
			lblRespuesta.Text = resultado.ToString();
		}
		
		void BtnDivClick(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txt1.Text);
			num2 = Convert.ToDouble(txt2.Text);
			resultado = num1 / num2;
			lblRespuesta.Text = resultado.ToString();
		}
		
		void BtnModClick(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txt1.Text);
			num2 = Convert.ToDouble(txt2.Text);
			resultado = num1 % num2;
			lblRespuesta.Text = resultado.ToString();
		}
	}
}

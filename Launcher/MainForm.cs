/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 24/10/2012
 * Hora: 03:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace launcher
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
		
		void BtncancelClick(object sender, EventArgs e){
			this.Close();
		}			
		
		void BtnejecClick(object sender, EventArgs e){
			string program= textrun.Text;
			if ( System.IO.File.Exists( program ) == true ){
				Process p = new Process();
				p.StartInfo.FileName = program;
				p.Start();
			}else{
				MessageBox.Show("No se puede lanzar el archivo, ¿existe?","Error");
			}
		}//btn
	}
}

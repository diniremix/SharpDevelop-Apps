/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 18/10/2012
 * Hora: 03:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace notesharp
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
		
		void AcercadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Editor de notas sencillo en C#");
		}
		
		void AbrirToolStripMenuItemClick(object sender, EventArgs e){
			//filtro
			//Archivos de texto(*.txt)|*.txt|Todos los archivos(*.*)|*.*
			
			if(openFile.ShowDialog() == DialogResult.OK){
				System.IO.StreamReader fichero = new System.IO.StreamReader(openFile.FileName);
				this.richTextBox1.Text=fichero.ReadToEnd();				
				fichero.Close();
				toolStripStatusLabel1.Text=openFile.FileName;
			}
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e){
			this.Close();
		}
		
		void GuardarToolStripMenuItemClick(object sender, EventArgs e){
			//filtro
			//Archivos de texto(*.txt)|*.txt|Todos los archivos(*.*)|*.*
			
			if(saveFile.ShowDialog() == DialogResult.OK){
				System.IO.StreamWriter fichero = new System.IO.StreamWriter(saveFile.FileName);
				fichero.Write(this.richTextBox1.Text.TrimEnd());
				fichero.Close();
				toolStripStatusLabel1.Text=saveFile.FileName;
			}
		}
		
		void NuevoToolStripMenuItemClick(object sender, EventArgs e){
			richTextBox1.Clear();
			toolStripStatusLabel1.Text="Notesharp V.0.2";
		}
	}
}

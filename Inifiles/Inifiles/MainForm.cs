/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 12/11/2012
 * Hora: 01:15 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ini;

namespace Inifiles
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form{
		
		IniFile inis;
		string path;
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e){			
			path=textruta.Text;
			textBox3.Text= inis.IniReadValue(textBox1.Text,textBox2.Text);
		}
		
		void Button2Click(object sender, EventArgs e){
			inis.IniWriteValue(textBox1.Text,textBox2.Text,textBox3.Text);
		}
		
		void Button3Click(object sender, EventArgs e){
			if(openfiledlg.ShowDialog() == DialogResult.OK){
				path=openfiledlg.FileName;
				inis = new IniFile(path);
				this.Text="editando "+path;
				textruta.Text=path;
			}
	}
	}
}

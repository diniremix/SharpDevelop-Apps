/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 25/10/2012
 * Hora: 08:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Firewall{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form{
		private string path="C:\\windows\\system32\\drivers\\etc";
		private string program="";
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			program=path+"\\hosts";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e){
			getfileurl();
		}
		
		void BtncloseClick(object sender, EventArgs e){
			saveurl();
			//this.Close();
		}
		
		void BtnaddClick(object sender, EventArgs e){
			if(texturl.Text==""){
				MessageBox.Show("Escriba una direccion","Error");				
			}else{
				listurl.Items.Add(texturl.Text);
				texturl.Clear();
			}
			texturl.Focus();
		}
		
		void getfileurl(){
			if ( System.IO.File.Exists( program ) == true ){
				this.Text="Firewall::edición";
			}
		}
		
		void saveurl(){			
			string myurl;			
			try{
				if ( System.IO.Directory.Exists( path ) == true ){
					System.IO.StreamWriter fichero = new System.IO.StreamWriter(program,false,System.Text.Encoding.Default);
					fichero.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp.");
					fichero.WriteLine("#");
					fichero.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.");
					fichero.WriteLine("#");
					fichero.WriteLine("# For example:");
					fichero.WriteLine("#");
					fichero.WriteLine("#      102.54.94.97     rhino.acme.com          # source server");
					fichero.WriteLine("#       38.25.63.10     x.acme.com              # x client host");
					fichero.WriteLine("#");
					fichero.WriteLine("# localhost name resolution is handled within DNS itself.");
					fichero.WriteLine("#	127.0.0.1       localhost");
					fichero.WriteLine("#	::1             localhost");
					fichero.WriteLine("# Este archivo ha sido modificado por SharpFirewall 0.2\n");
					fichero.WriteLine("127.0.0.1\tlocalhost");
					for (int i = 0; i < listurl.Items.Count; i++){
						myurl = listurl.Items[i].ToString();
						fichero.WriteLine("127.0.0.1\t"+myurl);
					}
					MessageBox.Show("Cambios guardados con exito","Información");
					fichero.Close();
					
				}else{
					MessageBox.Show("No se pudo guardar los cambios","Error");
				}
			}
			catch{
				MessageBox.Show("No se pudo guardar los cambios, Revise si tiene permisos para ejecutar esta aplicacion.","Error");
			}
		}
	}
}

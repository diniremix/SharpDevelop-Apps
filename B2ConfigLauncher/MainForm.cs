/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 18/10/2012
 * Hora: 08:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace B2ConfigLauncher
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
		
		void Button1Click(object sender, EventArgs e){
			String user=this.txtuser.Text;
			String lang=this.cbolang.Text.ToLower();
			if(user==""){
				user="B2_user";
			}
			if(lang==""){
				lang="english";
			}
			
			System.IO.StreamWriter fichero = new System.IO.StreamWriter("3DMGame.ini");
			fichero.Write("[Game]");	
			fichero.Write("\nappid = 49520");	
			fichero.Write("\nlanguage = "+lang);
			fichero.Write("\nlogon = 1");	
			fichero.Write("\n");			
			fichero.Write("\n[Settings]");
			fichero.Write("\nplayername = "+user);
			fichero.Write("\n");	
			fichero.Write("\n# Borderlands 2 Config Launcher");
			fichero.Write("\n# B2ConfigLauncher desarrollado en C#");
			fichero.Write("\n# Desarrolladores");
			fichero.Write("\n# @Diniremix");
			fichero.Write("\n# @ChicoSoftware\n");
			fichero.Close();
			//ejecutar el juego
			if ( System.IO.File.Exists( "Borderlands2.exe" ) == true ){
				Process p = new Process();
				p.StartInfo.FileName = "Borderlands2.exe";
				//p.StartInfo.Arguments = "/c dir *.cs";
				//p.StartInfo.UseShellExecute = false;
				//p.StartInfo.RedirectStandardOutput = true;
				//ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
				p.Start();
			}else{
				MessageBox.Show("No se puede lanzar el ejecutable, ¿este archivo está en el directorio adecuado?","Error");
			}
					
			this.Close();
		}
	}
}

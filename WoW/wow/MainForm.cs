/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 12/11/2012
 * Hora: 12:02 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace wow
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
			Init();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void Init(){
			string  arg_params="";
			String[] parametros=Environment.GetCommandLineArgs();
			for (int i = 0; i < parametros.Length; i++){ 
                    arg_params+=" "+parametros[i];
            }
			this.Text="Lanzando... "+arg_params;
			launch_game(arg_params);
		}
		
		private void launch_game(string parameters){
			if ( System.IO.File.Exists( "wow_launcher.exe" ) == true ){
				Process p = new Process();
				p.StartInfo.FileName = "wow.exe";
				p.StartInfo.Arguments = parameters;
				//p.StartInfo.UseShellExecute = false;
				//p.StartInfo.RedirectStandardOutput = true;
				//ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
				p.Start();
			}else{
				MessageBox.Show("No se puede lanzar el ejecutable con los parametros enviados","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}

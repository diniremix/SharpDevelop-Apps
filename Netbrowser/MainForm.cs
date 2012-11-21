/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 20/10/2012
 * Hora: 10:41 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace netbrowser{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form{
		frmoptions formoption= new frmoptions();
		string homepage="http://www.google.com";
		string enginesearch="https://www.google.com.co/search?q=";
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			buscador.Navigate(homepage);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		
		void OptaboutClick(object sender, EventArgs e){
			MessageBox.Show("NetBrowser C# Internet Browser\n"+
			               "Diniremix 2012","NetBrowser",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void BtnbackClick(object sender, EventArgs e){
			buscador.GoBack();			
		}
		
		void BtnforwardClick(object sender, EventArgs e){
			buscador.GoForward();			
		}
		
		void BtngoClick(object sender, EventArgs e){
			buscador.Navigate(enginesearch+texturl.Text);
			texturl.Clear();
		}
		
		void BtnrefreshClick(object sender, EventArgs e){
			buscador.Refresh();			
		}
		
		void BtnstopClick(object sender, EventArgs e){
			buscador.Stop();			
		}
		
		void OptpagehomeClick(object sender, EventArgs e){
			formoption.ShowDialog();
			homepage=formoption.initpage;
			enginesearch=formoption.engine;
		}
		
		void BuscadorDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e){
			this.Text=buscador.DocumentTitle+" - NetBrowser 0.2";
			lbpagename.Text=buscador.Url.ToString();
		}
		
		void BtnexitClick(object sender, EventArgs e){
			Application.Exit();
		}
		
		void BtnhomeClick(object sender, EventArgs e){
			if(homepage!=""){
				buscador.Navigate(homepage);				
			}else{
				buscador.GoHome();
			}
		}
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 20/10/2012
 * Hora: 11:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace netbrowser{
	/// <summary>
	/// Description of frmoptions.
	/// </summary>
	public partial class frmoptions : Form{
		public string initpage;
		public string engine;
		public frmoptions(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e){
			initpage=texhomepage.Text;			
			switch(cboengine.Text) {
					case "Google":{
						engine="https://www.google.com.co/search?q=";
						break;
					}
					case "Yahoo":{
						engine="http://search.yahoo.com/search?&p=";
						break;
					}
					case "Bing":{
						engine="http://www.bing.com/videos/search?q=";
						break;
					}
					case "Wikipedia":{
						engine="http://es.wikipedia.org/wiki/Especial:Search?search=";
						break;
					}
			}
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e){
			initpage="http://www.google.com";
			engine="https://www.google.com.co/search?q=";
			this.Close();
		}
	}
}

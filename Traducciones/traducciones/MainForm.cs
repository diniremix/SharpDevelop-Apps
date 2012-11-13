/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 09/11/2012
 * Hora: 02:04 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace traducciones
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
				
		private void loadxml(string sRuta){  			
			try{
				XmlDocument xmldoc = new XmlDocument();
				//ruta del xml
				xmldoc.Load(sRuta);
				//otengo el root
				XmlNodeList futbolistas = xmldoc.GetElementsByTagName("idiomas");
				//obtengo el nodo deseado
				XmlNodeList config = ((XmlElement)futbolistas[0]).GetElementsByTagName(cbolang.Text);
				XmlNodeList mnufile = ((XmlElement)config[0]).GetElementsByTagName("mnufile");
				XmlNodeList mnutools = ((XmlElement)config[0]).GetElementsByTagName("mnutools");
				XmlNodeList mnuhelp = ((XmlElement)config[0]).GetElementsByTagName("mnuhelp");
				//se recorre el nodo en busca de los elementos del menu file
				foreach (XmlElement nodo in mnufile){
					XmlNodeList arch = nodo.GetElementsByTagName("file");
					XmlNodeList nuevo = nodo.GetElementsByTagName("nuevo");
					XmlNodeList abrir = nodo.GetElementsByTagName("abrir");
					XmlNodeList cerrar = nodo.GetElementsByTagName("cerrar");
					XmlNodeList salir = nodo.GetElementsByTagName("salir");
					//si hay informacion en los nodos se extrae
					try{
						for (int i = 0; i < arch.Count; i++){
							
							archivoToolStripMenuItem.Text="&"+arch[i].InnerText;
							nuevoToolStripMenuItem.Text="&"+nuevo[i].InnerText;
							abrirToolStripMenuItem.Text="&"+abrir[i].InnerText;
							cerrarToolStripMenuItem.Text="&"+cerrar[i].InnerText;
							salirToolStripMenuItem.Text="&"+salir[i].InnerText;
						}
					}
					catch (NullReferenceException e){
						MessageBox.Show(e.ToString());
					}
				}
				//se recorre el nodo en busca de los elementos del menu tools
				foreach (XmlElement nodo in mnutools){
					XmlNodeList tools = nodo.GetElementsByTagName("tools");
					XmlNodeList options = nodo.GetElementsByTagName("options");
					//si hay informacion en los nodos se extrae
					try{
						for (int i = 0; i < tools.Count; i++){
							
							herramientasToolStripMenuItem.Text="&"+tools[i].InnerText;
							opcionesToolStripMenuItem.Text="&"+options[i].InnerText;
						}
					}
					catch (NullReferenceException e){
						MessageBox.Show(e.ToString());
					}
				}
				//se recorre el nodo en busca de los elementos del menu help
				foreach (XmlElement nodo in mnuhelp){
					XmlNodeList help = nodo.GetElementsByTagName("help");
					XmlNodeList about = nodo.GetElementsByTagName("about");
					//si hay informacion en los nodos se extrae
					try{
						for (int i = 0; i < help.Count; i++){
							
							ayudaToolStripMenuItem.Text="&"+help[i].InnerText;
							acercadeToolStripMenuItem.Text="&"+about[i].InnerText;
						}
					}
					catch (NullReferenceException e){
						MessageBox.Show(e.ToString());
					}
				}
				//fin
			}
			catch (FileNotFoundException){
				MessageBox.Show("No se encontro el archivo de configuracion de traducciones","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}		
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e){
			this.Close();
		}
		
		void AcercadeToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show("Sistema basico de traduccion basado en XML","Acerca de...",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void TraducirToolStripMenuItemClick(object sender, EventArgs e){
			loadxml(@"translations.xml");	
		}
		
		void MainFormLoad(object sender, EventArgs e){
			cbolang.SelectedIndex=0;
		}
	}
}

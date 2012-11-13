/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 08/11/2012
 * Hora: 10:14 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace dragdrop
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
		
		void MainFormLoad(object sender, EventArgs e){
			//this.AllowDrop=true;			
		}
		
		void MainFormDragOver(object sender, DragEventArgs e){
			if (e.Data.GetDataPresent(DataFormats.FileDrop)){
                e.Effect = DragDropEffects.Copy;
            }
		}
		
		void MainFormDragDrop(object sender, DragEventArgs e){
			string[] archivos = (string[])(e.Data.GetData(DataFormats.FileDrop));			
			if (Path.GetExtension(archivos[0]) == ".jpg" || Path.GetExtension(archivos[0]) == ".png"){
				imagen.ImageLocation = archivos[0];
				this.Text=archivos[0];
			}
		}
	}
}

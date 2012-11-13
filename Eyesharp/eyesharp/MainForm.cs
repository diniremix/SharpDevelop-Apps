/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 08/11/2012
 * Hora: 06:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace eyesharp{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form{
		List<string> list = new List<string>();
		int pos=0;//para moverse por la lista buscando imagenes
		int max=0;//max cant de imagenes de la lista
		string imgpath="";//para manejar las rutas de la imagen
		string dirpath="";
		
		public MainForm(){
			InitializeComponent();
		}		
		
		void ToolStripBtnantClick(object sender, EventArgs e){
			//img anterior
			pos--;
			if(pos<0){
				pos=max-1;
			}
			imgpath=list[pos];
			colocaimg(imgpath);	
		}
		
		void ToolStripBtnsgteClick(object sender, EventArgs e){
			//img siguiente
			pos++;
			if(pos>=max){
				pos=0;
			}
			imgpath=list[pos];
			colocaimg(imgpath);
		}
		
		void ToolStripBtnajustarClick(object sender, EventArgs e){
			//ajustar la img
			colocaimg(imgpath);
			this.imgbox.SizeMode =  PictureBoxSizeMode.StretchImage;
		}
		
		void ToolStripBtntamrealClick(object sender, EventArgs e){
			//tamaño real
			colocaimg(imgpath);
			imgbox.SizeMode =  PictureBoxSizeMode.CenterImage;
			imgbox.SizeMode =  PictureBoxSizeMode.Normal;
		}
		
		void ToolStripBtneditarClick(object sender, EventArgs e){
			//editar con paint
			if ( System.IO.File.Exists( imgpath ) == true ){
				Process p = new Process();
				p.StartInfo.FileName = "mspaint";
				p.StartInfo.Arguments =imgpath;
				p.StartInfo.UseShellExecute = true;
				p.Start();
			}else{
				MessageBox.Show("No se puede encontrar la imagen especificada:\n"+imgpath,"Error");
			}
		}
		
		void MainFormLoad(object sender, EventArgs e){
			//redimensionar la forma			
			this.Width=800;
			this.Height=600;			
		}		
		
		void ToolStripBtneliminarClick(object sender, EventArgs e){
			//elimina la imagen
			if ( System.IO.File.Exists( imgpath ) == true ){
				try{
	                System.IO.File.Delete(imgpath);
	                MessageBox.Show("Imagen: "+imgpath+" eliminada!","Informacion");
	            }
	            catch (System.IO.IOException errmsg){
	                MessageBox.Show(errmsg.Message);
	                return;
	            }
			}else{
				MessageBox.Show("No se puede encontrar la imagen especificada:\n"+imgpath,"Error");
			}
		}
		
		void ToolStripBtnabrirClick(object sender, EventArgs e){
			//abrir un directorio de imagenes
			if(folderBrowser.ShowDialog() == DialogResult.OK){
				dirpath=folderBrowser.SelectedPath;
				obtenerImagenes(dirpath);
				//si hay imagenes carga la primera
				if(max>=0){
					colocaimg(list[0]);
				}				
			}
		}
		private void obtenerImagenes(string ruta){
			//obtener las imagenes de un folder
			DirectoryInfo folder = new DirectoryInfo(ruta);
			list.Clear();
			string file_ext;
			//obtengo los ficheros contenidos en la ruta
			foreach (FileInfo file in folder.GetFiles()){
				//obtengo las extensiones de archivos necesarias			
				file_ext = Path.GetExtension(file.Name).ToLower();
				if ((file_ext == ".png") ||(file_ext == ".jpg")||(file_ext == ".jpeg")|| (file_ext == ".bmp")||(file_ext == ".gif")|| (file_ext == ".ico")|| (file_ext == ".emf")|| (file_ext == ".wmf")){					
					//se agregan las imagenes a una lista dinamica
					list.Add(file.FullName);//file.Name
				}
			}
			max=list.Count;
		}
		
		private void colocaimg(string img){
			//fija una imagen en el imgbox
			this.Text="EyeSharp - "+img;
			imgbox.ImageLocation=img;
		}
		
		void ToolStripBtnaboutClick(object sender, EventArgs e){
			//acerca de
			MessageBox.Show("EyeSharp, Sencillo visor de imagenes");
		}		
		
		void ToolStripBtnactClick(object sender, EventArgs e){
			//actualiza la lista en busca de nuevas imagenes			
			max=0;
			pos=0;
			imgpath="";
			obtenerImagenes(dirpath);
			//si hay imagenes carga la primera
			if(max>=0){
				colocaimg(list[0]);
			}
		}
		
		void MainFormDragDrop(object sender, DragEventArgs e){
			//si el archivo que se arrastra es una imagen
			string[] archivos = (string[])(e.Data.GetData(DataFormats.FileDrop));			
			if (Path.GetExtension(archivos[0]) == ".jpg" || Path.GetExtension(archivos[0]) == ".png"){
				imgbox.ImageLocation = archivos[0];
				this.Text=archivos[0];
			}
		}
		
		void MainFormDragOver(object sender, DragEventArgs e){
			//permitir el arraster sobre la forma
			if (e.Data.GetDataPresent(DataFormats.FileDrop)){
	            e.Effect = DragDropEffects.Copy;
	        }
		}
	}
}

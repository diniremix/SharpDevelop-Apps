/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 17/10/2012
 * Hora: 11:49 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//Utilizamos la DLL
using System.Data.SQLite;

namespace sqlite3ex{	
	public partial class MainForm : Form{
		public MainForm(){
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e){
			//creamos una variable para manejar la conexion
			SQLiteConnection conexion;
			//creamos una nueva db
			conexion =new SQLiteConnection("Data Source=midb.db;Version=3;New=True;Compress=True;");
			//abrimos la conexion
			conexion.Open();           
			// creamos la consulta
			string consulta = "select * from usuarios where pass="+"'"+edpass.Text+"'";;
			//la ejecutamos
			SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
			//leemos la respuesta
			SQLiteDataReader datos = cmd.ExecuteReader();
			// Leemos los datos de la consulta
			if (datos.Read()){
				//asignamos a una variable el resultado de cada campo
				string id = Convert.ToString(datos[0]);
				string nombre = Convert.ToString(datos[1]);
				string usuario = Convert.ToString(datos[2]);
				string pass = Convert.ToString(datos[3]);
				lbuser.Text="usuario: "+usuario;
				MessageBox.Show("Id: "+id+
								"\nUsuario encontrado: "+nombre+
								"\n"+"Contraseña: "+pass);
			}else{
				MessageBox.Show("No se encontro el usuario");
			}
			//cerramos la conexion
			conexion.Close();
		}
	}
}

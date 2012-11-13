/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 11/11/2012
 * Hora: 08:36 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace parametros
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
			//averiguamos si se han pasado parametros
			if (Environment.GetCommandLineArgs().Length > 1) { 
				//creamos un array con los parametros
                String[] parametros = Environment.GetCommandLineArgs(); 
                //label1.Text=parametros[1];
                for (int i = 1; i < parametros.Length; i++){ 
                    //MessageBox.Show("Parámetro " + parametros[i]); 
                    label1.Text+=" "+parametros[i];
                }
            }  
		}
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 08/11/2012
 * Hora: 10:14 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace dragdrop
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.imagen = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
			this.SuspendLayout();
			// 
			// imagen
			// 
			this.imagen.Location = new System.Drawing.Point(12, 12);
			this.imagen.Name = "imagen";
			this.imagen.Size = new System.Drawing.Size(370, 236);
			this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imagen.TabIndex = 0;
			this.imagen.TabStop = false;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 355);
			this.Controls.Add(this.imagen);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "dragdrop";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
			this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainFormDragOver);
			((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox imagen;
	}
}

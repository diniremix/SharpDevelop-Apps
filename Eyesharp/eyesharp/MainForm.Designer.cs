/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 08/11/2012
 * Hora: 06:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace eyesharp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.imgbox = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripBtnabrir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnant = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnsgte = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnajustar = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtntamreal = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtneditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtneliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnabout = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnact = new System.Windows.Forms.ToolStripButton();
			this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgbox
			// 
			this.imgbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbox.Image = ((System.Drawing.Image)(resources.GetObject("imgbox.Image")));
			this.imgbox.Location = new System.Drawing.Point(0, 0);
			this.imgbox.Name = "imgbox";
			this.imgbox.Size = new System.Drawing.Size(560, 216);
			this.imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgbox.TabIndex = 0;
			this.imgbox.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripBtnabrir,
									this.toolStripSeparator1,
									this.toolStripBtnant,
									this.toolStripBtnsgte,
									this.toolStripSeparator2,
									this.toolStripBtnajustar,
									this.toolStripBtntamreal,
									this.toolStripSeparator3,
									this.toolStripBtneditar,
									this.toolStripBtneliminar,
									this.toolStripBtnabout,
									this.toolStripBtnact});
			this.toolStrip1.Location = new System.Drawing.Point(0, 191);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStrip1.Size = new System.Drawing.Size(560, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripBtnabrir
			// 
			this.toolStripBtnabrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnabrir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnabrir.Image")));
			this.toolStripBtnabrir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnabrir.Name = "toolStripBtnabrir";
			this.toolStripBtnabrir.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtnabrir.Text = "toolStripButton1";
			this.toolStripBtnabrir.ToolTipText = "Abrir Directorio";
			this.toolStripBtnabrir.Click += new System.EventHandler(this.ToolStripBtnabrirClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnant
			// 
			this.toolStripBtnant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnant.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnant.Image")));
			this.toolStripBtnant.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnant.Name = "toolStripBtnant";
			this.toolStripBtnant.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtnant.Text = "toolStripButton1";
			this.toolStripBtnant.ToolTipText = "Anterior";
			this.toolStripBtnant.Click += new System.EventHandler(this.ToolStripBtnantClick);
			// 
			// toolStripBtnsgte
			// 
			this.toolStripBtnsgte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnsgte.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnsgte.Image")));
			this.toolStripBtnsgte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnsgte.Name = "toolStripBtnsgte";
			this.toolStripBtnsgte.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtnsgte.Text = "toolStripButton2";
			this.toolStripBtnsgte.ToolTipText = "Siguiente";
			this.toolStripBtnsgte.Click += new System.EventHandler(this.ToolStripBtnsgteClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtnajustar
			// 
			this.toolStripBtnajustar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnajustar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnajustar.Image")));
			this.toolStripBtnajustar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnajustar.Name = "toolStripBtnajustar";
			this.toolStripBtnajustar.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtnajustar.Text = "toolStripButton3";
			this.toolStripBtnajustar.ToolTipText = "Ajustar";
			this.toolStripBtnajustar.Click += new System.EventHandler(this.ToolStripBtnajustarClick);
			// 
			// toolStripBtntamreal
			// 
			this.toolStripBtntamreal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtntamreal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtntamreal.Image")));
			this.toolStripBtntamreal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtntamreal.Name = "toolStripBtntamreal";
			this.toolStripBtntamreal.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtntamreal.Text = "toolStripButton4";
			this.toolStripBtntamreal.ToolTipText = "Tamaño real";
			this.toolStripBtntamreal.Click += new System.EventHandler(this.ToolStripBtntamrealClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripBtneditar
			// 
			this.toolStripBtneditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtneditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtneditar.Image")));
			this.toolStripBtneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtneditar.Name = "toolStripBtneditar";
			this.toolStripBtneditar.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtneditar.Text = "toolStripButton6";
			this.toolStripBtneditar.ToolTipText = "editar";
			this.toolStripBtneditar.Click += new System.EventHandler(this.ToolStripBtneditarClick);
			// 
			// toolStripBtneliminar
			// 
			this.toolStripBtneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtneliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtneliminar.Image")));
			this.toolStripBtneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtneliminar.Name = "toolStripBtneliminar";
			this.toolStripBtneliminar.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtneliminar.Text = "toolStripButton5";
			this.toolStripBtneliminar.ToolTipText = "Eliminar la imagen";
			this.toolStripBtneliminar.Click += new System.EventHandler(this.ToolStripBtneliminarClick);
			// 
			// toolStripBtnabout
			// 
			this.toolStripBtnabout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnabout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnabout.Image")));
			this.toolStripBtnabout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnabout.Name = "toolStripBtnabout";
			this.toolStripBtnabout.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtnabout.Text = "toolStripButton1";
			this.toolStripBtnabout.ToolTipText = "Acerca de...";
			this.toolStripBtnabout.Click += new System.EventHandler(this.ToolStripBtnaboutClick);
			// 
			// toolStripBtnact
			// 
			this.toolStripBtnact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnact.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnact.Image")));
			this.toolStripBtnact.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnact.Name = "toolStripBtnact";
			this.toolStripBtnact.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtnact.Text = "toolStripButton1";
			this.toolStripBtnact.ToolTipText = "Actualizar lista de imagenes";
			this.toolStripBtnact.Click += new System.EventHandler(this.ToolStripBtnactClick);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 216);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.imgbox);
			this.Name = "MainForm";
			this.Text = "eyesharp";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
			this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainFormDragOver);
			((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton toolStripBtnact;
		private System.Windows.Forms.ToolStripButton toolStripBtnabout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.ToolStripButton toolStripBtnabrir;
		private System.Windows.Forms.ToolStripButton toolStripBtneliminar;
		private System.Windows.Forms.ToolStripButton toolStripBtneditar;
		private System.Windows.Forms.ToolStripButton toolStripBtntamreal;
		private System.Windows.Forms.ToolStripButton toolStripBtnajustar;
		private System.Windows.Forms.ToolStripButton toolStripBtnsgte;
		private System.Windows.Forms.ToolStripButton toolStripBtnant;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.PictureBox imgbox;
	}
}

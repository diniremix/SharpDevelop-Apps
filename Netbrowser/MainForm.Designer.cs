/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 20/10/2012
 * Hora: 10:41 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace netbrowser
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnback = new System.Windows.Forms.ToolStripButton();
			this.btnforward = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnhome = new System.Windows.Forms.ToolStripButton();
			this.texturl = new System.Windows.Forms.ToolStripTextBox();
			this.btngo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnrefresh = new System.Windows.Forms.ToolStripButton();
			this.btnstop = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnoptions = new System.Windows.Forms.ToolStripDropDownButton();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optpagehome = new System.Windows.Forms.ToolStripMenuItem();
			this.optabout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnexit = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbpagename = new System.Windows.Forms.ToolStripStatusLabel();
			this.buscador = new System.Windows.Forms.WebBrowser();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnback,
									this.btnforward,
									this.toolStripSeparator1,
									this.btnhome,
									this.texturl,
									this.btngo,
									this.toolStripSeparator2,
									this.btnrefresh,
									this.btnstop,
									this.toolStripSeparator3,
									this.btnoptions,
									this.toolStripSeparator4,
									this.btnexit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(705, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnback
			// 
			this.btnback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
			this.btnback.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(23, 22);
			this.btnback.Text = "Atras";
			this.btnback.Click += new System.EventHandler(this.BtnbackClick);
			// 
			// btnforward
			// 
			this.btnforward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnforward.Image = ((System.Drawing.Image)(resources.GetObject("btnforward.Image")));
			this.btnforward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnforward.Name = "btnforward";
			this.btnforward.Size = new System.Drawing.Size(23, 22);
			this.btnforward.Text = "Adelante";
			this.btnforward.Click += new System.EventHandler(this.BtnforwardClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnhome
			// 
			this.btnhome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
			this.btnhome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnhome.Name = "btnhome";
			this.btnhome.Size = new System.Drawing.Size(23, 22);
			this.btnhome.Text = "Inicio";
			this.btnhome.Click += new System.EventHandler(this.BtnhomeClick);
			// 
			// texturl
			// 
			this.texturl.Name = "texturl";
			this.texturl.Size = new System.Drawing.Size(350, 25);
			// 
			// btngo
			// 
			this.btngo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btngo.Image = ((System.Drawing.Image)(resources.GetObject("btngo.Image")));
			this.btngo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btngo.Name = "btngo";
			this.btngo.Size = new System.Drawing.Size(23, 22);
			this.btngo.Text = "Ir";
			this.btngo.Click += new System.EventHandler(this.BtngoClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnrefresh
			// 
			this.btnrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
			this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnrefresh.Name = "btnrefresh";
			this.btnrefresh.Size = new System.Drawing.Size(23, 22);
			this.btnrefresh.Text = "Refrescar";
			this.btnrefresh.Click += new System.EventHandler(this.BtnrefreshClick);
			// 
			// btnstop
			// 
			this.btnstop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
			this.btnstop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnstop.Name = "btnstop";
			this.btnstop.Size = new System.Drawing.Size(23, 22);
			this.btnstop.Text = "Detener";
			this.btnstop.Click += new System.EventHandler(this.BtnstopClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnoptions
			// 
			this.btnoptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnoptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.opcionesToolStripMenuItem,
									this.optabout});
			this.btnoptions.Image = ((System.Drawing.Image)(resources.GetObject("btnoptions.Image")));
			this.btnoptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnoptions.Name = "btnoptions";
			this.btnoptions.Size = new System.Drawing.Size(29, 22);
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.optpagehome});
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// optpagehome
			// 
			this.optpagehome.Name = "optpagehome";
			this.optpagehome.Size = new System.Drawing.Size(206, 22);
			this.optpagehome.Text = "Cambiar pagina de inicio";
			this.optpagehome.Click += new System.EventHandler(this.OptpagehomeClick);
			// 
			// optabout
			// 
			this.optabout.Name = "optabout";
			this.optabout.Size = new System.Drawing.Size(126, 22);
			this.optabout.Text = "Acerca de";
			this.optabout.Click += new System.EventHandler(this.OptaboutClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// btnexit
			// 
			this.btnexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
			this.btnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(23, 22);
			this.btnexit.Text = "Salir";
			this.btnexit.Click += new System.EventHandler(this.BtnexitClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.lbpagename});
			this.statusStrip1.Location = new System.Drawing.Point(0, 254);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(705, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
			this.toolStripStatusLabel1.Text = "NetBrowser 0.2";
			// 
			// lbpagename
			// 
			this.lbpagename.Name = "lbpagename";
			this.lbpagename.Size = new System.Drawing.Size(49, 17);
			this.lbpagename.Text = "pagina: ";
			// 
			// buscador
			// 
			this.buscador.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buscador.Location = new System.Drawing.Point(0, 25);
			this.buscador.MinimumSize = new System.Drawing.Size(20, 20);
			this.buscador.Name = "buscador";
			this.buscador.Size = new System.Drawing.Size(705, 229);
			this.buscador.TabIndex = 2;
			this.buscador.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BuscadorDocumentCompleted);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 276);
			this.Controls.Add(this.buscador);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "NetBrowser";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnexit;
		private System.Windows.Forms.ToolStripMenuItem optabout;
		private System.Windows.Forms.ToolStripMenuItem optpagehome;
		private System.Windows.Forms.ToolStripStatusLabel lbpagename;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton btnoptions;
		private System.Windows.Forms.ToolStripButton btnstop;
		private System.Windows.Forms.ToolStripButton btnrefresh;
		private System.Windows.Forms.ToolStripButton btngo;
		private System.Windows.Forms.ToolStripTextBox texturl;
		private System.Windows.Forms.ToolStripButton btnhome;
		private System.Windows.Forms.ToolStripButton btnforward;
		private System.Windows.Forms.ToolStripButton btnback;
		private System.Windows.Forms.WebBrowser buscador;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 20/10/2012
 * Hora: 11:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace netbrowser
{
	partial class frmoptions
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboengine = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.texhomepage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnok = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboengine);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.texhomepage);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(421, 107);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Generales";
			// 
			// cboengine
			// 
			this.cboengine.FormattingEnabled = true;
			this.cboengine.Items.AddRange(new object[] {
									"Seleccione",
									"Google",
									"Yahoo",
									"Wikipedia",
									"Bing"});
			this.cboengine.Location = new System.Drawing.Point(122, 54);
			this.cboengine.Name = "cboengine";
			this.cboengine.Size = new System.Drawing.Size(190, 21);
			this.cboengine.TabIndex = 3;
			this.cboengine.Text = "Seleccione";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Motor de Busqueda:";
			// 
			// texhomepage
			// 
			this.texhomepage.Location = new System.Drawing.Point(122, 19);
			this.texhomepage.Name = "texhomepage";
			this.texhomepage.Size = new System.Drawing.Size(190, 20);
			this.texhomepage.TabIndex = 1;
			this.texhomepage.Text = "http://www.google.com";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pagina de Inicio:";
			// 
			// btnok
			// 
			this.btnok.Location = new System.Drawing.Point(277, 139);
			this.btnok.Name = "btnok";
			this.btnok.Size = new System.Drawing.Size(75, 23);
			this.btnok.TabIndex = 1;
			this.btnok.Text = "&Aceptar";
			this.btnok.UseVisualStyleBackColor = true;
			this.btnok.Click += new System.EventHandler(this.Button1Click);
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(358, 139);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 2;
			this.btncancel.Text = "&Cancelar";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.Button2Click);
			// 
			// frmoptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 175);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnok);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmoptions";
			this.Text = "Opciones";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboengine;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox texhomepage;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 25/10/2012
 * Hora: 08:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Firewall
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
			this.btnadd = new System.Windows.Forms.Button();
			this.btnclose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.texturl = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listurl = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(366, 16);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(52, 23);
			this.btnadd.TabIndex = 0;
			this.btnadd.Text = "&Agregar";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.BtnaddClick);
			// 
			// btnclose
			// 
			this.btnclose.Location = new System.Drawing.Point(356, 358);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(75, 23);
			this.btnclose.TabIndex = 1;
			this.btnclose.Text = "A&ceptar";
			this.btnclose.UseVisualStyleBackColor = true;
			this.btnclose.Click += new System.EventHandler(this.BtncloseClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Url:";
			// 
			// texturl
			// 
			this.texturl.Location = new System.Drawing.Point(42, 19);
			this.texturl.Name = "texturl";
			this.texturl.Size = new System.Drawing.Size(318, 20);
			this.texturl.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listurl);
			this.groupBox1.Controls.Add(this.texturl);
			this.groupBox1.Controls.Add(this.btnadd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(7, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 340);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sitios bloqueados";
			// 
			// listurl
			// 
			this.listurl.FormattingEnabled = true;
			this.listurl.Location = new System.Drawing.Point(42, 54);
			this.listurl.Name = "listurl";
			this.listurl.Size = new System.Drawing.Size(318, 264);
			this.listurl.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 387);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnclose);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Firewall";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox listurl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox texturl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnclose;
		private System.Windows.Forms.Button btnadd;
	}
}

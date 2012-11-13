/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 17/10/2012
 * Hora: 11:49 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace sqlite3ex
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
			this.button1 = new System.Windows.Forms.Button();
			this.ednomb = new System.Windows.Forms.TextBox();
			this.edpass = new System.Windows.Forms.TextBox();
			this.lbuser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "entrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// ednomb
			// 
			this.ednomb.Location = new System.Drawing.Point(83, 33);
			this.ednomb.Name = "ednomb";
			this.ednomb.Size = new System.Drawing.Size(100, 20);
			this.ednomb.TabIndex = 1;
			this.ednomb.Text = "diniremix";
			// 
			// edpass
			// 
			this.edpass.Location = new System.Drawing.Point(83, 75);
			this.edpass.Name = "edpass";
			this.edpass.Size = new System.Drawing.Size(100, 20);
			this.edpass.TabIndex = 2;
			this.edpass.Text = "gaedrem07";
			// 
			// lbuser
			// 
			this.lbuser.Location = new System.Drawing.Point(189, 52);
			this.lbuser.Name = "lbuser";
			this.lbuser.Size = new System.Drawing.Size(124, 23);
			this.lbuser.TabIndex = 3;
			this.lbuser.Text = "usuario:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Contraseña:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 275);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbuser);
			this.Controls.Add(this.edpass);
			this.Controls.Add(this.ednomb);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "SharpSQLite3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbuser;
		private System.Windows.Forms.TextBox edpass;
		private System.Windows.Forms.TextBox ednomb;
		private System.Windows.Forms.Button button1;
	}
}

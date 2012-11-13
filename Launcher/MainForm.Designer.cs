/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 24/10/2012
 * Hora: 03:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace launcher
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
			this.textrun = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btncancel = new System.Windows.Forms.Button();
			this.btnejec = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textrun
			// 
			this.textrun.Location = new System.Drawing.Point(59, 30);
			this.textrun.Name = "textrun";
			this.textrun.Size = new System.Drawing.Size(302, 20);
			this.textrun.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Abrir:";
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(150, 56);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 3;
			this.btncancel.Text = "&Cancelar";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
			// 
			// btnejec
			// 
			this.btnejec.Location = new System.Drawing.Point(59, 56);
			this.btnejec.Name = "btnejec";
			this.btnejec.Size = new System.Drawing.Size(75, 23);
			this.btnejec.TabIndex = 4;
			this.btnejec.Text = "&Ejecutar";
			this.btnejec.UseVisualStyleBackColor = true;
			this.btnejec.Click += new System.EventHandler(this.BtnejecClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 100);
			this.Controls.Add(this.btnejec);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textrun);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Launcher";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnejec;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textrun;
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: Diniremix
 * Fecha: 18/10/2012
 * Hora: 08:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace B2ConfigLauncher
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbolang = new System.Windows.Forms.ComboBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnsave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbolang);
			this.groupBox1.Controls.Add(this.txtuser);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 214);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Borderlands 2 Config Launcher";
			// 
			// cbolang
			// 
			this.cbolang.DisplayMember = "0";
			this.cbolang.FormattingEnabled = true;
			this.cbolang.Items.AddRange(new object[] {
									"English",
									"French",
									"German",
									"Italian",
									"Japanese",
									"Spanish"});
			this.cbolang.Location = new System.Drawing.Point(107, 160);
			this.cbolang.Name = "cbolang";
			this.cbolang.Size = new System.Drawing.Size(147, 21);
			this.cbolang.TabIndex = 4;
			this.cbolang.ValueMember = "0";			
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(107, 187);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(147, 20);
			this.txtuser.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(52, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Idioma:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(52, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuario:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(290, 135);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(91, 218);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(119, 23);
			this.btnsave.TabIndex = 1;
			this.btnsave.Text = "&Guardar y jugar";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(309, 242);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "B2ConfigLauncher";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.ComboBox cbolang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			this.cbolang.SelectedIndex=0;
			this.txtuser.Focus();
		}
	}
}

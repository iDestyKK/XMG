/*
 * Created by SharpDevelop.
 * User: iDesty
 * Date: 9/24/2013
 * Time: 12:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace XMG
{
	partial class export
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(export));
			this.path_text = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.path_button = new System.Windows.Forms.Button();
			this.saveXMG_dialog = new System.Windows.Forms.SaveFileDialog();
			this.method_combobox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.compression_combobox = new System.Windows.Forms.ComboBox();
			this.saveXMG_button = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.key_textbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// path_text
			// 
			this.path_text.BackColor = System.Drawing.Color.Black;
			this.path_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.path_text.ForeColor = System.Drawing.Color.White;
			this.path_text.Location = new System.Drawing.Point(87, 13);
			this.path_text.Name = "path_text";
			this.path_text.ReadOnly = true;
			this.path_text.Size = new System.Drawing.Size(336, 20);
			this.path_text.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "File Path:";
			// 
			// path_button
			// 
			this.path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.path_button.ForeColor = System.Drawing.Color.White;
			this.path_button.Location = new System.Drawing.Point(429, 12);
			this.path_button.Name = "path_button";
			this.path_button.Size = new System.Drawing.Size(70, 21);
			this.path_button.TabIndex = 2;
			this.path_button.Text = "Select";
			this.path_button.UseVisualStyleBackColor = true;
			this.path_button.Click += new System.EventHandler(this.Path_buttonClick);
			// 
			// saveXMG_dialog
			// 
			this.saveXMG_dialog.Filter = "DERPG XMG Images (*.XMG)|*.XMG";
			this.saveXMG_dialog.Title = "Save an XMG Image";
			// 
			// method_combobox
			// 
			this.method_combobox.BackColor = System.Drawing.Color.Black;
			this.method_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.method_combobox.ForeColor = System.Drawing.Color.White;
			this.method_combobox.FormattingEnabled = true;
			this.method_combobox.Items.AddRange(new object[] {
									"RAW",
									"Horizontal Scan",
									"Vertical Scan"});
			this.method_combobox.Location = new System.Drawing.Point(87, 72);
			this.method_combobox.Name = "method_combobox";
			this.method_combobox.Size = new System.Drawing.Size(121, 21);
			this.method_combobox.TabIndex = 1;
			this.method_combobox.Text = "RAW";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Method:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Compression:";
			// 
			// compression_combobox
			// 
			this.compression_combobox.BackColor = System.Drawing.Color.Black;
			this.compression_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.compression_combobox.ForeColor = System.Drawing.Color.White;
			this.compression_combobox.FormattingEnabled = true;
			this.compression_combobox.Items.AddRange(new object[] {
									"None",
									"GZip",
									"BZip2",
									"XZ"});
			this.compression_combobox.Location = new System.Drawing.Point(87, 99);
			this.compression_combobox.Name = "compression_combobox";
			this.compression_combobox.Size = new System.Drawing.Size(121, 21);
			this.compression_combobox.TabIndex = 4;
			this.compression_combobox.Text = "None";
			this.compression_combobox.SelectedIndexChanged += new System.EventHandler(this.Compression_comboboxSelectedIndexChanged);
			// 
			// saveXMG_button
			// 
			this.saveXMG_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveXMG_button.ForeColor = System.Drawing.Color.White;
			this.saveXMG_button.Location = new System.Drawing.Point(397, 99);
			this.saveXMG_button.Name = "saveXMG_button";
			this.saveXMG_button.Size = new System.Drawing.Size(102, 21);
			this.saveXMG_button.TabIndex = 6;
			this.saveXMG_button.Text = "Save XMG";
			this.saveXMG_button.UseVisualStyleBackColor = true;
			this.saveXMG_button.Click += new System.EventHandler(this.SaveXMG_buttonClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(224, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Estimated Size: ???";
			// 
			// key_textbox
			// 
			this.key_textbox.BackColor = System.Drawing.Color.Black;
			this.key_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.key_textbox.ForeColor = System.Drawing.Color.White;
			this.key_textbox.Location = new System.Drawing.Point(87, 42);
			this.key_textbox.Name = "key_textbox";
			this.key_textbox.Size = new System.Drawing.Size(336, 20);
			this.key_textbox.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Key:";
			// 
			// export
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(511, 134);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.key_textbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.saveXMG_button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.compression_combobox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.method_combobox);
			this.Controls.Add(this.path_button);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.path_text);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "export";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Export to XMG";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox key_textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveXMG_button;
		private System.Windows.Forms.ComboBox compression_combobox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox method_combobox;
		public System.Windows.Forms.SaveFileDialog saveXMG_dialog;
		private System.Windows.Forms.Button path_button;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox path_text;
	}
}

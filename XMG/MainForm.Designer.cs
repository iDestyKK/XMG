/*
 * Created by SharpDevelop.
 * User: iDesty
 * Date: 9/23/2013
 * Time: 6:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace XMG
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tool_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel_image = new System.Windows.Forms.Panel();
			this.openImage_dialog = new System.Windows.Forms.OpenFileDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.colorpanel = new System.Windows.Forms.Panel();
			this.RGBA_label = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.x_numeric = new System.Windows.Forms.NumericUpDown();
			this.y_numeric = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.information_label = new System.Windows.Forms.Label();
			this.saveXMG_dialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.x_numeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.y_numeric)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Black;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.menuStrip1.Size = new System.Drawing.Size(885, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.loadToolStripMenuItem,
									this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.saveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Black;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tool_status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 493);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(885, 23);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tool_status
			// 
			this.tool_status.BackColor = System.Drawing.Color.Transparent;
			this.tool_status.ForeColor = System.Drawing.Color.White;
			this.tool_status.Name = "tool_status";
			this.tool_status.Size = new System.Drawing.Size(165, 18);
			this.tool_status.Text = "DERPG XMG Image Viewer";
			// 
			// panel_image
			// 
			this.panel_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel_image.AutoScroll = true;
			this.panel_image.BackColor = System.Drawing.Color.Transparent;
			this.panel_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel_image.Location = new System.Drawing.Point(0, 0);
			this.panel_image.Name = "panel_image";
			this.panel_image.Size = new System.Drawing.Size(639, 465);
			this.panel_image.TabIndex = 2;
			// 
			// openImage_dialog
			// 
			this.openImage_dialog.Filter = "Common Image Files (*.png, *.jpg,*.jpeg, *.bmp, *.gif, *.XMG, *.XMG.XZ, *XMG.BZ2," +
			" *XMG.XZ)|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.XMG;*.XMG.GZ;*.XMG.BZ2;*.XMG.XZ";
			this.openImage_dialog.Title = "Open an Image";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Black;
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
			this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
			this.splitContainer1.Panel2.Controls.Add(this.panel_image);
			this.splitContainer1.Size = new System.Drawing.Size(885, 467);
			this.splitContainer1.SplitterDistance = 240;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.colorpanel);
			this.groupBox2.Controls.Add(this.RGBA_label);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.x_numeric);
			this.groupBox2.Controls.Add(this.y_numeric);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(4, 60);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(231, 117);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pixel Information";
			// 
			// colorpanel
			// 
			this.colorpanel.BackColor = System.Drawing.Color.Black;
			this.colorpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorpanel.Location = new System.Drawing.Point(172, 18);
			this.colorpanel.Name = "colorpanel";
			this.colorpanel.Size = new System.Drawing.Size(46, 46);
			this.colorpanel.TabIndex = 6;
			// 
			// RGBA_label
			// 
			this.RGBA_label.Location = new System.Drawing.Point(10, 80);
			this.RGBA_label.Name = "RGBA_label";
			this.RGBA_label.Size = new System.Drawing.Size(208, 23);
			this.RGBA_label.TabIndex = 5;
			this.RGBA_label.Text = "RGBA(N,N,N,N)";
			this.RGBA_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Y";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "X";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// x_numeric
			// 
			this.x_numeric.BackColor = System.Drawing.Color.Black;
			this.x_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.x_numeric.ForeColor = System.Drawing.Color.White;
			this.x_numeric.Location = new System.Drawing.Point(34, 19);
			this.x_numeric.Maximum = new decimal(new int[] {
									0,
									0,
									0,
									0});
			this.x_numeric.Name = "x_numeric";
			this.x_numeric.Size = new System.Drawing.Size(57, 20);
			this.x_numeric.TabIndex = 1;
			this.x_numeric.ValueChanged += new System.EventHandler(this.X_numericValueChanged);
			// 
			// y_numeric
			// 
			this.y_numeric.BackColor = System.Drawing.Color.Black;
			this.y_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.y_numeric.ForeColor = System.Drawing.Color.White;
			this.y_numeric.Location = new System.Drawing.Point(34, 45);
			this.y_numeric.Maximum = new decimal(new int[] {
									0,
									0,
									0,
									0});
			this.y_numeric.Name = "y_numeric";
			this.y_numeric.Size = new System.Drawing.Size(57, 20);
			this.y_numeric.TabIndex = 2;
			this.y_numeric.ValueChanged += new System.EventHandler(this.Y_numericValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.information_label);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(231, 51);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image Information";
			// 
			// information_label
			// 
			this.information_label.BackColor = System.Drawing.Color.Transparent;
			this.information_label.ForeColor = System.Drawing.Color.Transparent;
			this.information_label.Location = new System.Drawing.Point(10, 16);
			this.information_label.Name = "information_label";
			this.information_label.Size = new System.Drawing.Size(208, 33);
			this.information_label.TabIndex = 0;
			this.information_label.Text = "Width: \r\nHeight: ";
			// 
			// saveXMG_dialog
			// 
			this.saveXMG_dialog.Filter = "DERPG XMG Images (*.XMG)|*.XMG";
			this.saveXMG_dialog.Title = "Save an XMG Image";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(885, 516);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "XMG Viewer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.x_numeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.y_numeric)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.SaveFileDialog saveXMG_dialog;
		private System.Windows.Forms.Panel colorpanel;
		private System.Windows.Forms.Label RGBA_label;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown y_numeric;
		private System.Windows.Forms.NumericUpDown x_numeric;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label information_label;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.OpenFileDialog openImage_dialog;
		private System.Windows.Forms.ToolStripStatusLabel tool_status;
		private System.Windows.Forms.Panel panel_image;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}

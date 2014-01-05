/*
 * Created by SharpDevelop.
 * User: iDesty
 * Date: 9/23/2013
 * Time: 6:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace XMG
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static string export_path;
		public static string file_path;
		public static string dir_path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().GetName().CodeBase);
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			string[] args = Environment.GetCommandLineArgs();
			dir_path = dir_path.Substring(6,dir_path.Length - 6); //Remove that "file\"... it's so annoying. -.-'
			//MessageBox.Show(dir_path);
			// The first commandline argument is always the executable path itself.
			if (args.Length > 1)
			{
				if (Path.GetExtension(args[1]).ToUpper() == ".XMG")
				{
					LoadXMG(args[1]);
	    			this.Text = "XMG Viewer: " + Path.GetFileName(args[1]);
	    			file_path = args[1];
				}
				else
				{
	    			Image image = Image.FromFile(args[1]);
	    			//Bitmap thing = new Bitmap(image);
	    			panel_image.BackgroundImage = image;
	    			x_numeric.Maximum = image.Width - 1;
	    			y_numeric.Maximum = image.Height - 1;
	    			information_label.Text = "Width: " + image.Width.ToString() + "\nHeight: " + image.Height.ToString();
	    			this.Text = "XMG Viewer: " + Path.GetFileName(args[1]);
	    			file_path = args[1];
				}
			}
		}
		
		
		public bool WriteDoubleInv(FileStream fs, int amount)
		{
			fs.WriteByte((byte) Math.Floor(Convert.ToDouble(amount / 256)));
			fs.WriteByte((byte) (amount % 256));
			return true;
		}
		
		public int ReadDoubleInv(FileStream fs)
		{
			return (fs.ReadByte() * 256) + fs.ReadByte();
		}
		
		public bool SaveXMG(string filename, int version)
		{
			int w = panel_image.BackgroundImage.Width;
			int h = panel_image.BackgroundImage.Height;
			FileStream ex = new FileStream(filename, 
                                           FileMode.Create, 
                                           FileAccess.Write);
			
			//Write the goddamn Header first
			ex.WriteByte((byte) 88); //X
			ex.WriteByte((byte) 77); //M
			ex.WriteByte((byte) 71); //G
			WriteDoubleInv(ex,version);
			
			//Now for information on the image...
			Bitmap thing = new Bitmap(panel_image.BackgroundImage);
			
			switch (version)
			{
				case 0: //This method is uncompressed and raw data.
						//First off, Width and height
						WriteDoubleInv(ex,w);
						WriteDoubleInv(ex,h);
						
						//Now for raw pixel storage
						for (int b = 0; b < h; b++)
						{
							for (int a = 0; a < w; a++)
							{
								Color pixelColor = thing.GetPixel(a,b);
								ex.WriteByte((byte) pixelColor.R);
								ex.WriteByte((byte) pixelColor.G);
								ex.WriteByte((byte) pixelColor.B);
								ex.WriteByte((byte) pixelColor.A);
							}
						}
					    break;
				case 1: //This method skips a few pixels based on repeating horizontally. However each pixel needs an identifier.
						//First off, Width and height
						WriteDoubleInv(ex,w);
						WriteDoubleInv(ex,h);
						
						int x_counter = 0;
						int y_counter = 0;
						Color c_prev = thing.GetPixel(0,0);
						
						//Now for raw pixel storage
						for (int b = 0; b < h; b++)
						{
							for (int a = 0; a < w; a++)
							{
								Color pixelColor = thing.GetPixel(a,b);
								x_counter = 1;
								if (a < w - 1)
								{
									while (thing.GetPixel(a + x_counter,b) == c_prev && a + x_counter < w - 1)
									{
										c_prev = thing.GetPixel(a + x_counter,b);
										x_counter += 1;
									}
									a += (x_counter - 1);
								}
								if (x_counter == 1)
								{
									ex.WriteByte((byte) 0); //The 0 identifier means it's just a pixel.
									ex.WriteByte((byte) pixelColor.R);
									ex.WriteByte((byte) pixelColor.G);
									ex.WriteByte((byte) pixelColor.B);
									ex.WriteByte((byte) pixelColor.A);
								}
								else
								{
									ex.WriteByte((byte) 1); //The 1 identifier means it's multiple pixels, said by the next double.
									WriteDoubleInv(ex,(byte) x_counter);
									WriteDoubleInv(ex,(byte) y_counter);
									ex.WriteByte((byte) pixelColor.R);
									ex.WriteByte((byte) pixelColor.G);
									ex.WriteByte((byte) pixelColor.B);
									ex.WriteByte((byte) pixelColor.A);
								}
							}
						}
					    break;
			}
			
			//Close the file
			ex.Close();
			
			//Dispose of the trash
			thing.Dispose();
			
			return true;
		}
		
		private void WaitForFile(string fp_file)
		{
    		FileStream stream = null;
    		bool FileReady = false;
    		while(!FileReady)
    		{
        		try
        		{
            		using(stream = new FileStream(fp_file,FileMode.Open, FileAccess.ReadWrite, FileShare.None)) 
            		{ 
                		FileReady = true; 
            		}
        		}
        		catch (IOException)
        		{
            		//File isn't ready yet, so we need to keep on waiting until it is.
        		}
        		//We'll want to wait a bit between polls, if the file isn't ready.
        		if(!FileReady) Thread.Sleep(1000);
    		}
		}
		
		public bool LoadXMG(string filename)
		{
			FileStream ex = new FileStream(filename, 
                                           FileMode.Open, 
                                           FileAccess.Read);
			int byte1 = ex.ReadByte();
			int byte2 = ex.ReadByte();
			int byte3 = ex.ReadByte();
			//Verify the Header
			if (byte1 == 253 && byte2 == 55 && byte3 == 122) //ý7z
			{
				//Check the next 2 bytes...
				if (ex.ReadByte() == 88 && ex.ReadByte() == 90) //XZ
				{
					//It's an XZ File... We need to decompress it.
					ex.Close(); //Close it first. We need critisism, not holdbacks.
					File.Copy(filename,dir_path + @"\tmp.xmg.xz",true);
					WaitForFile(dir_path + @"\tmp.xmg.xz");
					//MessageBox.Show(File.Exists(dir_path + @"\tmp.xmg.xz").ToString());
					System.Diagnostics.Process.Start(dir_path + @"\xz.exe","-d tmp.xmg.xz").WaitForExit();
					
					//Finally... reopen the decompressed file. :)
					LoadXMG("tmp.xmg");
					File.Delete("tmp.xmg"); //Take out the Trash
				}
			}
			else
			if (byte1 == 88 && byte2 == 77 && byte3 == 71) //XMG
			{
				int version = ReadDoubleInv(ex);
				//First off, Width and height
				int w = ReadDoubleInv(ex);
				int h = ReadDoubleInv(ex);
				
				Bitmap xmg_image = new Bitmap(w,h);
				
				switch (version)
				{
					case 0: //This method is uncompressed and raw data.
	    					x_numeric.Maximum = w - 1;
	    					y_numeric.Maximum = h - 1;
	    					information_label.Text = "Width: " + w.ToString() + "\nHeight: " + h.ToString();
							
							//Now for raw pixel storage
							for (int b = 0; b < h; b++)
							{
								for (int a = 0; a < w; a++)
								{
									int _r = ex.ReadByte();
									int _g = ex.ReadByte();
									int _b = ex.ReadByte();
									int _a = ex.ReadByte();
									
									xmg_image.SetPixel(a,b,Color.FromArgb(_a,_r,_g,_b));
								}
							}
							panel_image.BackgroundImage = xmg_image;
					    	break;
					case 1: //This method is for somewhat compressed data.
							
							int x_counter = 0;
							int y_counter = 0;
							
	    					x_numeric.Maximum = w - 1;
	    					y_numeric.Maximum = h - 1;
	    					information_label.Text = "Width: " + w.ToString() + "\nHeight: " + h.ToString();
							
							//Now for raw pixel storage
							for (int b = 0; b < h; b++)
							{
								for (int a = 0; a < w; a++)
								{
									switch (ex.ReadByte())
									{
										case 0: //It's just a pixel.
												int _r = ex.ReadByte();
												int _g = ex.ReadByte();
												int _b = ex.ReadByte();
												int _a = ex.ReadByte();
												xmg_image.SetPixel(a,b,Color.FromArgb(_a,_r,_g,_b));
												break;
										case 1: //It's many pixels spanned on the X Axis
												x_counter = ReadDoubleInv(ex);
												y_counter = ReadDoubleInv(ex);
												
												int _mr = ex.ReadByte();
												int _mg = ex.ReadByte();
												int _mb = ex.ReadByte();
												int _ma = ex.ReadByte();
												
												for (int c = 0; c < x_counter; c++)
												{
													xmg_image.SetPixel(a + c,b,Color.FromArgb(_ma,_mr,_mg,_mb));
												}
												a += x_counter - 1;
												break;
									}
								}
							}
							panel_image.BackgroundImage = xmg_image;
					    	break;
				}
			}
			else
			{
				MessageBox.Show("Not a Valid XMG File! Header is missing.");
			}
			
			ex.Close();
			return true;
		}
		
		void LoadToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult id = openImage_dialog.ShowDialog();
			if (id == DialogResult.OK)
	    	{
				if (Path.GetExtension(openImage_dialog.FileName).ToUpper() == ".XMG" ||
				    Path.GetExtension(openImage_dialog.FileName).ToUpper() == ".GZ" || 
				    Path.GetExtension(openImage_dialog.FileName).ToUpper() == ".BZ2" || 
				    Path.GetExtension(openImage_dialog.FileName).ToUpper() == ".XZ")
				{
					LoadXMG(openImage_dialog.FileName);
				}
				else
				{
	    			Image image = Image.FromFile(openImage_dialog.FileName);
	    			//Bitmap thing = new Bitmap(image);
	    			panel_image.BackgroundImage = image;
	    			x_numeric.Maximum = image.Width - 1;
	    			y_numeric.Maximum = image.Height - 1;
	    			information_label.Text = "Width: " + image.Width.ToString() + "\nHeight: " + image.Height.ToString();
				}
				file_path = openImage_dialog.FileName;
			}
		}
		
		void X_numericValueChanged(object sender, EventArgs e)
		{
			Bitmap thing = new Bitmap(panel_image.BackgroundImage);
			Color pixelColor = thing.GetPixel(Convert.ToInt16(x_numeric.Value),Convert.ToInt16(y_numeric.Value));
			RGBA_label.Text = "RGBA(" + pixelColor.R.ToString() + "," + pixelColor.G.ToString() + "," + pixelColor.B.ToString() + "," + pixelColor.A.ToString() + ")";
			colorpanel.BackColor = pixelColor;
			thing.Dispose();
		}
		
		void Y_numericValueChanged(object sender, EventArgs e)
		{
			Bitmap thing = new Bitmap(panel_image.BackgroundImage);
			Color pixelColor = thing.GetPixel(Convert.ToInt16(x_numeric.Value),Convert.ToInt16(y_numeric.Value));
			RGBA_label.Text = "RGBA(" + pixelColor.R.ToString() + "," + pixelColor.G.ToString() + "," + pixelColor.B.ToString() + "," + pixelColor.A.ToString() + ")";
			colorpanel.BackColor = pixelColor;
			thing.Dispose();
		}
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
		}
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			//DialogResult id = saveXMG_dialog.ShowDialog();
			//if (id == DialogResult.OK)
			if (Path.GetExtension(file_path) != ".XMG")
	    	{
				//form.path_text.Text = saveXMG_dialog.FileName;
				//export_path = saveXMG_dialog.FileName;
				Form form = new export();
				form.ShowDialog();
	    		//SaveXMG(saveXMG_dialog.FileName,1);
			}
		}
	}
}
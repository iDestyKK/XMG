/*
 * Created by SharpDevelop.
 * User: iDesty
 * Date: 9/24/2013
 * Time: 12:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace XMG
{
	/// <summary>
	/// Description of export.
	/// </summary>
	public partial class export : Form
	{
		public export()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			path_text.Text = MainForm.export_path;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public bool WriteDoubleInv(FileStream fs, int amount)
		{
			fs.WriteByte((byte) Math.Floor(Convert.ToDouble(amount / 256)));
			fs.WriteByte((byte) (amount % 256));
			return true;
		}
		
		public bool SaveXMG(string filename, int version)
		{
			//Now for information on the image...
			Bitmap thing = new Bitmap(MainForm.file_path);
			
			int w = thing.Width;
			int h = thing.Height;
			FileStream ex = new FileStream(filename, 
                                           FileMode.Create, 
                                           FileAccess.Write);
			
			//Write the goddamn Header first
			ex.WriteByte((byte) 88); //X
			ex.WriteByte((byte) 77); //M
			ex.WriteByte((byte) 71); //G
			WriteDoubleInv(ex,version);
			
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
		
		void Path_buttonClick(object sender, EventArgs e)
		{
			DialogResult id = saveXMG_dialog.ShowDialog();
			if (id == DialogResult.OK)
	    	{
	    		path_text.Text = saveXMG_dialog.FileName;
			}
		}
		
		void Compression_comboboxSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (compression_combobox.Text)
			{
				case "None": saveXMG_button.Text = "Save XMG"; break;
				case "GZip": saveXMG_button.Text = "Save XMG.GZ"; break;
				case "BZip2": saveXMG_button.Text = "Save XMG.BZ2"; break;
				case "XZ": saveXMG_button.Text = "Save XMG.XZ"; break;
				default: saveXMG_button.Text = "Save XMG"; break;
			}
		}
		
		void SaveXMG_buttonClick(object sender, EventArgs e)
		{
			if (path_text.Text != "")
			{
				switch (method_combobox.Text)
				{
					case "RAW": SaveXMG(path_text.Text,0); break;
					case "Horizontal Scan": SaveXMG(path_text.Text,1); break;
					case "Vertical Scan": MessageBox.Show("Not Supported Yet but I plan on adding it :)"); break;
				}
				
				switch (compression_combobox.Text)
				{
					case "None": break;
					case "GZip": System.Diagnostics.Process.Start(MainForm.dir_path + @"\7za.exe","a -tgzip " + path_text.Text + ".GZ " + path_text.Text).WaitForExit(); break;
					case "BZip2": System.Diagnostics.Process.Start(MainForm.dir_path + @"\7za.exe","a -tbzip2 " + path_text.Text + ".BZ2 " + path_text.Text).WaitForExit(); break;
					case "XZ": System.Diagnostics.Process.Start(MainForm.dir_path + @"\xz.exe",path_text.Text).WaitForExit(); break;
				}
				this.Close();
			}
			else
			{
				MessageBox.Show("Tell me where to save the file first... THEN click this button. :)");
			}
		}
	}
}

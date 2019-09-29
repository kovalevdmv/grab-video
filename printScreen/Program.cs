/*
 * Created by SharpDevelop.
 * User: kovalevdv
 * Date: 29.09.2019
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace printScreen
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			int delay=1000;
			Console.Write("delay in ms (default 1000 ms)?:");
			try{
				delay = Convert.ToInt32(Console.Read());
				
			} catch(Exception e){
				delay=1000;
				
					Console.WriteLine(e.ToString());
			}
			*/
			while (true) {
				try{
					Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
					Graphics graphics = Graphics.FromImage(printscreen as Image);
					graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
					graphics.DrawIcon(new Icon("Cursor.ico"),Cursor.Position.X,Cursor.Position.Y);
					printscreen.Save(@"printscreen.jpg", ImageFormat.Jpeg);
					Console.WriteLine(DateTime.Now.ToString());
					Thread.Sleep(500);
				} catch(Exception e){
					Console.WriteLine(e.ToString());
				}
    		
			}
		}
	}
}
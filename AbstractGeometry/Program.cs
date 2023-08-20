using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
	class Program
	{
		static readonly string delimiter = "\n---------------------------------------------------\n";
		static void Main(string[] args)
		{
			//Console.WindowLeft = 110;
			//Console.WindowTop = 110;
			//Console.WindowWidth = 140;
			//Console.WindowHeight = 32;

			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			Rectangle rect = new Rectangle(250, 130, 400, 10, 5, Color.AliceBlue);
			//Console.WriteLine($"Сторона 'A':{rect.SideA}");
			//Console.WriteLine($"Сторона 'B':{rect.SideB}");
			//Console.WriteLine($"Площадь прямоугольника: {rect.GetArea()}");
			//Console.WriteLine($"Периметр прямоугольника: {rect.GetPerimeter()}");
			//rect.Draw(e);
			//rect.Info(e);
			//Console.WriteLine(delimiter);

			Square square = new Square(120, 400, 155, 3, Color.Red);
			//square.Info(e);
			//Console.WriteLine(delimiter);

			Circle circle = new Circle(77, 400, 250, 3, Color.Yellow);
			circle.Info(e);

			EquilateralTriangle equilateralTriangle = new EquilateralTriangle(85, 400, 250, 12, Color.Green);
			equilateralTriangle.Info(e);

			IsoscalesTriangle isoscalesTriangle = new IsoscalesTriangle(100, 200, 500, 250, 5, Color.Chartreuse);
			isoscalesTriangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}

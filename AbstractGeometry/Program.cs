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
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle(Console.WindowLeft, Console.WindowTop, Console.WindowWidth, Console.WindowHeight);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			Rectangle rect = new Rectangle(250, 120, 150, 180, 4, Color.Green);
			//Console.WriteLine($"Сторона 'A'{rect.SideA}");
			//Console.WriteLine($"Сторона 'B'{rect.SideB}");
			//Console.WriteLine($"Площадь прямоугольника: {rect.GetArea()}");
			//Console.WriteLine($"Периметр прямоугольника: {rect.GetPerimeter()}");
			//rect.Draw(e);
			rect.info(e);
			Circle circle = new Circle(50, 10, 370, 4, Color.Blue);
			//Console.WriteLine($"Радиус окружности: {circle.Radius}");
			//Console.WriteLine($"Площадь круга: {circle.GetArea()}");
			//Console.WriteLine($"Периметр круга: {circle.GetPerimeter()}");
			//circle.Draw(e);
			circle.info(e);
			Square square = new Square(80, 480, 150, 4, Color.Red);
			//Console.WriteLine($"Стороны квадрата: {square.SideA}");
			//Console.WriteLine($"Площадь квадрата: {square.GetArea()}");
			//Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}");
			//square.Draw(e);
			square.info(e);

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}

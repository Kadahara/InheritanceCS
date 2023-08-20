using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract class Shape
	{
		int start_x;
		int start_y;
		int line_width;
		public Color Color { get; set; }
		public int StartX
		{
			get { return start_x; }
			set
			{
				if (value < 10) value = 10;
				if (value > 700) value = 500;
				start_x = value;
			}
		}
		public int StartY
		{
			get { return start_y; }
			set
			{
				if (value < 10) value = 10;
				if (value > 500) value = 500;
				start_y = value;
			}
		}
		public int LineWidth
		{
			get { return line_width; }
			set
			{
				if (value < 1) value = 1;
				if (value > 32) value = 32;
				line_width = value;
			}
		}
		public Shape(int start_x, int start_y, int line_width, Color color)
		{
			StartX = start_x;
			StartY = start_y;
			LineWidth = line_width;
			Color = color;
		}
		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw(PaintEventArgs e);

		public virtual void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Площадь фигуры: {this.GetArea()}");
			Console.WriteLine($"Периметр фигуры: {this.GetPerimeter()}");
			this.Draw(e);
			Console.WriteLine();
		}
	}
}

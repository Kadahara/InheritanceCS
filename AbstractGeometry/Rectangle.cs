using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	class Rectangle : Shape
	{
		double side_a;
		double side_b;

		public double SideA
		{
			get { return side_a; }
			set
			{
				if (value < 20) value = 20;
				if (value < 200) value = 200;
				side_a = value;
			}
		}
		public double SideB
		{
			get { return side_b; }
			set
			{
				if (value < 20) value = 20;
				if (value < 200) value = 200;
				side_b = value;
			}
		}
		public Rectangle(
			double side_a, double side_b,
			int start_x, int start_y, int line_width, Color color
			):base(start_x, start_y, line_width, color)
		{
			SideA = side_a;
			SideB = side_b;
		}
		public override double GetArea()
		{
			return SideB * SideA;
		}
		public override double GetPerimeter()
		{
			return (SideA + SideB) * 2;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)SideA, (int)SideB);
		}
		public override void info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			if (this.GetType()== typeof(AbstractGeometry.Rectangle))
			{
				Console.WriteLine($" Сторона А : {side_a}");
				Console.WriteLine($" Сторона B: {side_b}");
			Console.WriteLine("____________________________");
			}
			if (this.GetType() == typeof(AbstractGeometry.Square))
			{
			Console.WriteLine($"Длина стороны : {side_a}");
			}

			base.info(e);
		}





	}


}

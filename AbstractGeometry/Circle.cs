using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		double radius;

		public double Radius
		{
			get { return radius; }
			set
			{
				if (value < 50) value = 50;
				if (value > 550) value = 550;
				radius = value;
			}
		}
		public Circle
			(
			double radius, int start_x, int start_y, int line_width, Color color
			) : base(start_x, start_y, line_width, color)
		{
			Radius = radius;
		}
		public override double GetArea()
		{
			return   radius * radius * Math.PI;
		}
		public override double GetPerimeter()
		{
			return 2 * Math.PI * radius;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, 2 * (float)radius, 2 * (float)radius);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Радиус: {Radius}");
			base.Info(e);
		}
	}
}

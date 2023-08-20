using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	class IsoscalesTriangle : Triangle
	{
		double basis;
		double side;
		public double Basis
		{
			get { return basis; }
			set
			{
				if (value < 50) value = 50;
				if (value > 550) value = 550;
				basis = value;
			}
		}
		public double Side
		{
			get { return side; }
			set
			{
				if (value < 50) value = 50;
				if (value > 550) value = 550;
				side = value;
			}
		}
		public IsoscalesTriangle(double basis, double side, int start_x, int start_y, int line_width, System.Drawing.Color color)
			: base(start_x, start_y, line_width, color)
		{
			Basis = basis;
			Side = side;
		}
		public override double GetHeight()
		{
			double cat_1 = side;
			double cat_2 = basis / 2;
			double hypotenuse = Math.Sqrt(cat_1 * cat_1 - cat_2 * cat_2);
			return hypotenuse;
		}
		public override double GetArea()
		{
			return Basis * GetHeight() / 2;
		}
		public override double GetPerimeter()
		{
			return Basis + Side * 2;
		}
		public override void Draw(PaintEventArgs e)
		{
			System.Drawing.Pen pen = new System.Drawing.Pen(Color, LineWidth);
			System.Drawing.Point[] vertex = new System.Drawing.Point[]
				{
					new System.Drawing.Point(StartX, StartY+(int)Side),
					new System.Drawing.Point(StartX+(int)Basis, StartY+(int)Side),
					new System.Drawing.Point(StartX+(int)Basis/2, StartY+(int)(Side-GetHeight())),
				};
			e.Graphics.DrawPolygon(pen, vertex);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Основание треугольника: {Basis} ");
			Console.WriteLine($"Сторона треугольника: {Side} ");
			base.Info(e);
		}
	}
}

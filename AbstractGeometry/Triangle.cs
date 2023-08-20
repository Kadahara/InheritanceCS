using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract class Triangle : Shape
	{
		protected Triangle(int start_x, int start_y, int line_width, System.Drawing.Color color)
			: base(start_x, start_y, line_width, color) { }
		public abstract double GetHeight();
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Высота треугольника: {GetHeight()} ");
			base.Info(e);
		}
	}
}

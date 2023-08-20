using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Student : Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
		}
		public override void Init(string[] values)
		{
			Speciality = values[4].TrimStart().TrimEnd();
			Group = values[5].TrimStart().TrimEnd();
			Rating = Convert.ToDouble(values[6]);
			Attendance = Convert.ToDouble(values[7]);
		}
		public override string ToString()
		{
			//CSV - Comma Separated Values (Значения, разделенные запятыми)
			return base.ToString() + ",\t" + $" {Speciality},\t{Group},\t{Rating},\t{Attendance}";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Specciality:\t" + Speciality);
			Console.WriteLine("Group:\t\t" + Group);
			Console.WriteLine("Rating:\t\t" + Rating);
			Console.WriteLine("Attendance:\t" + Attendance);
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Teacher : Human
	{
		public string Speciality { get; set; }
		public int Experience { get; set; }
		public Teacher
			(
			string lastName, string firstName, int age,
			string speciality,
			int experience
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
		}
		public virtual void Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4].TrimStart().TrimEnd();
			Experience = Convert.ToInt32(values[5].Split(' ')[1]);
		}
		public override string ToString()
		{
			return base.ToString() + ", " + $" {Speciality},\t {Experience} лет.";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Speciality:\t" + Speciality);
			Console.WriteLine("Experience:\t" + Experience);
		}
	}
}

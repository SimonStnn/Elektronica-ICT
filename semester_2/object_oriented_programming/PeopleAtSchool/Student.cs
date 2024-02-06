using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAtSchool
{
	internal class Student
	{
		private string firstName { get; set; }
		private string lastName { get; set; }
		private int age;
		private int id;
		private int gradeLevel;
		public void AddStudent(string firstName, string lastName, int age, int id, int gradeLevel)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.id = id;
			this.gradeLevel = gradeLevel;
		}

		public void PrintStudent()
		{
			Console.WriteLine("ID: " + id);
			Console.WriteLine($"Name: {firstName} {lastName}");
			Console.WriteLine("Age: " + age);
			Console.WriteLine("Grade level: " + gradeLevel);
		}




	}
}

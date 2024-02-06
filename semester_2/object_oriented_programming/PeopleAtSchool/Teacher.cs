using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAtSchool
{
	internal class Teacher
	{
		private string firstName { get; set; }
		private string lastName { get; set; }
		private string classRoom { get; set; }
		private int salary { get; set; }
		private int age { get; set; }

		public void addTeacher(string firstName, string lastName, string classRoom, int salary, int age)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.classRoom = classRoom;
			this.salary = salary;
			this.age = age;
		}
		public string getTeacher()
		{
			return $"firstName: {firstName}, lastName: {lastName}, classRoom: {classRoom}, salary: {salary} euro, age: {age}";
		}
		public void PrintTeacher()
		{
			Console.WriteLine($"Name: {firstName} {lastName}");
			Console.WriteLine("Age: " + age);
			Console.WriteLine("salary: " + salary);
			Console.WriteLine("Classroom: " + classRoom);
		}
	}
}

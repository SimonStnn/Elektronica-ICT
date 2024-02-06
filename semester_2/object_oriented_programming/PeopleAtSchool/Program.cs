namespace PeopleAtSchool
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new();
			List<Teacher> teachers = new();

			while(true)
			{
				Console.Write("Student of Leerkracht of bekijk lijst? (s/l/b): ");
				string species = Console.ReadLine().ToLower();

				string firstName, lastName, age;
				switch(species)
				{
					case "s":
						Console.Write("Geef een voornaam in: ");
						firstName = Console.ReadLine();

						Console.Write("Geef een achternaam in: ");
						lastName = Console.ReadLine();

						Console.Write("Geef een leeftijd in: ");
						age = Console.ReadLine();

						Console.Write("Geef een id in: ");
						string id = Console.ReadLine();

						Console.Write("Geef een grade level in: ");
						string gradeLevel = Console.ReadLine();

						Student student = new();
						students.Add(student);
						student.AddStudent(firstName, lastName, Convert.ToInt32(age), Convert.ToInt32(id), Convert.ToInt32(gradeLevel));

						student.PrintStudent();
						break;
					case "l":
						Console.Write("Geef een voornaam in: ");
						firstName = Console.ReadLine();

						Console.Write("Geef een achternaam in: ");
						lastName = Console.ReadLine();

						Console.Write("Geef een leeftijd in: ");
						age = Console.ReadLine();

						Console.Write("Geef een klaslokaal in: ");
						string classRoom = Console.ReadLine();

						Console.Write("Geef een salaries in: ");
						string salary = Console.ReadLine();

						Teacher teacher = new();
						teacher.addTeacher(firstName, lastName, classRoom, Convert.ToInt32(salary), Convert.ToInt32(age));

						teacher.PrintTeacher();
						teachers.Add(teacher);
						break;
					default:
						Console.WriteLine("Studenten:");
						foreach(Student s in students)
						{
							s.PrintStudent();
							Console.WriteLine();
						}
						Console.WriteLine("\r\nLeerkrachten");
						foreach(Teacher t in teachers)
						{
							t.PrintTeacher();
							Console.WriteLine();
						}
						break;
				}
			}
		}
	}
}
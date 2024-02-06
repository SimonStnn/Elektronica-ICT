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
				// Prompt for student or teacher or list
				Console.Write("Student of Leerkracht of Bekijk lijst? (s/l/b): ");
				string species = Console.ReadLine().ToLower();

				string firstName, lastName, age;
				switch(species)
				{
					case "s":
						// Prompt for student properties
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

						// Make student and add to list
						Student student = new();
						students.Add(student);
						// Add student properties
						student.AddStudent(firstName, lastName, Convert.ToInt32(age), Convert.ToInt32(id), Convert.ToInt32(gradeLevel));
						// Print student
						student.PrintStudent();
						break;
					case "l":
						// Prompt for student properties
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

						// Make teacher
						Teacher teacher = new();
						// Add teacher properties
						teacher.addTeacher(firstName, lastName, classRoom, Convert.ToInt32(salary), Convert.ToInt32(age));
						// Print teacher
						teacher.PrintTeacher();
						// Add teacher to list
						teachers.Add(teacher);
						break;
					default:
						// Print all students and teachers
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
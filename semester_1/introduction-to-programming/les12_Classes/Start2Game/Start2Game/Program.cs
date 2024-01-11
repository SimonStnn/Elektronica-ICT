namespace Start2Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Start2Game!");

            // 1 : Create a new class called Player


            // 4 : Create a new instance of the Player class, and assign it to the variable studentAtTheLastRow
            Player studentAtTheLastRow = new();

            // 5 : Call the GainXP method on the studentAtTheLastRow, and pass in 100
            //          Write the Level and XP of the studentAtTheLastRow to the console
            studentAtTheLastRow.GainXP(100);
            Console.WriteLine($"Your level is {studentAtTheLastRow.level} and your XP is {studentAtTheLastRow.xp}");

            // 6 : Call the TakeDamage method on the studentAtTheLastRow, and pass in 50
            //          Write the Health of the studentAtTheLastRow to the console
            //          Check if the studentAtTheLastRow is dead, if yes, write "Your Dead!" to the console
            studentAtTheLastRow.TakeDamage(50);
            Console.WriteLine($"Your healt is {studentAtTheLastRow.health}");
			if(studentAtTheLastRow.IsDead())
				Console.WriteLine("You're Dead!");

			// 7 : Call the GainHealth method on the studentAtTheLastRow, and pass in 20
			//          Write the Health of the studentAtTheLastRow to the console
			studentAtTheLastRow.GainHealth(20);
			Console.WriteLine($"Your healt is {studentAtTheLastRow.health}");

            // 8 : Add 120 XP to the studentAtTheLastRow
            //          Check if the XP > 200, if yes, call the LevelUp method and the ResetXP method on the studentAtTheLastRow
            //          Write the Level and XP of the studentAtTheLastRow to the console
            studentAtTheLastRow.GainXP(120);
            if(studentAtTheLastRow.xp > 200)
            {
                studentAtTheLastRow.LevelUp();
            }
			Console.WriteLine($"Your level is {studentAtTheLastRow.level} and your XP is {studentAtTheLastRow.xp}");

            // 9 : Call the TakeDamage method on the studentAtTheLastRow, and pass in 75
            //          Write the Health of the studentAtTheLastRow to the console
            //          Check if the studentAtTheLastRow is dead, if yes, write "Your Dead!" to the console
            studentAtTheLastRow.TakeDamage(75);
			Console.WriteLine($"Your healt is {studentAtTheLastRow.health}");

			if(studentAtTheLastRow.IsDead())
				Console.WriteLine("You're Dead!");

			Console.WriteLine("Tanks for using Start2Game!");

            // The expected output should be:
            // Welcome to Start2Game!
            // Your level is 1 and your XP is 100
            // Your healt is 50
            // Your healt is 70
            // Your level is 2 and your XP is 0
            // Your healt is 0
            // Your Dead!
            // Tanks for using Start2Game!
        }
    }
}
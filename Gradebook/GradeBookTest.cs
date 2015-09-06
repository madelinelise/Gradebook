using System;


//Create a GradeBook object and call its DisplayMessage method.
public class GradeBookTest
{
    // Main method begins program execution
	public static void Main( string[] args )
	{
        // Create a GradeBook object and assign it to myGradeBook (variable??)
        GradeBook myGradeBook = new GradeBook();

        // Prompt for input course name

        Console.WriteLine("Please enter course name: ");

        string nameOfCourse = Console.ReadLine(); // read a line of text and store it as the course name.

        Console.WriteLine();

        myGradeBook.DisplayMessage( nameOfCourse );
        // Call myGradeBook's DisplayMessage Method
       // myGradeBook.DisplayMessage();
	} // End Main
} // End GradeBookTest class

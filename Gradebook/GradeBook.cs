using System;

public class GradeBook
{
    //Display a welcome message to the user.

    public void DisplayMessage(string courseName)
    {
        //Console.WriteLine("Welcome to the Grade Book!");

        Console.WriteLine("Welcome to the grade book for\n{0}!", courseName);
        Console.ReadLine();
    } // end method DisplayMessage

} // end class GradeBook..
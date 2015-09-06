using System;

public class GradeBook
{

    private string courseName; 

    // property to get and set the course name

    public string CourseName
    {
        get
        {
            return courseName;
        } //end get
        set
        {
            courseName = value;
        } //end set
    } // end property CourseName
    
    //Display a welcome message to the user.

    public void DisplayMessage()
    {
        // use property CourseName to get the name of the course

        Console.WriteLine("Welome to the grade book for \n{0}", CourseName);
    }


   /* public void DisplayMessage(string courseName)
    {
        //Console.WriteLine("Welcome to the Grade Book!");

        Console.WriteLine("Welcome to the grade book for\n{0}!", courseName);
        Console.ReadLine();
    } // end method DisplayMessage
       -- Commenting out to do Fig 4.7 */
} // end class GradeBook..
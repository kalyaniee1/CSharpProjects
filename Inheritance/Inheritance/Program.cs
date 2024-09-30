using Inheritance;
using System;
using System.Reflection;

internal class Program
{
    float[] sCGPA = new float[] { 5.5f, 6.6f, 7, 6, 5, 8.5f };
    Student[] student = new Student[5];


    public void AddElement(Student student) { 
        int i = 0;

        if()
    }
    static void Main(string[] args)
    {
        //string fname, lname;
        //DateTime dob;
        //float[] sCGPA=new float[6];
        //Int16 yearEnrollment, yearPassing;
        //Console.WriteLine("Enter student's data:");
        //Console.WriteLine("Enter first name:");
        //fname=Console.ReadLine();
        //Console.WriteLine("Enter last name:");
        //lname = Console.ReadLine();
        //Console.WriteLine("Enter date of birth:");
        //dob = Convert.ToDateTime(Console.ReadLine());
        //Console.WriteLine("Enter semestre wise CGPA:");
        //for (int i = 0; i < 6; i++) {
        //    sCGPA[i] = float.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Enter year of enrollment:");
        //yearEnrollment =Convert.ToInt16(Console.ReadLine());
        //Console.WriteLine("Enter year of passing:");
        //yearpassing = convert.toint16(console.readline());
        
        Program program = new Program();
        program.student[0]=new Student("Kalyaniee", "Raikar", new DateTime(1996, 03, 28), program.sCGPA,2020,2023);
        program.student[1] = new Student("Kanchan", "Taksale", new DateTime(1997, 01, 20), program.sCGPA, 2020, 2023);
        program.student[2] = new Student("Vaishali", "Deshmukh", new DateTime(1998, 04, 10), program.sCGPA, 2021, 2024);
        program.student[3] = new Student("Ashwini", "Koyande", new DateTime(1970, 03, 08), program.sCGPA, 2000, 2003);
        program.student[4] = new Student("Umesh", "Koyande", new DateTime(1968, 04, 17), program.sCGPA, 1997, 2000);
        //student.DisplayData();
    }
}




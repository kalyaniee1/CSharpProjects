using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student
    {
        string firstName, lastName, fullName;
        DateTime DoB;
        float[] semCGPA;
        float finalCGPA = 0.0F;
        string[] semGrades = new string[6];
        char finalGrade;
        int age, numberOfYearsToGraduate;
        Int16 yearOfEnrollment, yearOfPassing;

        public Student(string firstName, string lastName, DateTime DoB, float[] semCGPA, Int16 yearOfEnrollment, Int16 yearOfPassing)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.DoB = DoB;
            this.semCGPA = semCGPA;
            this.yearOfEnrollment = yearOfEnrollment;
            this.yearOfPassing = yearOfPassing;
            setValues(this);
        }

        public static void setValues(Student student)
        {
            student.fullName = student.firstName + " " + student.lastName;
            student.age = DateTime.Now.Year - student.DoB.Year;
            student.numberOfYearsToGraduate = student.yearOfPassing - student.yearOfEnrollment;
            for (int i = 0; i < 6; i++)
            {
                if (student.semCGPA[i] < 2)
                    student.semGrades[i] = "F";
                else if (student.semCGPA[i] >= 2 && student.semCGPA[i] < 3.5)
                    student.semGrades[i] = "D";
                else if (student.semCGPA[i] >= 3.5 && student.semCGPA[i] < 4.5)
                    student.semGrades[i] = "C";
                else if (student.semCGPA[i] >= 4.5 && student.semCGPA[i] < 6)
                    student.semGrades[i] = "B";
                else if (student.semCGPA[i] >= 6 && student.semCGPA[i] <= 7)
                    student.semGrades[i] = "A";
            }

            for (int i = 0; i < student.semCGPA.Length; i++) { student.finalCGPA = (student.finalCGPA + student.semCGPA[i]); }
            student.finalCGPA = student.finalCGPA / 6;

            if (student.finalCGPA < 2)
                student.finalGrade = 'F';
            else if (student.finalCGPA >= 2 && student.finalCGPA < 3)
                student.finalGrade = 'D';
            else if (student.finalCGPA >= 3 && student.finalCGPA < 4)
                student.finalGrade = 'C';
            else if (student.finalCGPA >= 4 && student.finalCGPA < 5)
                student.finalGrade = 'B';
            else if (student.finalCGPA >= 5 && student.finalCGPA < 6)
                student.finalGrade = 'A';
            else if (student.finalCGPA >= 6 && student.finalCGPA <= 7)
                student.finalGrade = 'O';
            Console.WriteLine(student);
        }

         public override string ToString()
         {
             return "name:" + fullName+ "\n Age:" + age+ "\n Number of years to pass:" + numberOfYearsToGraduate+"\n Final CGPA:"+finalCGPA+"\n Final Grade"+finalGrade;

         }

        public void DeleteStudent(string fullName) {
        
        }

        /*
         public string FirstName
         {
             set { firstName = value; }
             get { return firstName; }
         }

         public string LastName
         {
             set { lastName = value; }
             get { return lastName; }
         }
         public string FullName
         {
             get
             {
                 fullName = firstName + " " + lastName;
                 return fullName;
             }
         }

         public DateTime DOB
         {
             set { DoB = value; }
             get { return DoB; }
         }
         public int Age
         {
             get
             {
                 age = DateTime.Now.Year - DoB.Year;
                 return age;
             }
         }
         public Int16 YearOfEnrollment
         {
             set { yearOfEnrollment = value; }
             get { return yearOfEnrollment; }
         }
         public Int16 YearOfPassing
         {
             set { yearOfPassing = value; }
             get { return yearOfPassing; }
         }
         public int NoOfYearsOfGraduation
         {
             get
             {
                 numberOfYearsToGraduate = yearOfPassing - yearOfEnrollment;
                 return numberOfYearsToGraduate;
             }
         }
         public float[] SemCGPA
         {
             set { semCGPA = value; }
             get { return semCGPA; }
         }
         public string[] SemGrades
         {
             get
             {
                 for (int i = 0; i < 6; i++)
                 {
                     if (semCGPA[i] < 2)
                         semGrades[i] = "F";
                     else if (semCGPA[i] >= 2 && semCGPA[i] < 3.5)
                         semGrades[i] = "D";
                     else if (semCGPA[i] >= 3.5 && semCGPA[i] < 4.5)
                         semGrades[i] = "C";
                     else if (semCGPA[i] >= 4.5 && semCGPA[i] < 6)
                         semGrades[i] = "B";
                     else if (semCGPA[i] >= 6 && semCGPA[i] <= 7)
                         semGrades[i] = "A";
                 }

                 return semGrades;
             }
         }

         public float FinalCGPA
         {
             get
             {
                 for (int i = 0; i < semCGPA.Length; i++) { finalCGPA = (finalCGPA + semCGPA[i]); }
                 finalCGPA = finalCGPA / 6;
                 return finalCGPA;
             }
         }
         public char FinalGrade
         {
             get
             {
                 if (finalCGPA < 2)
                     finalGrade = 'F';
                 else if (finalCGPA >= 2 && finalCGPA < 3)
                     finalGrade = 'D';
                 else if (finalCGPA >= 3 && finalCGPA < 4)
                     finalGrade = 'C';
                 else if (finalCGPA >= 4 && finalCGPA < 5)
                     finalGrade = 'B';
                 else if (finalCGPA >= 5 && finalCGPA < 6)
                     finalGrade = 'A';
                 else if (finalCGPA >= 6 && finalCGPA <= 7)
                     finalGrade = 'O';
                 return finalGrade;
             }

         }*/



       /* public void DisplayData()
        {

            Console.WriteLine("Student Data:");
            Console.WriteLine("Full name:" + fullName);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Number of years to pass:" + noOfYearsOfGraduation);
            Console.WriteLine("Final CGPA:" + finalCGPA);
            foreach (string i in semGrades)
            {
                Console.WriteLine("grade : " + i);
            }
            Console.WriteLine("Final grade:" + FinalGrade);
        }*/
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student
    {
        string firstName, lastName, fullName;
        DateTime DoB;
        float[] semCGPA;
        float finalCGPA = 0.0F;
        string[] semGrades = new string[6];
        char finalGrade;
        int age, numberOfYearsToGraduate;
        Int16 yearOfEnrollment, yearOfPassing;

        public Student(string firstName, string lastName, DateTime DoB, float[] semCGPA, Int16 yearOfEnrollment, Int16 yearOfPassing)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.DoB = DoB;
            this.semCGPA = semCGPA;
            this.yearOfEnrollment = yearOfEnrollment;
            this.yearOfPassing = yearOfPassing;
            setValues(this);
        }

        public static void setValues(Student student)
        {
            student.fullName = student.firstName + " " + student.lastName;
            student.age = DateTime.Now.Year - student.DoB.Year;
            student.numberOfYearsToGraduate = student.yearOfPassing - student.yearOfEnrollment;
            for (int i = 0; i < 6; i++)
            {
                if (student.semCGPA[i] < 2)
                    student.semGrades[i] = "F";
                else if (student.semCGPA[i] >= 2 && student.semCGPA[i] < 3.5)
                    student.semGrades[i] = "D";
                else if (student.semCGPA[i] >= 3.5 && student.semCGPA[i] < 4.5)
                    student.semGrades[i] = "C";
                else if (student.semCGPA[i] >= 4.5 && student.semCGPA[i] < 6)
                    student.semGrades[i] = "B";
                else if (student.semCGPA[i] >= 6 && student.semCGPA[i] <= 7)
                    student.semGrades[i] = "A";
            }

            for (int i = 0; i < student.semCGPA.Length; i++) { student.finalCGPA = (student.finalCGPA + student.semCGPA[i]); }
            student.finalCGPA = student.finalCGPA / 6;

            if (student.finalCGPA < 2)
                student.finalGrade = 'F';
            else if (student.finalCGPA >= 2 && student.finalCGPA < 3)
                student.finalGrade = 'D';
            else if (student.finalCGPA >= 3 && student.finalCGPA < 4)
                student.finalGrade = 'C';
            else if (student.finalCGPA >= 4 && student.finalCGPA < 5)
                student.finalGrade = 'B';
            else if (student.finalCGPA >= 5 && student.finalCGPA < 6)
                student.finalGrade = 'A';
            else if (student.finalCGPA >= 6 && student.finalCGPA <= 7)
                student.finalGrade = 'O';
            Console.WriteLine(student);
        }

         public override string ToString()
         {
             return "name:" + fullName+ "\n Age:" + age+ "\n Number of years to pass:" + numberOfYearsToGraduate+"\n Final CGPA:"+finalCGPA+"\n Final Grade"+finalGrade;

         }

        public void DeleteStudent(string fullName) {
        
        }

        /*
         public string FirstName
         {
             set { firstName = value; }
             get { return firstName; }
         }

         public string LastName
         {
             set { lastName = value; }
             get { return lastName; }
         }
         public string FullName
         {
             get
             {
                 fullName = firstName + " " + lastName;
                 return fullName;
             }
         }

         public DateTime DOB
         {
             set { DoB = value; }
             get { return DoB; }
         }
         public int Age
         {
             get
             {
                 age = DateTime.Now.Year - DoB.Year;
                 return age;
             }
         }
         public Int16 YearOfEnrollment
         {
             set { yearOfEnrollment = value; }
             get { return yearOfEnrollment; }
         }
         public Int16 YearOfPassing
         {
             set { yearOfPassing = value; }
             get { return yearOfPassing; }
         }
         public int NoOfYearsOfGraduation
         {
             get
             {
                 numberOfYearsToGraduate = yearOfPassing - yearOfEnrollment;
                 return numberOfYearsToGraduate;
             }
         }
         public float[] SemCGPA
         {
             set { semCGPA = value; }
             get { return semCGPA; }
         }
         public string[] SemGrades
         {
             get
             {
                 for (int i = 0; i < 6; i++)
                 {
                     if (semCGPA[i] < 2)
                         semGrades[i] = "F";
                     else if (semCGPA[i] >= 2 && semCGPA[i] < 3.5)
                         semGrades[i] = "D";
                     else if (semCGPA[i] >= 3.5 && semCGPA[i] < 4.5)
                         semGrades[i] = "C";
                     else if (semCGPA[i] >= 4.5 && semCGPA[i] < 6)
                         semGrades[i] = "B";
                     else if (semCGPA[i] >= 6 && semCGPA[i] <= 7)
                         semGrades[i] = "A";
                 }

                 return semGrades;
             }
         }

         public float FinalCGPA
         {
             get
             {
                 for (int i = 0; i < semCGPA.Length; i++) { finalCGPA = (finalCGPA + semCGPA[i]); }
                 finalCGPA = finalCGPA / 6;
                 return finalCGPA;
             }
         }
         public char FinalGrade
         {
             get
             {
                 if (finalCGPA < 2)
                     finalGrade = 'F';
                 else if (finalCGPA >= 2 && finalCGPA < 3)
                     finalGrade = 'D';
                 else if (finalCGPA >= 3 && finalCGPA < 4)
                     finalGrade = 'C';
                 else if (finalCGPA >= 4 && finalCGPA < 5)
                     finalGrade = 'B';
                 else if (finalCGPA >= 5 && finalCGPA < 6)
                     finalGrade = 'A';
                 else if (finalCGPA >= 6 && finalCGPA <= 7)
                     finalGrade = 'O';
                 return finalGrade;
             }

         }*/



       /* public void DisplayData()
        {

            Console.WriteLine("Student Data:");
            Console.WriteLine("Full name:" + fullName);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Number of years to pass:" + noOfYearsOfGraduation);
            Console.WriteLine("Final CGPA:" + finalCGPA);
            foreach (string i in semGrades)
            {
                Console.WriteLine("grade : " + i);
            }
            Console.WriteLine("Final grade:" + FinalGrade);
        }*/
    }
}

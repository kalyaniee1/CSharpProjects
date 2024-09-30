using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = new int[5];
        int largest,secondLargest;
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = Convert.ToInt32(Console.ReadLine());

        }

        largest = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i]>largest)
                largest = inputArray[i];
            }
        Console.WriteLine("Largest element:"+largest);

        secondLargest = inputArray[0];
        for (int i = 0; i < inputArray.Length; i++)
        {
            //if (secondLargest == largest) { }
            //continue;
            //else
            if (inputArray[i] != largest && inputArray[i] > secondLargest)
                secondLargest = inputArray[i];
        }
        Console.WriteLine("Second largest element:"+secondLargest);



    }
    }



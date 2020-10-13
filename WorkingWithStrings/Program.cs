using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life"; //Back slash inside to keep the quotation marks
            //string myString = "What if I need a\new line?"; //To make the line go to a new line
            //string myString = "Go to your c:\\ drive"; //When you actaully want to use the back slash character or this:
            //string myString = @"Go to your c:\\ drive";
            //string myString = String.Format("{1} = {0}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45); //Corrct format for currencies
            //string myString = string.Format("{0:N}", 1234567890); //Correct format for numbers with commas
            //string myString = string.Format("{0:P}", .123);  //Percentage 
            //string myString = string.Format("Phone Number: {0: (###) ###-####}", 123456789123); //Custom formatting. The formatting goes from right to left. 

            //Manipulating strings in a meaningful way

            //string myString = " That Summer we took threes across the board  ";

            //myString = myString.Substring(6, 14);  //Grabs from the 6th characters to the next 14
            //myString = myString.ToUpper(); //Makes the string uppercase
            //myString = myString.Replace(" ", "--"); //Replace the whitespce with --
            //myString = myString.Remove(6, 14); //Remove 6th to 14th character
            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length); //This trims off the before and after spaces


            //When there is going to be a lot of string manipulation, do this instead: 

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i<100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}


using System;

namespace _11th
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Aman Patil";
            String phoneNumber = "876-742-6853";

            // Cases
            //fullName = fullName.ToUpper();                                        // Upper case =  Variable-Name.ToUpper();
            //fullName = fullName.ToLower();                                        // Lower case = Variable-Name.ToLower();
            //Console.WriteLine(fullName);

            // Replace Method
            //phoneNumber = phoneNumber.Replace("-", "");              // Variable-Name.Replace("number to replace", "New number");
            //Console.WriteLine(phoneNumber);

            // Insert Method
            //String userName = fullName.Insert(0, "Mr.");                   // Variable-Name.Insert(distance_to_be_displayed, "character");
            //Console.WriteLine(userName);

            // Length Method
            //Console.WriteLine(fullName.Length);                                // Console.WriteLine(Variable-Name.Length);

            // SubString
            String firstName = fullName.Substring(0, 4);                       // Variable-Name.Substring(starting_character, ending_character);
            Console.WriteLine(firstName);

            Console.ReadKey();
        }
    }
}
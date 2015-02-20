using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            //dating site - user enters sex, height, eye color  1 = blue 2=green 3=brown 4=black, hair color 1=white 2=blonde 3=red 4-brown 5=grey 6=black. Relationship status c v d or m. Do they like music yes or no. Do they like taking walks 
            //outside ask for age. Their weight. How many kid they have. If they like sports yes or no. Do they like travenling. Yes or No.Say if the user can be associated to a profile. Profile number one - looking for men v or d maximum of one kid
            //profile number 2 - looking for a girl c between 25 and 30 years old - blue eyes - dark hair. Likes music or sports or music and sports height between 5-6 feet. profile number 3 - looking for a women less than 25 years old if c less than 30 years old if v or d no kids that likes sports
            //has red hair with green eyes or brown hair with brown eyes.

            string gender, eyecolor, haircolor, relationship, music, walks, traveling, sports;
            double height, weight;
            int kids, age;
            bool verification; 


            Console.WriteLine("What is your gender?");
            gender = Console.ReadLine();

            do
            {
                Console.WriteLine("How tall are you?");
                verification = double.TryParse(Console.ReadLine(), out height);
            }
            while (verification == false);

            Console.WriteLine("What is your eye color?");
            Console.WriteLine("Blue=1\nGreen=2\nBrown=3\nBlack=4");
            eyecolor = Console.ReadLine();

            do
            {
                Console.WriteLine("What is your haircolor? (white, blonde, red, brown, grey, black");
                haircolor = Console.ReadLine();
            } while (haircolor != "black" || haircolor != "white" || haircolor != "blonde" || haircolor != "red" || haircolor != "brown" || haircolor != "brown" || haircolor != "grey");

            Console.WriteLine("What is your relationship status?\nC\nV\nd\nm");
            relationship = Console.ReadLine();

            Console.WriteLine("Do you like music?");
            music = Console.ReadLine();

            Console.WriteLine("Do you like long walks on the beach?");
            walks = Console.ReadLine();

            do
            {
                Console.WriteLine("What is your weight?");
                verification = double.TryParse(Console.ReadLine(), out weight);
            }
            while (verification == false);

            do
            {
                Console.WriteLine("What is your age?");
                verification = int.TryParse(Console.ReadLine(), out age);
            }
            while (verification == false);

            do
            {
                Console.WriteLine("How many kids do you have?");
                verification = int.TryParse(Console.ReadLine(), out kids);

            }
            while (verification == false);

            Console.WriteLine("Do you like traveling?");
            traveling = Console.ReadLine();

            Console.WriteLine("Do you like sports?");
            sports = Console.ReadLine();


            //Comparing 

            if ((relationship == "v" || relationship == "V" || relationship == "d" || relationship == "D") && kids == 1)
                Console.WriteLine("You are matched with profile 1!");

            if ((gender == "female" || gender == "Female" || gender == "girl" || gender == "Girl") && (relationship == "c" || relationship == "C") && (age >= 25 || age <= 30) && (eyecolor == "1") && (haircolor == "dark" || haircolor == "black" || haircolor == "Black" ) )
                Console.WriteLine("You are matched with profile 2!");
            Console.ReadLine();
            
        }
    }
}

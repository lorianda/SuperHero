using System.Collections;

using System;
/*
-Create variables:
-Hero name - String
- Hero age - int
- Hero powers - heroPower1, heroPower2, heroPower3
- Create "Hero Card" view.Print variables to console
*/

string age = "33";
string name = "lori";
string powers1 = "goodheart";
string powers2 = "nice";
string powers3 = "strongbeliever";
Console.WriteLine(name);
Console.WriteLine("HelloWorld");
Console.WriteLine("*************************************************");

Console.WriteLine("Printing " + name + " Card:");

Console.WriteLine("*************************************************");

Console.WriteLine("Name is: " + name);

Console.WriteLine("Age is: " + age);

Console.WriteLine("Powers are: " + "(" + powers1 + ")" + " " + "(" + powers2 + ")" + " " + "(" + powers3 + ")");

Console.WriteLine("*************************************************");
{
    int deedTimeInHours1 = 20;
    int deedTimeHours2 = 30;
    int deedTimeHours3 = 40;

    int totalTime = deedTimeInHours1 + deedTimeHours2 + deedTimeHours3;
    Console.WriteLine("Total time spent " + totalTime);

    int averagetime = totalTime / 3;
    Console.WriteLine("Average time spent" + averagetime);

    int numbercookies = totalTime * 5;
    Console.WriteLine("Number of cookies" + numbercookies);
}
int repeat = 0;

var myList = new ArrayList();
myList.Add("1");
myList.Add("lori");
myList.Add("33");
myList.Add("goodheart");
myList.Add("nice");
myList.Add("strongbeliever");

do
{
    Console.WriteLine("Select different parts of superhero card operations:");
    Console.WriteLine("1- A List of superheroes");
    Console.WriteLine("2- Add a new superohero");
    Console.WriteLine("3- Showing a specific superhero information");
    Console.WriteLine("4- Delete the superhero from the list");
    Console.WriteLine("5- Quit");

    string answer = Console.ReadLine();

    switch (answer)
    {
        case "1":
            Console.WriteLine("List of superheros:");
            foreach (var item in myList)
                Console.WriteLine(item + ", ");
            break;
        case "2":
            Console.WriteLine("Enter SuperHero ID:");
            string id = Console.ReadLine();
            myList.Add(id);
            Console.WriteLine("Enter SuperHero Name:");
            name = Console.ReadLine();
            myList.Add(name);
            Console.WriteLine("Enter SuperHero Age:");
            age = Console.ReadLine();
            myList.Add(age);
            Console.WriteLine("Enter SuperHero Power1:");
            string power1 = Console.ReadLine();
            myList.Add(power1);
            Console.WriteLine("Enter SuperHero Power2:");
            string power2 = Console.ReadLine();
            myList.Add(power2);
            Console.WriteLine("Enter SuperHero Power3:");
            string power3 = Console.ReadLine();
            myList.Add(power3);
            Console.WriteLine("Added successfully");
            break;
        case "3":
            Console.WriteLine("Enter superhero ID to display");
            string ans = Console.ReadLine();
            int ansInt = myList.IndexOf(ans);
            for (int x = ansInt; x < ansInt + 6; x++)
                Console.WriteLine(myList[x] + ",");
            break;
        case "4":
            Console.WriteLine("Enter superhero ID to remove");
            string ans1 = Console.ReadLine();
            int ansInt2 = myList.IndexOf(ans1);
            myList.RemoveRange(ansInt2, 5);
            Console.WriteLine("Removed successfully");
            break;
        case "5":
            repeat = 1;
            break;
        default:
            Console.WriteLine("Error Choose another selection");
            break;
    }
} while (repeat != 1);


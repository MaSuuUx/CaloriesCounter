using System.Transactions;

class Program
{
    const double sedentary = 1.2;
    const double littleAct = 1.375;
    const double moderateAct = 1.55;
    const double intenseAct = 1.725;
    const double athlete = 1.9;

    static void Main(string[] args)
    {
        bool goOut = false;

        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine("Calories Calculator by MaSuuU");
        Console.WriteLine("----------------------------------------------------------------------------------");

        do
        {
            Console.WriteLine("Do you want to know how many calories your body needs each day?  Y/N");
            string opt = Console.ReadLine().ToUpper();

            switch (opt) 
            {
                case "Y":
                    Console.Clear();
                    Gender();
                    break;
                case "N":
                    goOut = true;
                    break;
                default:
                    
                    break;
            }
        } while (!goOut);
    }

    static void Gender()
    {
            Console.WriteLine("What is your gender? \n1. Woman \n2. Man");
            int opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Clear();
                    Woman();
                    break;
                case 2:
                    Console.Clear();
                    Man();
                    break;
                default:
                    Console.WriteLine("Invalid option....");
                    break;
            }
    }
    static void Woman()
    {

        Console.WriteLine("----------------------------------------------------------------------------------");

        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your weight in kg (Kilograms)");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your height in cm (Centimeters)");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your age");
        double age = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your level of physical activity? \n1. Sedentary \n2. Little activity (1-3 times per week) \n3. Moderate Activity (3-5 times per week) \n4. Intense Activity (6-7 times per week) \n5. Athlete (Workouts of more than 4 hours a day)");
        int opt = Int32.Parse(Console.ReadLine());

        double physicalAct;
        switch (opt)
        {
            case 1:
                physicalAct = sedentary;
                break;
            case 2:
                physicalAct = littleAct;
                break;
            case 3:
                physicalAct = moderateAct;
                break;
            case 4:
                physicalAct = intenseAct;
                break;
            case 5:
                physicalAct = athlete;
                break;
            default:
                Console.WriteLine("Invalid option....");
                return; 
        }

        double result = (65 + (9.6 * weight) + (1.8 * height) - (4.7 * age)) * physicalAct;

        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine($"{name} the necessary calories that you should consume each day is : {result} kcal");
        Console.WriteLine("----------------------------------------------------------------------------------");
    }

    static void Man()
    {
        Console.WriteLine("----------------------------------------------------------------------------------");

        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your weight in kg (Kilograms)");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your height in cm (Centimeters)");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your age");
        double age = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your level of physical activity? \n1. Sedentary \n2. Little activity (1-3 times per week) \n3. Moderate Activity (3-5 times per week) \n4. Intense Activity (6-7 times per week) \n5. Athlete (Workouts of more than 4 hours a day)");
        int opt = Int32.Parse(Console.ReadLine());

        double physicalAct;
        switch (opt)
        {
            case 1:
                physicalAct = sedentary;
                break;
            case 2:
                physicalAct = littleAct;
                break;
            case 3:
                physicalAct = moderateAct;
                break;
            case 4:
                physicalAct = intenseAct;
                break;
            case 5:
                physicalAct = athlete;
                break;
            default:
                Console.WriteLine("Invalid option....");
                return;
        }

        double result = (66 + (13.7 * weight) + (5 * height) - (6.8* age)) * physicalAct;
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine($"{name} the necessary calories that you should consume each day is : {result} kcal");
        Console.WriteLine("----------------------------------------------------------------------------------");
    }

}
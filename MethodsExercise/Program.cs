namespace MethodsExercise
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

            static void Main(string[] args)
        {
            var amountOfBrothers = Sum(2, 3);
            var bankAccounts = Multiply(100, 20, 30);

            //-------Exercise 1--------//

            Console.WriteLine("Hi new user, may I know your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {userName}, I dont have a name but my creator is Liam Torres I would love to know a bit more about you so which color do you consider your favorite?");
            var color = Console.ReadLine();

            Console.WriteLine($"Interesting choice, {color} is one of my favorites too. By any chance do you have any pets in your household? If so, what type of pets do you have?");
            var pets = Console.ReadLine();

            Console.WriteLine($"Those type of {pets} are amazing. Unfortunatly I dont have any pets because I'm just a computer app. What I'm able to enjoy is different types of genres of music. My favorite genre is Reggae music, what is yours?");
            var music = Console.ReadLine();

            Console.WriteLine($"Hey! That's epic you have a great taste in music {userName}. {music} is a genre that shouldn't be missing in my creator's playlist.");

            Console.WriteLine($"Thank you so much {userName} for participating and creating a profile. Press ENTER to view your profile.");

            Console.WriteLine("---------------------");

            Console.WriteLine($"Username - {userName}");
            Console.WriteLine($"Favorite Color - {color}");
            Console.WriteLine($"My Pets - {pets}");
            Console.WriteLine($"My Music - {music}");

        }
    }

}




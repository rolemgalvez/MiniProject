namespace GuestBook
{
    public class Manage
    {
        public static List<string> Parties = new List<string>();
        public static Dictionary<string, int> Guest = new Dictionary<string, int>();

        public static void PrintList()
        {
            Console.WriteLine();
            Console.WriteLine("NAME\t : MEMBERS ");

            if (Parties.Count == 0)
            {
                Console.WriteLine("-\t : -");
            }

            foreach (string party in Parties)
            {
                Console.WriteLine($"{party}\t : {Guest[party]}");
            }
        }

        public static void PrintTotal()
        {
            int total = 0;

            foreach (string party in Parties)
            {
                total += Guest[party];
            }

            Console.WriteLine( "------------------");
            Console.WriteLine($"TOTAL\t : {total}");
            Console.WriteLine();
        }

        public static void PrintGuest()
        {
            PrintList();
            PrintTotal();
        }

        public static bool GetInput()
        {
            int choice = GetChoice();
            bool output = choice switch
            {
                0 => InvalidInput(),
                2 => AddGuest(),
                _ => false,
            };

            return output;
        }

        private static bool InvalidInput()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. Try again.");
            Console.WriteLine();

            return true;
        }

        private static bool AddGuest()
        {
            (string name, int members) = GetParty();
            SaveParty(name, members);

            return true;
        }

        private static void SaveParty(string name, int members)
        {
            Parties.Add(name);
            Guest[name] = members;
        }

        private static (string name, int members) GetParty()
        {
            string name = GetName();
            int members = GetMembers();

            (string, int) output = (name, members);

            return output;
        }

        public static string GetName()
        {
            string output;

            bool getAgain;
            do
            {
                getAgain = false;
                Console.Write("Enter party name: ");
                output = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(output))
                {
                    Console.WriteLine("Name should NOT be empty. Try again.");
                    getAgain = true;
                }
            } while (getAgain);

            return output;
        }

        public static int GetMembers()
        {
            int output;

            bool getAgain;
            do
            {
                getAgain = false;
                Console.Write("Enter how many are you in the party: ");
                _ = int.TryParse(Console.ReadLine(), out output);

                if (output <= 0)
                {
                    Console.WriteLine("Value should be greater than 0. Try again.");
                    getAgain = true;
                }
            } while (getAgain);

            return output;
        }

        public static int GetChoice()
        {
            Console.Write("[1] Exit [2] Add: ");
            string? input = Console.ReadLine();
            _ = int.TryParse(input, out int output);

            return output;
        }
    }
}

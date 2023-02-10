namespace GuestBook
{
    public class Section
    {
        public static void Welcome()
        {
            Console.WriteLine("Guest Book");
            Console.WriteLine("----------");
        }

        public static void Core()
        {
            bool runAgain;

            do
            {
                Manage.PrintGuest();
                runAgain = Manage.GetInput();

            } while (runAgain);
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}

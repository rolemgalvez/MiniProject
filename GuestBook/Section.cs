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
            Manage.PrintGuest();

            bool runAgain;
            do
            {
                runAgain = Manage.GetInput();

            } while (runAgain);
        }
    }
}

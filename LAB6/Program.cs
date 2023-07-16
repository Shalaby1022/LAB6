namespace LAB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of question:");
            Console.WriteLine("1. MCQ Question");
            Console.WriteLine("2. True or False Question");
            Console.Write("Enter the number of your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }

            switch (choice)
            {
                case 1:
                    MCQQuestion mcq1 = new MCQQuestion(1, "What is the current ITI campus where you are attending your summer training?", 5, new string[] { "Menoufia", "Alex", "Cairo", "Smart Village" });
                    mcq1.Show();
                    break;
                case 2:
                    TorFQuestion tf1 = new TorFQuestion(1, "The sun rises in the west.", 2);
                    tf1.Show();
                    break;
            }
        }

    }
}

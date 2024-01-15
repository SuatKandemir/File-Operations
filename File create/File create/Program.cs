

namespace FileManagementApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select the action you want to take ");
            Console.WriteLine("1 - File Create");
            Console.WriteLine("2 - File Reading ");
            Console.WriteLine("3 - Flie Writing");
            Console.WriteLine("4 - File Remove");
            Console.WriteLine("5 - Exsit");

            Console.WriteLine("Please make your selection ");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise) 
            {
                case 1:
                    FileManagements.CreateFile();
                    break;
                case 2:
                    FileManagements.FileReading();
                    break;

                case 3:
                    FileManagements.FileWriting();
                    break;

                case 4:
                    FileManagements.FileDelete();
                    break;

                default:
                    Console.WriteLine("false value please again");
                    break;

            }

        }

    }
}
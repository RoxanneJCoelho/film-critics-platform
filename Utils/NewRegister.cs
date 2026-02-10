// New Register's Functions

namespace Film_Critics_Platform.Utils
{
    public class NewRegister
    {
         public static void ValidName()
        {
            string name;
            int attempts = 3;
            
            while (attempts > 0)
            {
                bool isValid = true;

                Console.Write("Name (print C to cancel): ");
                name = (Console.ReadLine() ?? "").Trim();

                if (name.ToUpper() == "C")
                {
                    Console.WriteLine("Cancelled operation");
                    return;
                }

                else if (name.Trim() == "")
                {
                    attempts--;
                    Console.WriteLine($"Please introduce a valid name. Now, you have {attempts} attempts");
                    continue;
                }

                foreach (char c in name)
                {
                    if (!char.IsLetter(c) && c!=' ')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    attempts--;
                    Console.WriteLine($"Please introduce only letters and spaces. Now you have {attempts} attempts");
                    continue;
                }

                Console.WriteLine($"Name accepted. Hello {name} !");
                return;

            }

            Console.WriteLine("Operation canceled due to excessive attempts.");
            return;
        }
    public static void ValidContact()
        {
            
        }
    }
}
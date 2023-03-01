    class Program
    {
        static void Main(string[] args) {
           
            Console.Write("Please Input password: ");
            string password = Console.ReadLine();


            Console.Write("Please Input CIA,FBI,NSA: ");
            string agency = Console.ReadLine();

            bool isPasswordValid = false;
            if (password.Length == 6 && int.TryParse(password, out int passwordNum))
            {
                if (agency == "CIA")
                {
                    int lastDigit = passwordNum % 10;
                    int tensDigit = (passwordNum / 10) % 10;
                    int thousandsDigit = (passwordNum / 1000) % 10;

                    if (lastDigit % 3 == 0 && tensDigit != 1 && tensDigit != 3 && tensDigit != 5 && thousandsDigit >= 6 && thousandsDigit != 8)
                    {
                        isPasswordValid = true;
                    }
                }
                else if (agency == "FBI")
                {
                    
                    int hundredThousandDigit = (passwordNum / 100000) % 10;
                    int tensDigit = (passwordNum / 100) % 10;
                    int thousandsDigit = (passwordNum / 1000) % 10;

                    if (hundredThousandDigit >= 4 && hundredThousandDigit <= 7 && tensDigit % 2 == 0 && tensDigit != 6 && thousandsDigit % 2 == 1)
                    {
                        isPasswordValid = true;
                    }
                }
                else if (agency == "NSA")
                {
                    
                    int lastDigit = passwordNum % 10;
                    int hundredDigit = (passwordNum / 100) % 10;
                    int thousandsDigit = (passwordNum / 1000) % 10;

                    if (lastDigit % 2 != 0 && lastDigit * hundredDigit * lastDigit == 30 && hundredDigit % 3 == 0 && thousandsDigit >= 1 && passwordNum.ToString().Contains("7"))
                    {
                        isPasswordValid = true;
                    }
                }
            }

            
            if (isPasswordValid)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }


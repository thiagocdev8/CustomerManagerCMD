namespace CustomerManager
{
    class CustomerManager
    {


        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }
        static void Main(string[] args)
        {
            bool isRunning = false;

            Console.WriteLine("Customer/Client Manager 8.0 - Welcome!");
            Console.WriteLine("Developed by SolarX!");
            Console.WriteLine("");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1 - Customer List\n2-Add Customer\n3-Remove Customer\n4-Exit");

            int option = int.Parse(Console.ReadLine());


            while (!isRunning)
            {
                switch (option)
                {
                    case (int)Menu.Listagem:
                        Console.WriteLine("You selected List Customers.");
                        // Call method to list customers
                        break;
                    case (int)Menu.Adicionar:
                        Console.WriteLine("You selected Add Customer.");
                        // Call method to add a customer
                        break;
                    case (int)Menu.Remover:
                        Console.WriteLine("You selected Remove Customer.");
                        // Call method to remove a customer
                        break;
                    case (int)Menu.Sair:
                        Console.WriteLine("Exiting the application. Goodbye!");
                        isRunning = true;
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            

            Console.WriteLine("Press any key to exit...");



        }
    }
}

namespace CustomerManager
{
    class CustomerManager
    {

        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;

          
        }

        static List<Cliente> clientes = new List<Cliente>();
        
        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }

        static void Main(string[] args)
        {
            bool isRunning = false;

            Console.WriteLine("Customer/Client Manager 8.0 - Welcome!");
            Console.WriteLine("Developed by SolarX!");
            Console.WriteLine("");
     

            while (!isRunning)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - Customer List\n2 - Add Customer\n3 - Remove Customer\n4 - Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case (int)Menu.Listagem:
                        
                        break;
                    case (int)Menu.Adicionar:
                        AdicionarCliente();
                        break;
                    case (int)Menu.Remover:
                        
                        break;
                    case (int)Menu.Sair:
                        
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.Clear();
            }

            

            Console.WriteLine("Press any key to exit...");



        }

        static void AdicionarCliente()
        {
            Cliente cliente  = new Cliente();
            Console.WriteLine("Adding a new customer:!");
            Console.WriteLine("Enter customer name: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Enter customer email: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("Enter customer CPF: ");
            cliente.cpf = Console.ReadLine();

            
            clientes.Add(cliente);
            Console.WriteLine("Customer added successfully!");
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
        }
    }
}

namespace CustomerManager
{
    class CustomerManager
    {

        public struct Cliente
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string cpf { get; set; }
        }

        static List<Cliente> clientes = new List<Cliente>();
        
        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }

        public static void AddCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Customer added successfully!");
        }

        public static void RemoveCliente(string nome, string cpf)
        {
            var clienteToRemove = clientes.FirstOrDefault(c => c.cpf == cpf);
            if (clienteToRemove.Equals(default(Cliente)))
            {
                Console.WriteLine("Customer not found.");
                return;
            }
            clientes.Remove(clienteToRemove);
            Console.WriteLine("Customer removed successfully!");
        }

        public static void ListClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return;
            }
            Console.WriteLine("List of Customers:");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Name: {cliente.Nome}, Email: {cliente.Email}, CPF: {cliente.cpf}");
            }
        }

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
                        ListClientes();
                        break;
                    case (int)Menu.Adicionar:
                        Console.WriteLine("You selected Add Customer.");
                        // Call method to add a customer
                        Console.WriteLine("Enter customer name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter customer email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter customer CPF:");
                        string cpf = Console.ReadLine();
                        Cliente newCliente = new Cliente { Nome = name, Email = email, cpf = cpf };
                        AddCliente(newCliente);
                        Console.WriteLine("Customer added successfully!");
                        break;
                    case (int)Menu.Remover:
                        Console.WriteLine("You selected Remove Customer.");
                        // Call method to remove a customer
                        Console.WriteLine("Enter the CPF of the customer to remove:");
                        string cpfToRemove = Console.ReadLine();
                        Console.WriteLine("Enter the name of the customer to remove:");
                        string nameToRemove = Console.ReadLine();
                        RemoveCliente(nameToRemove, cpfToRemove);
                        Console.WriteLine("Customer removed successfully!");
                        break;
                    case (int)Menu.Sair:
                        Console.WriteLine("Exiting the application. Goodbye!");
                        isRunning = true;
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.Clear();
            }

            

            Console.WriteLine("Press any key to exit...");



        }
    }
}

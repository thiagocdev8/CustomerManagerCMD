using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace CustomerManager
{
    class CustomerManager
    {

        
        public class Cliente
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Cpf { get; set; }


            public Cliente()
            {
                Nome = string.Empty;
                Email = string.Empty;
                Cpf = string.Empty;
            }
        }

        static List<Cliente> clientes = new List<Cliente>();
        
        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }

        static void Main(string[] args)
        {
            bool isRunning = false;

            Console.WriteLine("Customer/Client Manager 8.0 - Welcome!");
            Console.WriteLine("Developed by SolarX!");
            Console.WriteLine("");
     
            Carregar();
            while (!isRunning)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - Customer List\n2 - Add Customer\n3 - Remove Customer\n4 - Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case (int)Menu.Listagem:
                        ListarClientes();
                        break;
                    case (int)Menu.Adicionar:
                        AdicionarCliente();
                        Salvar();
                        break;
                    case (int)Menu.Remover:
                        
                        break;
                    case (int)Menu.Sair:
                        Console.WriteLine("Saving data...");
                        Salvar();
                        Console.WriteLine("Exiting the program...");
                        Console.WriteLine("Thank you for using the Customer Manager 8.0!");
                        
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
            Console.WriteLine("Adding a new customer: ");
            Console.WriteLine("Enter customer name: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Enter customer email: ");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("Enter customer CPF: ");
            cliente.Cpf = Console.ReadLine();

            
            clientes.Add(cliente);
            Console.WriteLine("Customer added successfully!");
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
        }

        static void ListarClientes()
        {
            
            if (clientes.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                Console.WriteLine("Customer List:");
                int i = 1; 
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"{i}. Name: {cliente.Nome} | Email: {cliente.Email} | CPF: {cliente.Cpf}");
                    i++;
                }
            }
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
        }

        static void Salvar()
        {

            try

            {

                
                string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("clients.json", json);
                Console.WriteLine("Data saved successfully!");
            }

            catch (Exception ex)

            {

                Console.WriteLine($"Erro ao salvar os dados: {ex.Message}");

            }

        }

        static void Carregar()

        {

            try

            {

                if (File.Exists("clients.json"))

                {

                    string json = File.ReadAllText("clients.json");

                    clientes = JsonSerializer.Deserialize<List<Cliente>>(json);

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine($"Erro ao carregar os dados: {ex.Message}");

            }

        }
    }
}

using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace CustomerManager
{
    class CustomerManager
    {

        
        public class Cliente // Class to represent a customer
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Cpf { get; set; }


            public Cliente() // Default constructor to initialize properties for json serialization
            {
                Nome = string.Empty;
                Email = string.Empty;
                Cpf = string.Empty;
            }
        }

        static List<Cliente> clientes = new List<Cliente>(); // List to store customers in json file

        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 } //menu listing

        static void Main(string[] args)
        {
            bool isRunning = false;

            Console.WriteLine("Customer/Client Manager 8.0 - Welcome!");
            Console.WriteLine("Developed by SolarX!");
            Console.WriteLine("");
     
            Carregar(); //load customers from json file before starting the program
            while (!isRunning)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - Customer List\n2 - Add Customer\n3 - Remove Customer\n4 - Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option) //menu switch case
                {
                    case (int)Menu.Listagem:
                        ListarClientes(); // List customers function
                        Console.WriteLine("Press enter to return");
                        Console.ReadLine();
                        break;
                    case (int)Menu.Adicionar:
                        AdicionarCliente(); //add customer to list function
                        Salvar(); //save customers to json file after adding
                        break;
                    case (int)Menu.Remover:
                        RemoverCliente(); //remove customer from list function
                        Salvar(); //save customers to json file after removing
                        break;
                    case (int)Menu.Sair:
                        Console.WriteLine("Saving data...");
                        Salvar(); //save customers to json file before exiting
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

        static void AdicionarCliente() //add client function
        {
            Cliente cliente  = new Cliente();
            Console.WriteLine("Adding a new customer: ");
            Console.WriteLine("Enter customer name: ");
            cliente.Nome = Console.ReadLine(); //user input for customer name
            Console.WriteLine("Enter customer email: ");
            cliente.Email = Console.ReadLine(); //user input for customer email
            Console.WriteLine("Enter customer CPF: ");
            cliente.Cpf = Console.ReadLine(); //user input for customer CPF


            clientes.Add(cliente); //add customer to list
            Console.WriteLine("Customer added successfully!");
            Console.WriteLine("Press enter to return");
            Console.ReadLine();
        }

        static void ListarClientes()
        {
            
            if (clientes.Count == 0) // Check if the customer list is empty
            {
                Console.WriteLine("No customers found.");
            }
            else //if list is not empty, display customers
            {
                Console.WriteLine("Customer List:");
                int i = 1; 
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"{i}. Name: {cliente.Nome} | Email: {cliente.Email} | CPF: {cliente.Cpf}");
                    i++;
                }
            }
            
        }

        static void Salvar() //save customers to json file function
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

        static void Carregar() //load customers from json file function

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

        static void RemoverCliente() //remove customer from list function
        {
            ListarClientes(); //show list so user can choose which customer to remove
            Console.WriteLine("Enter the index of the customer to remove: ");
            // Convert user input to zero-based index (list starts at 0)
            int index = int.Parse(Console.ReadLine()) - 1; 
            if (index < 0 || index >= clientes.Count) 
            {
                Console.WriteLine("Invalid index. Please try again.");
                Console.WriteLine("Press enter to return");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"Are you sure you want to remove the customer: {clientes[index].Nome}?");
                Console.WriteLine($"1 - Yes\n2 - No");
                int confirm = int.Parse(Console.ReadLine());
                if (confirm == 1) //if user confirms removal
                {
                    clientes.RemoveAt(index);
                    Console.WriteLine("Customer removed successfully!");
                    Console.WriteLine("Press enter to return");
                    Console.ReadLine();
                }
                else if (confirm == 2) //if user does not confirm removal
                {
                    Console.WriteLine("Operation cancelled.");
                    
                    return;
                }
                else //if user inputs an invalid option
                {
                    Console.WriteLine("Invalid option. Operation cancelled.");
                    Console.WriteLine("Press enter to return");
                    Console.ReadLine();
                    return;
                }
               
            }
        }
                
    }
}

using System;
using System.Globalization;

namespace ProjetoLetsCode2
{
    public class Create
    {

        internal static void CreateUser()
        {
            var _name = ReadName();

            var _usernamer = ReadUser();

            var _password = ReadPassword();

            var _dateBirth = ReadBirth();

            var _deliveryAddress = ReadAdress();

            var _bellingAdress = ReadBillingAdress(_deliveryAddress);

            var user = new User
            {
                id = Database.Users.Count + 1,
                name = _name,
                user = _usernamer,
                password = _password,
                birthDate = _dateBirth,
                deliveryAddress = _deliveryAddress,
                billingAddress = _bellingAdress,

            };
        }

        private static Address ReadBillingAdress(Address deliveryAdress)
        {
            Console.Write("Deseja utilizar como endereço de cobrança o mesmo de entrega? ");
            Console.WriteLine(deliveryAdress.address);

            Console.WriteLine("S - SIM, N - NÃO");

            var option = Console.ReadLine();

            if (option == "S")
            {
                return deliveryAdress;
            }
            else
            {
                return ReadAdress();
            }

        }

        internal static void CreateClient()
        {
            var _name = ReadName();

            var _usernamer = ReadUser();

            var _password = ReadPassword();

            var _dateBirth = ReadBirth();

            var _deliveryAddress = ReadAdress();

            var _bellingAdress = ReadBillingAdress(_deliveryAddress);

            var user = new User
            {
                id = Database.Users.Count + 1,
                name = _name,
                user = _usernamer,
                password = _password,
                birthDate = _dateBirth,
                deliveryAddress = _deliveryAddress,
                billingAddress = _bellingAdress,
                isClient = true,

            };

        }

        internal static void CreateSeller()
        {
            var _name = ReadName();

            var _usernamer = ReadUser();

            var _password = ReadPassword();

            var _dateBirth = ReadBirth();

            var _deliveryAddress = ReadAdress();

            var _bellingAdress = ReadBillingAdress(_deliveryAddress);

            var user = new User
            {
                id = Database.Users.Count + 1,
                name = _name,
                user = _usernamer,
                password = _password,
                birthDate = _dateBirth,
                deliveryAddress = _deliveryAddress,
                billingAddress = _bellingAdress,
                isSeller = true,

            };

        }

        private static string ReadName()
        {
            Console.WriteLine("Digite o nome do usuário: ");
            return Console.ReadLine();
        }

        private static string ReadUser()
        {
            Console.WriteLine("Digite o username: ");
            return Console.ReadLine();
        }

        private static string ReadPassword()
        {
            Console.WriteLine("Digite a senha: ");
            return Console.ReadLine();
        }

        private static DateTime ReadBirth()
        {
            Console.WriteLine("Digite a data de nascimento (dd/mm/aaaa): ");
            var entrada = Console.ReadLine();
            return Convert.ToDateTime(entrada, new CultureInfo("pt-br"));
        }

        private static Address ReadAdress()
        {
            Console.WriteLine("Digite a primeira linha do endereço: ");
            var _address = Console.ReadLine();

            Console.WriteLine("Digite a segunda linha do endereço: ");
            var _secondAdress = Console.ReadLine();

            Console.WriteLine("Digite o número: ");
            int.TryParse(Console.ReadLine(), out var _number);

            Console.WriteLine("Digite o CEP do endereço: ");
            var _zip = Console.ReadLine();

            Console.WriteLine("Digite sua cidade: ");
            var _city = Console.ReadLine();

            Console.WriteLine("Digite seu estado: ");
            var _state = Console.ReadLine();

            Console.WriteLine("Digite seu país: ");
            var _country = Console.ReadLine();

            return new Address
            {
                address = _address,
                secondAddress = _secondAdress,
                number = _number,
                zipCode = _zip,
                city = _city,
                state = _state,
                country = _country

            };

        }

    }

}
using System;

namespace ProjetoLetsCode2
{
    public class Menu
    {
        public string GeneralMenu()
        {
            Console.WriteLine("Bem vindo ao sistema de marketplace");
            Console.WriteLine("Observe o menu e escolha o número da opção desejada");
            Console.WriteLine("01 - Cadastrar Novo Usuário");
            Console.WriteLine("02 - Cadastrar Novo Vendedor");
            Console.WriteLine("03 - Cadastrar Novo Cliente");
            Console.WriteLine("04 - Buscar Usuário");
            Console.WriteLine("05 - Buscar Vendedor");
            Console.WriteLine("06 - Buscar Cliente");
            Console.WriteLine("07 - Atualizar dados Usuário");
            Console.WriteLine("08 - Atualizar dados Vendedor");
            Console.WriteLine("09 - Atualizar dados Cliente");
            Console.WriteLine("10 - Deletar dados Usuário");
            Console.WriteLine("11 - Deletar dados Vendedor");
            Console.WriteLine("12 - Deletar dados Cliente");
            Console.WriteLine("13 - Sair");
            Console.Write("Opção: ");
            return Console.ReadLine();
        }

        public void Option(int _option)
        {
            switch (_option)
            {
                case 1:
                    Console.WriteLine("Caso 01");
                    Create.CreateUser();
                    break;
                case 2:
                    Console.WriteLine("Caso 02");
                    Create.CreateSeller();
                    break;
                case 3:
                    Console.WriteLine("Caso 03");
                    Create.CreateClient();
                    break;
                case 4:
                    Console.WriteLine("Caso 04");
                    break;
                case 5:
                    Console.WriteLine("Caso 05");
                    break;
                case 6:
                    Console.WriteLine("Caso 06");
                    break;
                case 7:
                    Console.WriteLine("Caso 07");
                    break;
                case 8:
                    Console.WriteLine("Caso 08");
                    break;
                case 9:
                    Console.WriteLine("Caso 09");
                    break;
                case 10:
                    Console.WriteLine("Caso 10");
                    break;
                case 11:
                    Console.WriteLine("Caso 11");
                    break;
                case 12:
                    Console.WriteLine("Caso 12");
                    break;
                case 13:
                    Console.WriteLine("Caso 13");
                    break;
                default:
                    Console.WriteLine("Opção Inválida, tente novamente");
                    GeneralMenuOption();
                    break;
            }
        }

        public void GeneralMenuOption()
        {
            string _option = GeneralMenu();
            int _optionInt;
            bool _optionToInt = Int32.TryParse(_option, out _optionInt);
            if (_optionToInt)
                Option(_optionInt);
            else
                Option(0);
        }
    }
}
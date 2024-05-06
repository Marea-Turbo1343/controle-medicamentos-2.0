namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal static class TelaPrincipal
    {
        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|       Controle de Medicamentos       |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Controle de Pacientes");
            Console.WriteLine("2 - Controle de Medicamentos");
            Console.WriteLine("3 - Controle de Fornecedores");
            Console.WriteLine("4 - Controle de Requisições de Entrada");
            Console.WriteLine("5 - Controle de Requisições de Saída");

            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;
        }
    }
}
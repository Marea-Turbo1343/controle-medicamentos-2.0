using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ApresentarCabecalho();

                Console.WriteLine("Visualizando Fornecedores...");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                "Id", "Nome", "Endereco", "Telefone"
            );

            Entidade[] fornecedoresCadastrados = repositorio.SelecionarTodos();

            foreach (Fornecedor fornecedor in fornecedoresCadastrados)
            {
                if (fornecedor == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                    fornecedor.Id, fornecedor.Nome, fornecedor.Endereco, fornecedor.Telefone
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        protected override Entidade ObterRegistro()
        {
            Console.Write("Digite o nome do paciente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o endereço do paciente: ");
            string endereco = Console.ReadLine();

            Console.Write("Digite o telefone do paciente ('49 3551-4444': ");
            string telefone = Console.ReadLine();

            Fornecedor novoFornecedor = new Fornecedor(nome, endereco, telefone);

            return novoFornecedor;
        }

        public void CadastrarEntidadeTeste()
        {
            Fornecedor fornecedor = new Fornecedor("Drogaria Lages", "Rua Dom Pedro II", "49 3531-5432");

            repositorio.Cadastrar(fornecedor);
        }
    }
}
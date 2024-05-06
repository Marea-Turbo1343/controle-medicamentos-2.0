using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    internal class TelaMedicamento : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ApresentarCabecalho();

                Console.WriteLine("Visualizando Medicamentos...");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20}",
                "Id", "Nome", "Quantidade"
            );

            Entidade[] medicamentosCadastrados = repositorio.SelecionarTodos();

            foreach (Medicamento medicamento in medicamentosCadastrados)
            {
                if (medicamento == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -20} | {2, -20}",
                    medicamento.Id, medicamento.Nome, medicamento.Quantidade
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        protected override Entidade ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o lote: ");
            string lote = Console.ReadLine();

            Console.Write("Digite a data de validade: ");
            DateTime dataValidade = Convert.ToDateTime(Console.ReadLine());

            Medicamento medicamento = new Medicamento(nome, descricao, lote, dataValidade);

            return medicamento;
        }
    }
}
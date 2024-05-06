using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class RequisicaoEntrada : Entidade
    {
        public Medicamento Medicamento { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataRequisicao { get; set; }
        public int QuantidadeEntrada { get; set; }

        public RequisicaoEntrada(Medicamento medicamentoSelecionado, Fornecedor fornecedorSelecionado, int quantidade)
        {
            Medicamento = medicamentoSelecionado;
            Fornecedor = fornecedorSelecionado;

            DataRequisicao = DateTime.Now;
            QuantidadeEntrada = quantidade;
        }

        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (Medicamento == null)
                erros[contadorErros++] = "O medicamento precisa ser preenchido";

            if (Fornecedor == null)
                erros[contadorErros++] = "O paciente precisa ser informado";

            if (QuantidadeEntrada < 1)
                erros[contadorErros++] = "Por favor informe uma quantidade válida";

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }

        public bool IncluirMedicamento()
        {
            Medicamento.Quantidade += QuantidadeEntrada;
            return true;
        }
    }
}
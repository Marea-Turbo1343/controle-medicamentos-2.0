using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisicao;

namespace ControleMedicamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            RepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            TelaPaciente telaPaciente = new TelaPaciente();
            telaPaciente.tipoEntidade = "Paciente";
            telaPaciente.repositorio = repositorioPaciente;
            telaPaciente.CadastrarEntidadeTeste();

            RepositorioMedicamento repositorioMedicamento = new RepositorioMedicamento();
            TelaMedicamento telaMedicamento = new TelaMedicamento();
            telaMedicamento.repositorio = repositorioMedicamento;
            telaMedicamento.tipoEntidade = "Medicamento";

            RepositorioFornecedor repositorioFornecedor = new RepositorioFornecedor();
            TelaFornecedor telaFornecedor = new TelaFornecedor();
            telaFornecedor.repositorio = repositorioFornecedor;
            telaFornecedor.tipoEntidade = "Fornecedor";

            RepositorioRequisicaoSaida repositorioRequisicaoSaida = new RepositorioRequisicaoSaida();
            TelaRequisicaoSaida telaRequisicaoSaida = new TelaRequisicaoSaida();
            telaRequisicaoSaida.repositorio = repositorioRequisicaoSaida;
            telaRequisicaoSaida.tipoEntidade = "Requisição de Saída";
            telaRequisicaoSaida.telaPaciente = telaPaciente;
            telaRequisicaoSaida.telaMedicamento = telaMedicamento;
            telaRequisicaoSaida.repositorioPaciente = repositorioPaciente;
            telaRequisicaoSaida.repositorioMedicamento = repositorioMedicamento;

            RepositorioRequisicaoEntrada repositorioRequisicaoEntrada = new RepositorioRequisicaoEntrada();
            TelaRequisicaoEntrada telaRequisicaoEntrada = new TelaRequisicaoEntrada();
            telaRequisicaoEntrada.repositorio = repositorioRequisicaoEntrada;
            telaRequisicaoEntrada.tipoEntidade = "Requisição de Entrada";
            telaRequisicaoEntrada.telaMedicamento = telaMedicamento;
            telaRequisicaoEntrada.telaFornecedor = telaFornecedor;
            telaRequisicaoEntrada.repositorioMedicamento = repositorioMedicamento;
            telaRequisicaoEntrada.repositorioFornecedor = repositorioFornecedor;

            while (true)
            {
                char opcaoPrincipalEscolhida = TelaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipalEscolhida == 'S' || opcaoPrincipalEscolhida == 's')
                    break;

                TelaBase tela = null;

                if (opcaoPrincipalEscolhida == '1')
                    tela = telaPaciente;

                else if (opcaoPrincipalEscolhida == '2')
                    tela = telaMedicamento;

                else if (opcaoPrincipalEscolhida == '3')
                    tela = telaFornecedor;

                else if (opcaoPrincipalEscolhida == '4')
                    tela = telaRequisicaoEntrada;

                else if (opcaoPrincipalEscolhida == '5')
                    tela = telaRequisicaoSaida;

                char operacaoEscolhida = tela.ApresentarMenu();

                if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                    continue;

                if (operacaoEscolhida == '1')
                    tela.Registrar();

                else if (operacaoEscolhida == '2')
                    tela.Editar();

                else if (operacaoEscolhida == '3')
                    tela.Excluir();

                else if (operacaoEscolhida == '4')
                    tela.VisualizarRegistros(true);
            }

            Console.ReadLine();
        }
    }
}
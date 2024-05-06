using ControleMedicamentos.ConsoleApp.Compartilhado;
using System.Text.RegularExpressions;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class Fornecedor : Entidade
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Fornecedor(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (Nome.Length < 3)
                erros[contadorErros++] = "O Nome do Paciente precisa conter ao menos 3 caracteres";

            if (Endereco.Length < 5)
                erros[contadorErros++] = "O Endereço do Paciente precisa conter ao menos 5 caracteres";

            Regex regexTelefone = new Regex(@"^\d{2} \d{4}-\d{4}$");
            if (!regexTelefone.IsMatch(Telefone))
                erros[contadorErros++] = "Preencha o telefone conforme este exemplo: '49 99876-1234'";

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }
    }
}
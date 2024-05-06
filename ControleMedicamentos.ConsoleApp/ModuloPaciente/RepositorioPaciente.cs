using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class RepositorioPaciente : Repositorio
    {
        public bool ExisteCartaoSus(string cartaoSus)
        {
            foreach (Entidade entidade in registros)
            {
                if (entidade == null)
                    continue;

                Paciente paciente = (Paciente)entidade;
                if (paciente.CartaoSus == cartaoSus)
                    return true;
            }

            return false;
        }
    }
}
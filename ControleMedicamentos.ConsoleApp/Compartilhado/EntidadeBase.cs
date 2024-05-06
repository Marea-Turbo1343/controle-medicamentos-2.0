namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal abstract class Entidade
    {
        public int Id { get; set; }

        public abstract string[] Validar();
    }
}
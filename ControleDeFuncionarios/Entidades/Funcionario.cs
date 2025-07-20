namespace ControleDeFuncionarios.Entidades
{
    public class Funcionario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; }
        public Guid EmpresaId { get; set; }

        public Empresa Empresa { get; set; } = new();
    }
}

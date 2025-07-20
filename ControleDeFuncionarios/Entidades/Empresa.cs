namespace ControleDeFuncionarios.Entidades
{
    public class Empresa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RazaoSocial { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;

        public List<Funcionario> Funcionarios { get; set; } = new();
    }
}

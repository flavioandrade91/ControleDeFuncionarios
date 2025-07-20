using ControleDeFuncionarios.Entidades;
using ControleDeFuncionarios.Repositorios;

namespace ControleDeFuncionarios.Controladores
{
    public class FuncionarioControlador
    {
        public void CadastrarFuncionario() 
        {
            var funcionario = new Funcionario();

            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIO\n");

            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Matrícula: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Data de Admissão: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.Write("ID da Empresa: ");
            funcionario.EmpresaId = Guid.Parse(Console.ReadLine());

            var funcionarioRepositorio = new FuncionarioRepositorio();
            funcionarioRepositorio.InserirFuncionario(funcionario);

            Console.WriteLine("\nFUNCIONÁRIO CADASTRADO COM SUCESSO!!!\n");

        }
    }
}

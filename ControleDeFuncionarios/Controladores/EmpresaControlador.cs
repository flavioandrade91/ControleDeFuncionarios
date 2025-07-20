using ControleDeFuncionarios.Repositorios;

namespace ControleDeFuncionarios.Controladores
{
    public class EmpresaControlador
    {
        public void EmpresasCadastradas()
        {
            var empresaRepositorio = new EmpresaRepositorio();
            var empresas = empresaRepositorio.ObterEmpresas();

            foreach (var empresa in empresas)
            {
                Console.WriteLine($"ID: {empresa.Id}, Razão Social: {empresa.RazaoSocial}, CNPJ{empresa.Cnpj}");
            }
        }
    }
}

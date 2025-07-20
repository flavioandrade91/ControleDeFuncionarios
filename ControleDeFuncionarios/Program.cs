using ControleDeFuncionarios.Controladores;

var empresa = new EmpresaControlador();
empresa.EmpresasCadastradas();

var funcionario = new FuncionarioControlador();
funcionario.CadastrarFuncionario();
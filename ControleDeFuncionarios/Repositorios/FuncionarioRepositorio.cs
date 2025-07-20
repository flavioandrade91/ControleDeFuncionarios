using ControleDeFuncionarios.Configuracoes;
using ControleDeFuncionarios.Entidades;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleDeFuncionarios.Repositorios
{
    public class FuncionarioRepositorio
    {
        public void InserirFuncionario(Funcionario funcionario)
        {
            var query = @"
                    INSERT INTO FUNCIONARIO (ID, NOME, CPF, MATRICULA, DATAADMISSAO, EMPRESAID)
                    VALUES (@Id, @Nome, @Cpf, @Matricula, @DataAdmissao, @EmpresaId)
                    ";

            var config = new ConfiguracaoDB();

            using (var conexao = new SqlConnection(config.StringDeConexao)) {
                    conexao.Execute(query, funcionario);
            }

        }
    }
}

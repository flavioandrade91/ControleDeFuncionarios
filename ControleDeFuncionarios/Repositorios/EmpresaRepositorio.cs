using ControleDeFuncionarios.Configuracoes;
using ControleDeFuncionarios.Entidades;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleDeFuncionarios.Repositorios
{
    public class EmpresaRepositorio
    {
        public List<Empresa> ObterEmpresas() { 
           var query = @"
                        SELECT ID, RAZAOSOCIAL, CNPJ 
                        FROM EMPRESA
                        ORDER BY RAZAOSOCIAL ASC
                        ";

            var config = new ConfiguracaoDB();

            using (var conexao = new SqlConnection(config.StringDeConexao)) {
                return conexao.Query<Empresa>(query).ToList();
            }
            
        }
    }
}

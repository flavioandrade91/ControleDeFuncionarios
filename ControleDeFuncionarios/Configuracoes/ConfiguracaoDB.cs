namespace ControleDeFuncionarios.Configuracoes
{
    public class ConfiguracaoDB
    {
        public string StringDeConexao { 
            get 
            {
                return "Data Source=localhost,1433;Initial Catalog=DBFuncionarios;User ID=sa;Password=Flavio1234;Encrypt=True;TrustServerCertificate=True;Connect Timeout=30;Application Intent=ReadWrite;Multi Subnet Failover=False";
            }
        }
    }
}

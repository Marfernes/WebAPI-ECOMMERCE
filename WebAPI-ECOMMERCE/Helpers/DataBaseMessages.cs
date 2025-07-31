namespace WebAPI_ECOMMERCE.Helpers
{
    public static class DataBaseMessages
    {
        public const string ConexaoNaoDefinida = "A string de conexão não foi definida. Verifique se a variável de ambiente 'DB_CONNECTION_STRING' está configurada.";
        public const string ErroConexaoBanco = "Erro ao tentar conectar ao banco de dados.";
        public const string ConexaoEstabelecidaComSucesso = "Conexão com banco de dados realizada com sucesso.";
    }
}

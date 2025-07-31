namespace WebAPI_ECOMMERCE.Helpers
{
    public static class DataBaseHelper
    {
        public static Results<string> ObterConnectionString()
        {
            var conn = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            if (string.IsNullOrWhiteSpace(conn))
                return Results<string>.Erro(DataBaseMessages.ErroConexaoBanco);

            return Results<string>.Ok(conn);
        }
    }
}

namespace WebAPI_ECOMMERCE.Helpers
{
    public class Results<T>
    {
        private object value;

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
        public T? Dados { get; private set; }

        private Results(bool sucesso, string mensagem, T? dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }

        public Results(bool sucesso, string mensagem, object value)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            this.value = value;
        }

        public static Results<T> Ok(T dados) =>
            new Results<T>(true, string.Empty, dados);

        public static Results<T> Erro(string mensagem) =>
            new Results<T>(false, mensagem, default);
    }

    public class Resultado : Results<object>
    {
        private Resultado(bool sucesso, string mensagem)
            : base(sucesso, mensagem, null!) { }

        public static new Resultado Erro(string mensagem) =>
            new Resultado(false, mensagem);

        public static Resultado Ok() =>
            new Resultado(true, string.Empty);
    }
}




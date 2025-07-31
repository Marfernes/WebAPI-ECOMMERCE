namespace WebAPI_ECOMMERCE.Exceptions
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string mensagem)

            : base(mensagem) {}
        
    }
}

using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebAPI_ECOMMERCE.Token
{
    public class JwtSecurityKey
    {
        #region Método que encriptografa a chave
        public static SymmetricSecurityKey Create(string secretkey)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretkey));
        }
        #endregion
    }
}

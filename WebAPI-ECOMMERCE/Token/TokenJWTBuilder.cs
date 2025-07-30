﻿namespace WebAPI_ECOMMERCE.Token
{
    public class TokenJWTBuilder
    {
        private JwtSecurityKey _jwtSecurityKey = null;
        private string subject = "";
        private string issuer = "";
        private string audience = "";
        private Dictionary<string, string> claims = new Dictionary<string, string>();
        private int expiryInMinutes = 5;

        public TokenJWTBuilder AddSecurityKey(JwtSecurityKey jwtSecurityKey)
        {
            this._jwtSecurityKey = jwtSecurityKey;
            return this;
        }
        public TokenJWTBuilder AddSubject(string subject)
        {
            this.subject = subject;
            return this;
        }

        public TokenJWTBuilder AddIssuer(string issuer)
        {
            this.issuer = issuer;
            return this;
        }
        public TokenJWTBuilder AddAudience(string audience)
        {
            this.audience = audience;
            return this;
        }
        public TokenJWTBuilder AddClaim(string type, string value)
        {
            this.claims.Add(type, value);
            return this;
        }
        public TokenJWTBuilder AddClaims(Dictionary<string , string> claims)
        {
            this.claims.Union(claims);
            return this;
        }
        public TokenJWTBuilder AddExpiry(int expiryInMinutes)
        {
            this.expiryInMinutes = expiryInMinutes;
            return this;
        }
    }
}

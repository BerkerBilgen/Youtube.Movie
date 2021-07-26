using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YoutubeMovie.Authentication.JWT
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public string CreateToken(string username, string passsword)
        {
            var payload = new Dictionary<string, object>
            {
                { "username" , username },
                { "password", passsword }
            };

            const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            return encoder.Encode(payload, secret);
        }

        public Task<bool> Validate(string token)
        {
            throw new NotImplementedException();
        }
    }
}

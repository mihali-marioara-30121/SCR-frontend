using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SCD_Frontend.services
{
    internal class JwtDecoderService
    {
        public static string GetRoleFromJwt(string jwtToken)
        {
            string base64encodedPayload = jwtToken.Split('.')[1];

            // Replace Base64 URL-specific characters
            base64encodedPayload = base64encodedPayload.Replace('-', '+').Replace('_', '/');
            string decodedString = null;

            try
            {
                // Add padding if necessary
                int padding = base64encodedPayload.Length % 4;
                if (padding > 0)
                {
                    base64encodedPayload += new string('=', 4 - padding);
                }

                byte[] bytes = Convert.FromBase64String(base64encodedPayload);
                decodedString = Encoding.UTF8.GetString(bytes);
                Console.WriteLine("Decoded payload: " + decodedString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Base64-encoded payload.");
            } 

            try
            {
                using (JsonDocument doc = JsonDocument.Parse(decodedString))
                {
                    JsonElement root = doc.RootElement;

                    if (root.TryGetProperty("role", out JsonElement roleElement) && roleElement.ValueKind == JsonValueKind.String)
                    {
                        return roleElement.GetString();

                    }
                    else
                    {
                        return null;
                    }
                }
            } catch (Exception ex) { return null; }
        }
    }
}

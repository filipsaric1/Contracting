using Blazored.LocalStorage;
using JobMarket.Contracting.Domain.Models.Account;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JobMarket.Contracting.WebUI
{
    public class AppState
    {   [Inject]
        private IHttpClientFactory _clientFactory { get; set; }
        [Inject]
        public ILocalStorageService _localStorage { get; set; }
        public string Token { get; set; }

        public AppState(ILocalStorageService localStorageService, IHttpClientFactory httpClientFactory)
        {
            _localStorage = localStorageService;
            _clientFactory = httpClientFactory;
            Task.FromResult(CheckState()).Wait();
        }
        public async Task CheckState()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");
            if (token != null)
            {
                Token = token;
            }
        }

        public bool IsLoggedIn()
        {
            Task.FromResult(CheckState()).Wait();

            if (Token != null)
            {
                var client = _clientFactory.CreateClient("contracting");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

                var response = client.GetAsync("api/account/token");
                response.Wait();
                if (response.IsCompleted)
                {
                    if (response.Result.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
            }
            return false;

            //if (Token != null)
            //{
            //    var claims = GetClaimsJson();
            //    var expires = claims["exp"];

            //    DateTimeOffset expOffset = DateTimeOffset.FromUnixTimeSeconds(long.Parse(expires));
            //    var exp = expOffset.DateTime;

            //    if (exp.CompareTo(DateTime.Now) > 0)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public async Task Register(RegisterDto registerDetails)
        {
            var client = _clientFactory.CreateClient("contracting");
            var response = await client.PostAsync("api/account/register", new StringContent(JsonSerializer.Serialize(registerDetails), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                await SaveToken(response);
            }
        }
        public async Task Login(LoginDto loginDetails)
        {
            var client = _clientFactory.CreateClient("contracting");
            var response = await client.PostAsync("api/account/login", new StringContent(JsonSerializer.Serialize(loginDetails), Encoding.UTF8, "application/json"));
            
            if (response.IsSuccessStatusCode)
            {
                await SaveToken(response);
            }
        }
        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
        }

        private async Task SaveToken(HttpResponseMessage response)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var jwt = JsonSerializer.Deserialize<string>(responseContent);
            Token = jwt;
            await _localStorage.SetItemAsync("authToken", jwt);
        }

        public async Task<HttpClient> SetAuthorizationHeader(HttpClient client)
        {
            if (!client.DefaultRequestHeaders.Contains("Authorization"))
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return client;
            
        }
        public Dictionary<string, string> GetClaimsJson()
        {
            string[] jwtEncodedSegments = Token.Split('.');
            var payloadSegment = jwtEncodedSegments[1];
            var jsonPayload = Encoding.UTF8.GetString(this.Decode(payloadSegment));
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonPayload);
            return result;
        }

        private byte[] Decode(string input)
        {
            var output = input;
            output = output.Replace('-', '+'); // 62nd char of encoding
            output = output.Replace('_', '/'); // 63rd char of encoding
            switch (output.Length % 4) // Pad with trailing '='s
            {
                case 0: break; // No pad chars in this case
                case 2: output += "=="; break; // Two pad chars
                case 3: output += "="; break; // One pad char
                default: throw new System.ArgumentOutOfRangeException("input", "Illegal base64url string!");
            }
            var converted = Convert.FromBase64String(output); // Standard base64 decoder
            return converted;
        }
        public bool IsRoleClient() 
        {
            if (!IsLoggedIn())
            {
                return false;
            }

            var claims = this.GetClaimsJson();
            var role = claims.GetValueOrDefault(System.Security.Claims.ClaimTypes.Role);
            if (role.ToString() == "CLIENT")
            {
                return true;
            }
            return false;
        }
        public bool IsRoleExecutor()
        {
            if (!IsLoggedIn())
            {
                return false;
            }

            var claims = this.GetClaimsJson();
            var role = claims.GetValueOrDefault(System.Security.Claims.ClaimTypes.Role);
            if (role.ToString() == "EXECUTOR")
            {
                return true;
            }
            return false;
        }
        public bool IsRoleAdmin()
        {
            if (!IsLoggedIn())
            {
                return false;
            }

            var claims = this.GetClaimsJson();
            var role = claims.GetValueOrDefault(System.Security.Claims.ClaimTypes.Role);
            if (role.ToString() == "ADMINISTRATOR")
            {
                return true;
            }
            return false;
        }
        public AppState Clone()
        {
            AppState newAppState = new AppState(this._localStorage, this._clientFactory);
            newAppState.Token = this.Token;
            return newAppState;
        }
    }
}
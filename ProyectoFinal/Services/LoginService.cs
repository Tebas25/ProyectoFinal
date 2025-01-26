using Newtonsoft.Json;
using ProyectoFinal.Models;
using System.Net;
using System.Net.Http.Json;

namespace ProyectoFinal.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<Usuario> Login(string username, string password)
        {
            var Infousuario = new Usuario();
            var client = new HttpClient();
            string url = "https://localhost:7173/api/Usuario/" + username + "/" + password;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage respuesta = await client.GetAsync(url);
            if(respuesta.IsSuccessStatusCode){
                if (respuesta.StatusCode == HttpStatusCode.NoContent) {
                    return null;
                }
                else {
                    Infousuario = await respuesta.Content.ReadFromJsonAsync<Usuario>();
                    return await Task.FromResult(Infousuario);
                }
            }
            else{
                return null;
            }
        }
    }
}

//using System.Net.Http.Json;

//namespace AdminSysFront.Servicios
//{
//    public class ApiService
//    {
//        private readonly HttpClient _httpClient;

//        public ApiService(HttpClient httpClient)
//        {
//            _httpClient = httpClient;
//        }
//        private class RespuestaAutenticacion
//        {
//            public bool Exito { get; set; }
//            // Otras propiedades según la respuesta de tu API
//        }
//        private class LoginRequest
//        {
//            public string? Id { get; set; }
//            public string? Password { get; set; }
//        }

//        public async Task<bool> IniciarSesion(string usuario, string password)
//        {
//            var request = new LoginRequest
//            {
//                Id = usuario,
//                Password = password
//            };

//            try
//            {
//                var response = await _httpClient.PostAsJsonAsync<RespuestaAutenticacion>("Login", request);
//                return response.Exito;
//            }
//            catch (Exception ex)
//            {
//                // Manejar la excepción de una manera más robusta según tu aplicación
//                Console.WriteLine($"Error al intentar iniciar sesión: {ex.Message}");
//                return false;
//            }
//        }

//        // Clase para representar la respuesta de autenticación

//    }
//}


//using System.Net.Http;
//using System.Security.Claims;

//namespace AdminSysFront.Modelos
//{
//    public class Login : PageModel
//    {
//        public async Task<IActionResult> OnPostAsync(string returnUrl = "/")
//        {
//            var token = await ObtenerTokenDesdeApiExterna(Request.Form["username"], Request.Form["password"]);

//            if (token != null)
//            {
//                var claims = new List<Claim>
//            {
//                new Claim(ClaimTypes.Name, Request.Form["username"]),
//                new Claim("access_token", token)
//            };

//                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//                var principal = new ClaimsPrincipal(identity);

//                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

//                return LocalRedirect(returnUrl);
//            }

//            return Page();
//        }

//        private async Task<string> ObtenerTokenDesdeApiExterna(string username, string password)
//        {
//            // Lógica para autenticarse con la API externa y obtener el token JWT.
//            // Puedes usar HttpClient para hacer una solicitud al servicio de autenticación externo.
//            // Asegúrate de manejar la respuesta y extraer el token.
//            // Retorna el token si la autenticación fue exitosa, o null en caso contrario.

//            // Ejemplo:
//            using (var client = new HttpClient())
//            {
//                var parametros = new Dictionary<string, string>
//            {
//                { "username", username },
//                { "password", password },
//                // Otros parámetros según la API externa
//            };

//                var respuesta = await client.PostAsync("URL_DEL_SERVICIO_DE_AUTENTICACION/api/auth/login", new FormUrlEncodedContent(parametros));

//                if (respuesta.IsSuccessStatusCode)
//                {
//                    var contenido = await respuesta.Content.ReadAsStringAsync();
//                    // Extraer el token del contenido de la respuesta
//                    // Retorna el token
//                }
//            }

//            // Si la autenticación falla, retorna null
//            return null;
//        }
//    }

//}

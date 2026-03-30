using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (!request.Email.EndsWith("@deal.com.br"))
        {
            return BadRequest("Email deve terminar com @deal.com.br");
        }
        if (request.Password.Length < 12 || !IsPasswordComplex(request.Password))
        {
            return BadRequest("Senha deve ter pelo menos 12 caracteres, incluindo letras, números e símbolos.");
        }
        return Ok(new { Message = "Login bem-sucedido." });
    }

    private bool IsPasswordComplex(string password)
    {
        // Implementar lógica real para senha
        return true;
    }
}
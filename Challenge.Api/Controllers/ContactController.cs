using Challenge.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers;

[ApiController]
[Route("/api/v1/contacts")]

public class ContactController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public async Task<IActionResult> Post([FromServices] IContactRepository repository, [FromBody] )
    {
        repository.InsertContactAsync();
    } 


}
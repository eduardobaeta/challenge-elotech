using Challenge.Api.CustomExceptions;
using Challenge.Api.ViewModels.Client;
using Challenge.Api.ViewModels.Common;
using Challenge.Data.Repositories;
using Challenge.Data.Repositories.Interfaces;
using Challenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management;

namespace Challenge.Api.Controllers;

[ApiController]
[Route("/api/v1/clients")]

public class ClientController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAllClients([FromServices] IClientRepository repository)
    {
        try
        {
            var clients = await repository.GetClients();
            return Ok(new ResultViewModel<List<Client>>(clients));
        }
        catch (DbUpdateException e)
        {
            return BadRequest(new ResultViewModel<dynamic?>(new {}, new List<string>
            {
                "Error to list clients",
                e.Message,
                e.InnerException?.Message ?? string.Empty
                
            }));
        }
        catch (Exception e)
        {
            return BadRequest(new ResultViewModel<dynamic?>(new {}, new List<string>
            {
                "Something is wrong please try again",
                e.Message,
                e.InnerException?.Message ?? string.Empty
            }));
        }
    }
    
    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> GetAllClients([FromServices] IClientRepository repository, [FromRoute] Guid id)
    {
        try
        {
            var client = await repository.GetClientById(id);
            if (client == null)
                throw new NotFoundException();
            return Ok(new ResultViewModel<Client?>(client));
        }
        catch (NotFoundException e)
        {
            return NotFound(new ResultViewModel<dynamic?>(new {} , new List<string>
            {
                $"Not found a client with id {id}",
                e.Message,
                e.InnerException?.Message ?? string.Empty
                
            }));
        }
        catch (DbUpdateException e)
        {
            return BadRequest(new ResultViewModel<dynamic?>(new {}, new List<string>
            {
                "Error to list clients",
                e.Message,
                e.InnerException?.Message ?? string.Empty
                
            }));
        }
        catch (Exception e)
        {
            return BadRequest(new ResultViewModel<dynamic?>(new {}, new List<string>
            {
                "Something is wrong please try again",
                e.Message,
                e.InnerException?.Message ?? string.Empty
            }));
        }
    }

    [HttpPost]
    [Route("")]
    public async Task<IActionResult> Post([FromServices] IClientRepository repository, [FromBody] CreateClientViewModel model)
    {
        try
        {
            var client = new Client() {Name = model.Name, Document = model.Document, BirthDate = model.BirthDate};
            await repository.InsertClientAsync(client);
            return Ok(new ResultViewModel<Client>(client));
        }
        catch (DbUpdateException e)
        {
            return BadRequest(new ResultViewModel<dynamic>(new {}, new List<string>
            {
                "Error to register new client",
                e.Message,
                e.InnerException?.Message ?? string.Empty
                
            }));
        }
        catch (Exception e)
        {
            return BadRequest(new ResultViewModel<dynamic>(new {}, new List<string>
            {
                "Something is wrong please try again",
                e.Message,
                e.InnerException?.Message ?? string.Empty
            }));
        }
    }

}
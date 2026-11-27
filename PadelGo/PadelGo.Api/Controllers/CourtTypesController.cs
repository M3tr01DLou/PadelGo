using Microsoft.AspNetCore.Mvc;
using PadelGo.Application.Interfaces.Repositories;
using PadelGo.Domain.Entities;

namespace PadelGo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourtTypesController : GenericController<CourtType>
{
    public CourtTypesController(IGenericRepository<CourtType> repository) : base(repository)
    {
    }
}
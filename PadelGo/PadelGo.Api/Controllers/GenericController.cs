using Microsoft.AspNetCore.Mvc;
using PadelGo.Application.Interfaces;

namespace PadelGo.Api.Controllers;

public class GenericController<T> : Controller where T : class
{
    private readonly IGenericRepository<T> _repository;

    public GenericController(IGenericRepository<T> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public virtual async Task<IActionResult> GetAsync()
    {
        var action = await _repository.GetAsync();
        if (action.IsSuccess)
        {
            return Ok(action.Result);
        }
        return BadRequest();
    }

    [HttpGet("{id}")]
    public virtual async Task<IActionResult> GetAsync(int id)
    {
        var action = await _repository.GetAsync(id);
        if (action.IsSuccess)
        {
            return Ok(action.Result);
        }
        return NotFound();
    }

    [HttpPost]
    public virtual async Task<IActionResult> PostAsync(T model)
    {
        var action = await _repository.AddAsync(model);
        if (action.IsSuccess)
        {
            return Ok(action.Result);
        }
        return BadRequest(action.Message);
    }

    [HttpPut]
    public virtual async Task<IActionResult> PutAsync(T model)
    {
        var action = await _repository.UpdateAsync(model);
        if (action.IsSuccess)
        {
            return Ok(action.Result);
        }
        return BadRequest(action.Message);
    }

    [HttpDelete("{id}")]
    public virtual async Task<IActionResult> DeleteAsync(int id)
    {
        var action = await _repository.DeleteAsync(id);
        if (action.IsSuccess)
        {
            return NoContent();
        }
        return BadRequest(action.Message);
    }

    //[HttpGet("Paginated")]
    //public virtual async Task<IActionResult> GetAsync([FromQuery] PaginationDTO pagination)
    //{
    //    var action = await _repository.GetAsync(pagination);
    //    if (action.IsSuccess)
    //    {
    //        return Ok(action.Result);
    //    }
    //    return BadRequest();
    //}

    //[HttpGet("TotalPages")]
    //public virtual async Task<IActionResult> GetTotalPagesAsync([FromQuery] PaginationDTO pagination)
    //{
    //    var action = await _repository.GetTotalPagesAsync(pagination);
    //    if (action.IsSuccess)
    //    {
    //        return Ok(action.Result);
    //    }
    //    return BadRequest();
    //}
}
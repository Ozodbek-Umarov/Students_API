using Application.DTOs.StudentDtos;
using Application.Interfaces;
using Infrastructures.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Students_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(IStudentService studentService)
    : ControllerBase
{
    private readonly IStudentService _studentService = studentService;
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _studentService.GetAllAsync();
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> AddAsync(AddStudentDto dto)
    {
        await _studentService.AddAsync(dto);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await _studentService.DeleteAsync(id);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var result = await _studentService.GetByIdAsync(id);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(StudentDto dto)
    {
        await _studentService.UpdateAsync(dto);
        return Ok();
    }

}

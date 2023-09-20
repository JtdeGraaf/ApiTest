using Microsoft.AspNetCore.Mvc;
using ApiTest.test.domain;

namespace ApiTest.test.presentation;

[ApiController]
[Route("students")]
public class StudentController : Controller
{
    
    private ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetStudents()
    {
        Student student = new Student("Jan", 20);
        _context.Students.Add(student);
        _context.SaveChanges();
        
        return  Ok(_context.Students.ToList());
    }
    
    
}
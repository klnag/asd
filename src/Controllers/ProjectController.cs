using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Helpers;
using src.Entities;

namespace src.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase {
    private readonly DataContext context;

    public ProjectController(DataContext context) {
        this.context = context;
    }

    [HttpGet()]
    public DbSet<Project>? Get() {
        return context.Projects;
    }
}
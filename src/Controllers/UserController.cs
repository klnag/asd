using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Helpers;
using src.Entities;

namespace src.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase {
    private readonly DataContext context;

    public UserController(DataContext context) {
        this.context = context;
    }

    [HttpGet()]
    public DbSet<User>? Get() {
        return context.Users;
    }
}
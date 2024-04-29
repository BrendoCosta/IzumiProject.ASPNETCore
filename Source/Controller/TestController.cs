namespace Izumi.Controller;

using Izumi.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class TestController: ControllerBase
{
    private readonly TestContext dbContext;

    public TestController(TestContext dbContext)
    {
        this.dbContext = dbContext;
        this.dbContext.Database.Migrate();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<Izumi.Model.Test>> GetTest(long id)
    {
        Console.WriteLine($"GET = {id}");
        return Ok(new { x = 50, y = "abc" });
    }

    [HttpPost("SendObj")]
    public IActionResult SendObj([FromBody] Izumi.Model.Test obj)
    {
        Console.WriteLine($"POST = {obj.Hello}");
        this.dbContext.Tests.Add(obj);
        this.dbContext.SaveChanges();
        return Ok(obj);
    }

    [HttpGet("Version")]
    public IActionResult GetVersion()
    {
        return Ok(new Izumi.Model.Test());
    }
}

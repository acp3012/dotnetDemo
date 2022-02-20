using Microsoft.AspNetCore.Mvc;

namespace OPCTestWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EnvController : ControllerBase
{
    
    [HttpGet]
    public IEnumerable<Variables> Get()
    {   
        List<Variables> envVariables = new List<Variables> 
        {
            new Variables() { Key = "SQL_CNN_STRING", 
            Value = Environment.GetEnvironmentVariable("SQL_CNN_STRING")?? "<None>"},
            
            new Variables() { Key = "APPNAME", 
            Value = Environment.GetEnvironmentVariable("APPNAME")?? "Not Found"}
        };
        return envVariables;
    }
}

public class Variables
{
    public string? Key { get; set; }
    public string? Value { get; set; }
}
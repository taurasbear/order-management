using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.Server.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class BaseController : ControllerBase;
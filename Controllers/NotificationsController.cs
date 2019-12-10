using DemoMediatR.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoMediatR.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NotificationsController : ControllerBase 
  {
    private readonly INotifierMediatorService _notifierMediatorService;

    public NotificationsController(INotifierMediatorService notifierMediatorService)
    {
      _notifierMediatorService = notifierMediatorService;
    }

    [HttpGet]
    public ActionResult<string> Get() 
    {
        _notifierMediatorService.Notifiy("This is a simple message notification");
        return Ok("Completed");
    }
  }
}
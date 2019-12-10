using DemoMediatR.Commands;
using MediatR;

namespace DemoMediatR.Service
{
  public class NotifierMediatorService : INotifierMediatorService
  {
    private readonly IMediator _mediator;

    public NotifierMediatorService(IMediator mediator)
    {
        _mediator = mediator;
    }  

    public void Notifiy(string notifyText)
    {
      _mediator.Publish(new NotificationMessage { NotifyText = notifyText });
    }
  }
}
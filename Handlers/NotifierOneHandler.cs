using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using DemoMediatR.Commands;
using MediatR;

namespace DemoMediatR.Handlers
{
  public class NotifierOneHandler : INotificationHandler<NotificationMessage>
  {
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
      Debug.WriteLine($"Debbuging from Notifier 1. Message : {notification.NotifyText}");
      return Task.CompletedTask;
    }
  }
}
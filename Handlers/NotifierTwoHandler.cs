using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using DemoMediatR.Commands;
using MediatR;

namespace DemoMediatR.Handlers
{
  public class NotifierTwoHandler : INotificationHandler<NotificationMessage>
  {
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
      Debug.WriteLine($"Debbuging from Notifier 2. Message : {notification.NotifyText}");
      return Task.CompletedTask;
    }
  }
}
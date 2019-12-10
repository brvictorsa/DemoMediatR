using MediatR;

namespace DemoMediatR.Commands
{
    public class NotificationMessage : INotification
    {
        public string NotifyText { get; set; }
    }
}
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace TheBuildersMiddleAges.Pigeon
{
    public class NotificationHub : Hub
    {
        private readonly Dictionary<Notification, string> _notificationMessages = new Dictionary<Notification, string>()
        {
            { Notification.LOBBY_ROOM_UPDATE, "LOBBY_ROOM_UPDATE" },
            { Notification.GAME_STATE_UPDATE, "GAME_STATE_UPDATE" }
        };

        //To call execute this on Test.html
        //$.connection.notificationHub.server.notify({Players: [$.connection.hub.id], Notification: 1})
        public void Notify(NotificationRequest request)
        {
            if (!(request?.Players.Length > 0)) return;

            var notificationMessage = _notificationMessages[request.Notification];
            Clients.Clients(request.Players).broadcastMessage(notificationMessage);
        }
    }
}
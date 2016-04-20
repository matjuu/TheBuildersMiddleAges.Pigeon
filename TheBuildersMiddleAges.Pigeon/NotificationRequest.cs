using System;

namespace TheBuildersMiddleAges.Pigeon
{
    public class NotificationRequest
    {
        public string[] Players { get; set; }
        public Notification Notification { get; set; }
    }
}
﻿using System;

namespace NadekoBot.Services.Database.Models
{
    public class Reminder : DbEntity
    {
        public DateTime When { get; set; }
        public long ChannelId { get; set; }
        public long ServerId { get; set; }
        public long UserId { get; set; }
        public string Message { get; set; }
        public bool IsPrivate { get; set; }
    }
}

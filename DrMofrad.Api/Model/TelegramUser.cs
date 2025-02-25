﻿using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class TelegramUser
    {
        public TelegramUser()
        {
            TelegramChannels = new HashSet<TelegramChannel>();
            TelegramMessages = new HashSet<TelegramMessage>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string LanguageCode { get; set; }

        public virtual ICollection<TelegramChannel> TelegramChannels { get; set; }
        public virtual ICollection<TelegramMessage> TelegramMessages { get; set; }
    }
}
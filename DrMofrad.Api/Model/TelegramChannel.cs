﻿#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class TelegramChannel
    {
        public string Username { get; set; }
        public long? Definer { get; set; }

        public virtual TelegramUser DefinerNavigation { get; set; }
    }
}
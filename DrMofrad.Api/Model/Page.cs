﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? LangId { get; set; }
        public string Key { get; set; }

        public virtual Lang Lang { get; set; }
    }
}

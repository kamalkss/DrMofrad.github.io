﻿#nullable disable

namespace DrMofrad.Api.Model
{
    public class SlideShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Orders { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
    }
}
﻿namespace DrMofrad.Api.GraphQl.SlideShow
{
    public record AddSlideShowInput(string SlideShowTitle, string SlideShowDescription, string SlideShowImgUrl,
        int SlideShowOrders, int SlideShowLangId);
}
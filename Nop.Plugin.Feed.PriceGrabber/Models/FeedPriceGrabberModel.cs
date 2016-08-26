﻿using System.Web.Mvc;
using Nop.Web.Framework;

namespace Nop.Plugin.Feed.PriceGrabber.Models
{
    public class FeedPriceGrabberModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Feed.PriceGrabber.Fields.ProductPictureSize")]
        public int ProductPictureSize { get; set; }

        [NopResourceDisplayName("Plugins.Feed.PriceGrabber.Fields.Currency")]
        public int CurrencyId { get; set; }

        public SelectList AvailableCurrencies { get; set; }

        public string GenerateFeedResult { get; set; }
    }
}
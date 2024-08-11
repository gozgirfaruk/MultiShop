﻿namespace MultiShop.Catalog.Settings
{
    public class DatabaseSetting : IDatabaseSetting
    {
        public string CategoryCollection { get; set; }
        public string ProductCollection { get; set; }
        public string ProductImageCollection { get; set; }
        public string ProductPreviewCollection { get; set; }
        public string FeatureSliderCollection { get; set; }
        public string SpecialOfferCollection { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string FeatureCollection { get ; set; }
        public string OfferDiscountCollection { get ; set ; }
    }
}
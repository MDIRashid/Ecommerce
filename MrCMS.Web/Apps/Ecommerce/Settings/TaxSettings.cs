﻿using System.ComponentModel;
using MrCMS.Settings;

namespace MrCMS.Web.Apps.Ecommerce.Settings
{
    public class TaxSettings : SiteSettingsBase
    {
        [DisplayName("Input Prices Include Tax")]
        public bool LoadedPricesIncludeTax { get; set; }

        [DisplayName("Shipping Rates Include Tax")]
        public bool ShippingRateIncludesTax { get; set; }

        [DisplayName("Shipping Rate Taxes Enabled?")]
        public bool ShippingRateTaxesEnabled { get; set; }

        [DisplayName("Taxes Enabled?")]
        public bool TaxesEnabled{ get; set; }

        public override bool RenderInSettings
        {
            get { return false; }
        }
    }
}
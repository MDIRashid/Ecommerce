﻿using System.Collections.Generic;
using MrCMS.Web.Apps.Ecommerce.Entities.Discounts;

namespace MrCMS.Web.Apps.Ecommerce.Services.Discounts
{
    public interface IDiscountManager
    {
        IList<Discount> GetAll();
        Discount Get(int discountId);
        void Add(Discount discount);
        void Save(Discount discount, DiscountLimitation discountLimitation, DiscountApplication discountApplication);
        void Delete(Discount discount);
        DiscountApplication GetApplication(Discount discount, string applicationType);
        DiscountLimitation GetLimitation(Discount discount, string limitationType);
    }
}
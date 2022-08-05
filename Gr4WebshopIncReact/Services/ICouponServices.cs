using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface ICouponServices
    {
        public Coupon CreateCoupon(double amount);
        public Coupon GetById(Guid id);
        public List<Coupon> Search(string SearchPhrase);
        public Coupon Update(Coupon coupon);
        public bool Delete(Coupon coupon);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceProject.Services.Basket.Dtos
{
    public class BasketDto
    {
        public string UserId{ get; set; }

        public string DiscountCode { get; set; }

        public List<BasketItemDto> BasketItems { get; set; }

        public decimal TotalPrice
        {
            get => BasketItems.Sum(a => a.Price * a.Quantity);
        }
    }
}

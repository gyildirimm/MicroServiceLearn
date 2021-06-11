using AutoMapper;
using MicroServiceProject.Services.Order.Application.Dtos;
using MicroServiceProject.Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceProject.Services.Order.Application.Mapping
{
    public class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Domain.OrderAggregate.Order, OrderDto>().ReverseMap();

            CreateMap<OrderItem, OrderItemDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}

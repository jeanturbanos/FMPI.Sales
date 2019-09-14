using System;
using System.Collections.Generic;
using System.Text;
using FMPI.Sales.Application.Products.Dto;

namespace FMPI.Sales.Application.Products
{
    public class ProductAppService : IProductAppService
    {
        public List<ProductOutputDto> GetProducts()
        {
            var productList = new List<ProductOutputDto>();

            productList.Add(
                new ProductOutputDto
                    {
                        ItemCode = "RP130",
                        Description = "Isuzu Forward",
                        Make = "Isuzu",
                        Model = "Forward",
                        Series = "FRR34L4"
                    }
                );

            productList.Add(
                new ProductOutputDto
                {
                    ItemCode = "RP127",
                    Description = "Isuzu Elf",
                    Make = "Isuzu",
                    Model = "Elf",
                    Series = "FNKR66"
                }
                );

            return productList;
        }
    }
}

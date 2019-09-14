using FMPI.Sales.Application.Products.Dto;
using System.Collections.Generic;

namespace FMPI.Sales.Application.Products
{
    public interface IProductAppService
    {
        List<ProductOutputDto> GetProducts();
    }
}

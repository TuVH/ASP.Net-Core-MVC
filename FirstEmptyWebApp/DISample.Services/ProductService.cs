using DISample.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Services
{
    public class ProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel {Id=1,Name="tu"},
                new ProductViewModel {Id=2,Name="ha"},
                new ProductViewModel {Id=3,Name="duyen"},
            };
        }
    }
}

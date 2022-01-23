using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class Extensions{
        public static CotizaDto AsDto(this Cotiza cotiza)
        {
           return new CotizaDto
            {
                Id = cotiza.Id,
                Name = cotiza.Name,
                Price = cotiza.Price,
                Employer = cotiza.Employer,
                Description = cotiza.Description,
                CreatedDate = cotiza.CreatedDate 
            };
        }
    }
}
using System;

namespace Catalog.Dtos
{   
    public record CotizaDto
    {
        public Guid Id {get; init;}
        public string Name {get; init;}
        public decimal Price {get; init;} 
        public string Employer {get; init;}
        public string Description {get; init;}
        public DateTimeOffset CreatedDate {get; init;}

    }
}
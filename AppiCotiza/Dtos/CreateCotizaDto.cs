using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateCotizaDto{
       [Required]
       public string Name {get; init;}
       [Required]
       [Range(1,1000000)]
        public decimal Price {get; init;}
        [Required] 
        public string Employer {get; init;}
        public string Description {get; init;} 
    }
}
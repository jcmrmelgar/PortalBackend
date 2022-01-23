using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using System.Collections.Generic;
using System;
using Catalog.Dtos;
using System.Linq;

namespace Catalog.Controllers
{
    // GET /Cotizas
    [ApiController]
    [Route("cotizacion")]
    public class CotizasController : ControllerBase
    {
        private readonly ICotizasRepository repository;
        
        public CotizasController(ICotizasRepository repository)
        {
            this.repository = repository;
        }

        // GET /Cotizacion
        [HttpGet]
        public IEnumerable<CotizaDto> GetCotiza()
        {
            var cotizas = repository.GetCotizas().Select( cotiza => cotiza.AsDto());
            return cotizas;
        }

     // GET /Cotizacion/{id}
        [HttpGet("{id}")]
        public ActionResult<CotizaDto> GetCotiza(Guid id)
        {
            var cotiza = repository.GetCotiza(id);
            if(cotiza is null)
            {
                return NotFound();
            }
            return cotiza.AsDto();
        }      

      // POST /Cotizacion 
      [HttpPost]
      public ActionResult<CotizaDto> CreateCotiza(CreateCotizaDto cotizaDto )
      {
          Cotiza cotiza = new()
          {
              Id = Guid.NewGuid(),
              Name = cotizaDto.Name,
              Price = cotizaDto.Price,
              Description = cotizaDto.Description,
              Employer = cotizaDto.Employer,
              CreatedDate = DateTimeOffset.UtcNow
          };

          repository.CreateCotiza(cotiza);

        return CreatedAtAction(nameof(GetCotiza), new{ id= cotiza.Id}, cotiza.AsDto());
      }

      // PUT /Cotizacion/{id}
      [HttpPut("{id}")]
      public ActionResult UpdateCotiza(Guid id, UpdateCotizaDto cotizaDto)
      {
          var existinCotiza = repository.GetCotiza(id);
          
          if(existinCotiza is null)
          {
              return NotFound();
          } 

          Cotiza updatedCotiza = existinCotiza with
          {
              Name = cotizaDto.Name,
              Price = cotizaDto.Price,
              Description = cotizaDto.Description,
              Employer = cotizaDto.Employer
          };

           repository.UpdateCotiza(updatedCotiza);
           return NoContent();
       }

     // DELETE /Cotizacion/{id}
     [HttpDelete("{id}")]
      public ActionResult DeleteCotiza (Guid id)
      {
        var existinCotiza = repository.GetCotiza(id);
          
          if(existinCotiza is null)
          {
              return NotFound();
          } 
          repository.DeleteCotiza(id);

          return NoContent();
      }

    }
}
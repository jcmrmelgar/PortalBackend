using System;
using System.Collections.Generic;
using Catalog.Entities;
using System.Linq;

namespace Catalog.Repositories
{

    public class InMemCotizasRepository : ICotizasRepository
    {
        private readonly List<Cotiza> cotizas = new()
        {
            new Cotiza { Id = Guid.NewGuid(), Name ="Jorge Rodas", Price= 9000, Employer="empleado 1", Description="Esta es una descripcion de la cotizacion1", CreatedDate = DateTimeOffset.UtcNow},
            new Cotiza { Id = Guid.NewGuid(), Name ="Marlon Fuentes", Price= 5000, Employer="empleado 2", Description="Esta es una descripcion de la cotizacion2", CreatedDate = DateTimeOffset.UtcNow},
            new Cotiza { Id = Guid.NewGuid(), Name ="Julio Fuentes", Price= 3000, Employer="empleado", Description="Esta es una descripcion de la cotizacion2", CreatedDate = DateTimeOffset.UtcNow},
            new Cotiza { Id = Guid.NewGuid(), Name ="Armando Cabrera", Price= 1000, Employer="empleado 3", Description="Esta es una descripcion de la cotizacion3", CreatedDate = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Cotiza> GetCotizas(){
            return cotizas;
        }

        public Cotiza GetCotiza(Guid id){
          return cotizas.Where(cotiza => cotiza.Id == id ).SingleOrDefault(); 
        }

        public void CreateCotiza(Cotiza cotiza){
            cotizas.Add(cotiza);
        }

        public void UpdateCotiza(Cotiza cotiza){
            var index = cotizas.FindIndex(existingCotiza => existingCotiza.Id == cotiza.Id);
            cotizas[index] = cotiza;
        }

        public void DeleteCotiza (Guid id)
        {
            var index = cotizas.FindIndex(existingCotiza => existingCotiza.Id == id);
            cotizas.RemoveAt(index);
        }

    }
    
}
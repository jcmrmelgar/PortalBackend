using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface ICotizasRepository
    {
        Cotiza GetCotiza(Guid id);
        IEnumerable<Cotiza> GetCotizas();
        void CreateCotiza(Cotiza cotiza);

        void UpdateCotiza(Cotiza cotiza);

        void DeleteCotiza(Guid id);

    }
}
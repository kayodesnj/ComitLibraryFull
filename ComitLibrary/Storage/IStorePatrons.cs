using System;
using System.Collections.Generic;
using ComitLibrary.Models;

namespace ComitLibrary.Storage
{
    public interface IStorePatrons
    {
        void Create(Patron newPatron);
        
        void Update(Patron updatedPatron);

        Patron GetById(Guid id);

        List<Patron> GetAll();
    }
}
using Biblioteca.Models;
using System.Collections.Generic;

namespace Biblioteca.Interface
{
    public interface IDao<T> //coleção/classe genérica
    {
        void Create(T t); //
        void Update(T t);
        void Delete(int id);
        List<T> GetAll();
    }
}

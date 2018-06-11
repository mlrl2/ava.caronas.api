using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ava.caronas.api.Dominio;

namespace ava.caronas.api.Repositorio
    
{
    public abstract class ARepositorioIM <T> where T: AEntidadeBaseBloqueavel
    {
        public List<T> Entidades { get; set; } = new List<T>();
        public void Add(T entidade)
        {
            Entidades.Add(entidade);
        }

        public void Delete(T entidade)
        {
            Entidades.Remove(entidade);
        }

        public void Editar(T entidade)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            
            int i = 0;
            bool achou = false;
            while (!achou && i < Entidades.Count)
            {
                if (Entidades[i].Id == id)
                {
                    achou = true;
                    return Entidades[i];
                }
                i++;
            }
            return null;

        }
        public IEnumerable <T> List()
        {
            return Entidades;
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}

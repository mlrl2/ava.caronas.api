using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ava.caronas.api.Dominio;

namespace ava.caronas.api.Repositorio
{
    public interface IRepositorio <T> where T: AEntidadeBase
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        //pra usar um inteiro, deixa mais flexivel, passar clausulas where na lista, clausulas que estariam associadas a entidade base
        void Add(T entidade);
        void Delete(T entidade);
        void Edit(T entidade);
    }
    public abstract class AEntidadeBase
    {
        public int Id { get; protected set; }

    }
}

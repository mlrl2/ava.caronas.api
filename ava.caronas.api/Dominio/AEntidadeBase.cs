using System;
using System.Collections.Generic;
using System.Text;

namespace ava.caronas.api.Dominio
{
    public abstract class AEntidadeBase
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public AEntidadeBase()
        {
            CreateDate = DateTime.Now;
        }
        public abstract bool IsAtivo();
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ava.caronas.api.Dominio
{
    public abstract class AEntidadeBaseBloqueavel : AEntidadeBase, IBloqueavel
    {
        private bool block;
        public void Bloqueado()
        {
            block = false;
        }

        public void Desbloqueia()
        {
            block = true;
        }

        public bool SeraQueBloqueou()
        {
            return block;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ava.caronas.api.Dominio
{
    public interface IBloqueavel
    {
        void Bloqueado();
        void Desbloqueia();
        bool SeraQueBloqueou();
    }
}

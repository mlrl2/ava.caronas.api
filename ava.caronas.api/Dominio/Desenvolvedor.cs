using System;
using System.Collections.Generic;
using System.Text;

namespace ava.caronas.api.Dominio
{
    public class Desenvolvedor: AEntidadeBase, IComparavel
    {
        public int CareerLevel { get; set; }
        public char Status { get; set; }

        public int Comparar (object i, object j)
        {
            if ((i as Desenvolvedor).CareerLevel > (j as Desenvolvedor).CareerLevel)
                return 1;
            else if ((i as Desenvolvedor).CareerLevel == (j as Desenvolvedor).CareerLevel)
                return 0;
            else return -1;
        }

        public override bool IsAtivo()
        {
            return (Status == 'A' || Status == 'M');
        }
    }
}

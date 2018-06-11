using System;
using System.Collections.Generic;
using System.Text;
using ava.caronas.api.Repositorio;

namespace ava.caronas.api.Dominio
{
    public class RepositorioColaborador
    {
        public List <Colaborador> Colaboradores { get; set; } = new List<Colaborador>();
        public void AddColaborador (Colaborador colaborador)
        {
            Colaboradores.Add(colaborador);
        }
        public Colaborador ObterEID(string eid)
        {
            int i = 0;
            bool achou = false;
            while (!achou && i < Colaboradores.Count)
            {
                if (Colaboradores[i].EID == eid)
                {
                    achou = true;
                    return Colaboradores[i];
                }
                i++;
            }
            return null;
        }


        public Colaborador ObterPID(int pid)
        {
            int i= 0;
            bool achou = false;
            while (!achou && i< Colaboradores.Count )
            {
                if (Colaboradores[i].PID == pid)
                {
                    achou = true;
                    return Colaboradores[i];
                }
                i++;
            }
            return null;
        }
        public void DeleteColaborador(Colaborador colaborador)
        {
            Colaboradores.Remove(colaborador);
        }
    }
}

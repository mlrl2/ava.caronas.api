using System;

namespace ava.caronas.api.Dominio

{
    public class Colaborador: AEntidadeBaseBloqueavel
    {
        public string Nome { get; set; }
        public string EID { get; set; }
        public int PID { get; set; }


        public Colaborador(string nome, string eid, int pid)
        {
            Nome = nome;
            EID = eid;
            PID = pid;
        }

        public override bool IsAtivo()
        {
            throw new NotImplementedException();
        }
    }
    

}

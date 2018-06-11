using System;

namespace ava.caronas.api.Dominio
{
    public class Carona: AEntidadeBaseBloqueavel
    {
        public Colaborador Ofertante { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public Endereco EnderecoSaida { get; set; }
        public Endereco EnderecoChegada { get; set; }
        public int VagasTotais { get; set; }
        public int VagasDisponiveis { get; set; }
        public int ID { get; set; }

        private Carona(int vagas, Colaborador ofertante)
        {
            VagasTotais = VagasDisponiveis = vagas;
            Ofertante = ofertante;
        }
        public static Carona CreateCarona(int vagas, Colaborador ofertante) {
            if (vagas > 6) return null;
            if (ofertante == null) return null;
            return new Carona(vagas, ofertante);
        }

        public bool OcuparVaga()
        {
            if (VagasDisponiveis>0)
            {
                VagasDisponiveis = VagasDisponiveis - 1;
                return true;
            }
        return false;
        }

        public override bool IsAtivo()
        {
            throw new NotImplementedException();
        }
    }
}

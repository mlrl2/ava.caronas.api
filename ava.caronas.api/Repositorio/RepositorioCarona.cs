using System;
using System.Collections.Generic;
using System.Text;
using ava.caronas.api.Dominio;

namespace ava.caronas.api.Repositorio

{
    public class RepositorioCarona
    { 
        public List<Carona> Caronas { get; set; } = new List<Carona>();
        public void AddCarona(Carona carona)
        {
            SetID(carona);
            Caronas.Add(carona);
        }
       
        public int SetID(Carona carona)// Cada carona vai ter ID diferente de ID do colaborador
        {
            if (Caronas.Count == 0)
            {
                carona.ID = 1;
                return carona.ID;
            }
            else
            {
                carona.ID = Caronas[Caronas.Count - 1].ID + 1;
                return carona.ID;
            }

        }
        public Carona GetByID(int id) // Pegar a Carona pelo ID da carona
        {
            int i = 0;
            bool achou = false;
            while (!achou && i < Caronas.Count)
            {
                if (Caronas[i].ID == id)
                {
                    achou = true;
                    return Caronas[i];
                }
                i++;
            }
            return null;

        }
        
        public void DeleteCarona(Carona carona)
        {
            Caronas.Remove(carona);
        }

    }
    
}

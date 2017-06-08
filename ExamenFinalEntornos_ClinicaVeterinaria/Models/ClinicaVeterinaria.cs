using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalEntornos_ClinicaVeterinaria.Models
{
    class ClinicaVeterinaria
    {
        public List<Animal> Clinica { get; set; }

        public ClinicaVeterinaria() {
        }

        //INSERTA UN ANIMAL A LA LISTA
        public void InsertaAnimal(Animal a)
        {
            Clinica.Add(a);
        }

        //BUSCA UN ANIMAL EN LA LISTA A PARTIR DE SU NOMBRE Y POSTERIORMENTE DEVUELVE AL ANIMAL
        public Animal BuscaAnimal(string nombre)
        {
            Animal animalito=null;
            foreach(Animal a in Clinica)
            {
                if (nombre.Equals(a.Nombre))
                {
                    animalito=a;
                }
                else
                {
                    throw new Exception("No existe ese animal");
                }
            }
            return animalito;
        }

        //MODIFICA EL COMENTARIO DEL ANIMAL CUYO NOMBRE SE LE PASA
        public void ModificaComentarioAnimal(string nombre,string comentario)
        {
           
            foreach (Animal a in Clinica)
            {
                if (nombre.Equals(a.Nombre))
                {
                    a.Comentarios = comentario;
                }
                else
                {
                    throw new Exception("No existe ese animal");
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", Clinica);
        }

      
    }
}

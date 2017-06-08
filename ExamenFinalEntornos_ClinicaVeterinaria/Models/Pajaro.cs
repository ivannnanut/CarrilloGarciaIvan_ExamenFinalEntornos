using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalEntornos_ClinicaVeterinaria.Models
{
    class Pajaro : Animal
    {
        //ATRIBUTOS
        private string _especie;
        private bool _cantor;

        //CONSTRUCTOR
        public Pajaro(string nombre, string fecha, double peso, string especie,bool cantor) :base(nombre,fecha, peso)
        {
            this._especie = especie;
            this._cantor = cantor;
        }

        //PROPIEDADES
        public string Especie
        {
            get
            {
                return _especie;
            }
        }

        public bool Cantor
        {
            get
            {
                return _cantor;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", Nombre, FechaNacimiento, Peso, Especie,Cantor, Comentarios);
        }
    }
}

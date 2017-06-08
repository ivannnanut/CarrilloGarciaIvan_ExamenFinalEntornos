using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalEntornos_ClinicaVeterinaria.Models
{
    class Reptil : Animal
    {
        //ATRIBUTOS
        private string _especie;
        private bool _venenoso;

        //CONSTRUCTOR
        public Reptil(string nombre, string fecha, double peso, string especie, bool venenoso) :base(nombre,fecha, peso)
        {
            this._especie = especie;
            this._venenoso = venenoso;
        }

        //PROPIEDADES
        public string Especie
        {
            get
            {
                return _especie;
            }
        }

        public bool Venenoso
        {
            get
            {
                return _venenoso;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", Nombre, FechaNacimiento, Peso, Especie, Venenoso, Comentarios);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalEntornos_ClinicaVeterinaria.Models
{
    class Perro : Animal
    {
        //ATRIBUTOS
        private string _raza;
        private string _microchip;

        //CONSTRUCTOR
        public Perro(string nombre,string fecha,double peso,string raza,string microchip) :base(nombre,fecha,peso)
        {
            this._raza = raza;
            this._microchip = microchip;
        }

        //PROPIEDADES
        public string Raza
        {
            get
            {
                return _raza;
            }
        }

        public string Microchip
        {
            get
            {
                return _microchip;  
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", Nombre,FechaNacimiento,Peso,Raza,Microchip,Comentarios);
        }
    }
}

using ExamenFinalEntornos_ClinicaVeterinaria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalEntornos_ClinicaVeterinaria.Models
{
   abstract class Animal : IPesable
    {
        protected string _nombre;
        protected string _fechaNacimiento;
        protected double _peso;
        protected string _comentarios;


        public Animal(string nombre, string fecha, double peso)
        {
            this._nombre = nombre;
            this._fechaNacimiento = fecha;
            this._peso = peso;   
        }

        public Animal(string nombre, string fecha, double peso,string comentarios)
        {
            this._nombre = nombre;
            this._fechaNacimiento = fecha;
            this._peso = peso;
            this._comentarios = comentarios;
        }

        public void Pesar(double peso)
        {
            Console.WriteLine(peso);
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
        }

        public double Peso
        {
            get
            {
                return _peso;
            }
        }

        public string Comentarios
        {
            get
            {
                return _comentarios;
            }
            set
            {
                _comentarios = value;
            }
        }

        public static implicit operator Animal(int v)
        {
            throw new NotImplementedException();
        }
    }
}

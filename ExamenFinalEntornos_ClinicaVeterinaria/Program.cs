using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinalEntornos_ClinicaVeterinaria.Models;

namespace ExamenFinalEntornos_ClinicaVeterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double peso = 0;
            string nombre = "";
            string comentario = "";
            string fecha = "";
            string raza = "";
            string microchip = "";
            string especie = "";
            bool cantor = false;
            bool venenoso = false;

            var Veterinario = new ClinicaVeterinaria();

          
                MenuPrincipal();
                opcion = Int32.Parse(Console.ReadLine());
                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opcion invalida\n");
                    MenuPrincipal();
                }


                switch (opcion)
                {

                

                case 1:
                        MenuInsertarAnimal();
                        opcion = Int32.Parse(Console.ReadLine());
                        if (opcion < 1 || opcion > 4)
                        {
                            Console.WriteLine("Opcion invalida\n");
                            MenuInsertarAnimal();
                        }

                        switch (opcion)
                        {
                            case 1:
                                nombre = Nombre();
                                fecha = Fecha();
                                peso = Peso();
                                raza = Raza();
                                microchip = Microchip();
                                Perro perrito = new Perro(nombre, fecha, peso, raza, microchip);
                                Veterinario.InsertaAnimal(perrito);
                                MenuPrincipal();
                            break;

                            case 2:
                                nombre = Nombre();
                                fecha = Fecha();
                                peso = Peso();
                                raza = Raza();
                                microchip = Microchip();
                                Gato gatito = new Gato(nombre, fecha, peso, raza, microchip);
                                Veterinario.InsertaAnimal(gatito);
                            MenuPrincipal();
                            break;

                            case 3:
                                nombre = Nombre();
                                fecha = Fecha();
                                peso = Peso();
                                especie = Especie();
                                Console.WriteLine("¿Es porculero?\n");
                                string porculero = Console.ReadLine();
                                if (porculero == "si" || porculero == "lo es" || porculero == "pos claro mi arma")
                                {
                                    cantor = true;
                                }
                                else
                                {
                                    cantor = false;
                                }

                                Pajaro pajaroto = new Pajaro(nombre, fecha, peso, especie, cantor);
                                Veterinario.InsertaAnimal(pajaroto);
                            MenuPrincipal();
                            break;

                            case 4:
                                nombre = Nombre();
                                fecha = Fecha();
                                peso = Peso();
                                especie = Especie();
                                Console.WriteLine("¿Te puede matar al tocarlo?\n");
                                string venenosito = Console.ReadLine();
                                if (venenosito == "si" || venenosito == "aro que si" || venenosito == "pos claro mi arma")
                                {
                                    venenoso = true;
                                }
                                else
                                {
                                    venenoso = false;
                                }

                                Reptil CobraGay = new Reptil(nombre, fecha, peso, especie, venenoso);
                                Veterinario.InsertaAnimal(CobraGay);
                            MenuPrincipal();
                            break;
                        }
                        break;

                    case 2:
                        nombre = Nombre();
                        comentario = Comentario();
                        Veterinario.ModificaComentarioAnimal(nombre, comentario);
                    MenuPrincipal();
                    break;

                    case 3:
                        nombre = Nombre();
                        peso = Peso();
                        Pesar(nombre, peso);
                    MenuPrincipal();
                    break;

                    case 4:
                    nombre = Nombre();
                    Console.WriteLine(Veterinario.BuscaAnimal(nombre));
                    MenuPrincipal();
                    break;

                    case 5:
                        Console.WriteLine("Nos vemos JOSELITOOOO");
                        break;


                }
           

        }

        //MENU PRINCIPAL DE LA CLINICA
        public static void MenuPrincipal()
        {
            Console.WriteLine("......MENU PRINCIPAL......");
            Console.WriteLine("1------------Añadir animal");
            Console.WriteLine("2-----Modificar comentario");
            Console.WriteLine("3-------------Pesar animal");
            Console.WriteLine("4-----Mostrar ficha animal");
            Console.WriteLine("5-------Salir del Programa\n");
        }

        //MENU PARA INSERTAR ANIMALES
        public static void MenuInsertarAnimal()
        {
            Console.WriteLine(".....INSERTAR ANIMAL.....");
            Console.WriteLine("1-------------------Perro");
            Console.WriteLine("1--------------------Gato");
            Console.WriteLine("1------------------Pajaro");
            Console.WriteLine("1------------------Reptil\n");
        }

        //MUESTRA EL NUEVO PESO DEL ANIMAL
        public static void Pesar(string nombre, double peso)
        {
            Console.WriteLine(nombre + " ahora pesa " + peso);
        }

        //EL RESTO DE METODOS VALIDAN LOS ATRIBUTOS NECESARIOS DE LOS ANIMALES PARA QUE MUESTREN ERROR SI ESTAN VACIOS
        public static string Nombre()
        {
            string nombre="";
            do
            {
                Console.WriteLine("Introduce el nombre del animal\n");
                nombre = Console.ReadLine();
                if (nombre == "")
                {
                    Console.WriteLine("Has dejado el campo vacio \n");
                }
            } while (nombre == "");
            return nombre;
        }

        public static double Peso()
        {
            double peso = 0;
            do
            {
                Console.WriteLine("Introduce el peso del animal\n");
                peso = Double.Parse(Console.ReadLine());
                if (peso <= 0)
                {
                    Console.WriteLine("Peso invalido\n");
                }
            } while (peso <=0);
            return peso;
        }

        public static string Comentario()
        {
            string comentario="";
            do
            {
                Console.WriteLine("Introduce el comentario del animal\n");
                comentario = Console.ReadLine();
                if(comentario == "")
                {
                    Console.WriteLine("Has dejado el campo vacio \n");
                }
            } while (comentario == "");
            return comentario;
        }

        public static string Fecha()
        {
            string fecha = "";
            do
            {
                Console.WriteLine("Introduce la fecha de nacimiento del animal\n");
                fecha = Console.ReadLine();
                if (fecha == "")
                {
                    Console.WriteLine("Has dejado el campo vacio \n");
                }
            } while (fecha == "");
            return fecha;
        }

        public static string Raza()
        {
            string raza = "";
            do
            {
                Console.WriteLine("Introduce la raza del animal\n");
                raza = Console.ReadLine();
                if (raza == "")
                {
                    Console.WriteLine("Has dejado el campo vacio \n");
                }
            } while (raza == "");
            return raza;
        }

        public static string Microchip()
        {
            string microchip = "";
            do
            {
                Console.WriteLine("Introduce el microchip del animal\n");
                microchip = Console.ReadLine();
                if (microchip == "")
                {
                    Console.WriteLine("Has dejado el campo vacio \n");
                }
            } while (microchip == "");
            return microchip;
        }

        public static string Especie()
        {
            string especie = "";
            do
            {
                Console.WriteLine("Introduce la especie del animal\n");
                especie = Console.ReadLine();
                if (especie == "")
                {
                    Console.WriteLine("Has dejado el campo vacio \n");
                }
            } while (especie == "");
            return especie;
        }
    }

   

    
}

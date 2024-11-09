using System;

namespace ReservaVuelo{
    class Program{
        
        public static void Main(){
            //Pasajeros p = new Pasajeros();
            int opcion;
            do{
                Console.WriteLine("+++ RESERVA DE VUELO +++");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Elegir una de las opciones: \n    [1] Reservar Asiento \n    [2] Cancelar Reserva \n    [3] Mostrar Estado de un Avión"
                +" \n    [4] Ver Lista de Pasajeros \n    [5] SALIR");
                Console.Write("QUE OPCION VA ELEGIR?   ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion){
                    case 1:
                        //p.Reservar();
                        break;
                    case 2:
                        //p.Cancelar();
                        break;
                    case 3:
                        //p.Mostrar();
                        break;
                    case 4:
                        //p.VerLista();
                        break;
                    case 5:
                        Console.WriteLine("RESERVA EXITOSA, GRACIAS POR CONFIAR EN NUESTRO SISTEMA DE RESERVA DE VUELOS");
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        Console.WriteLine("Compruebe bien la informacion y vuelva a intentar de nuevo.");
                        break;
                }
            } while (opcion != 5);
        }
    }
}
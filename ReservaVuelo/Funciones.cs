using System;
using System.Collections;
using ReservaVuelo;

public class Funciones
{
    private List<Asiento[]> aviones = new List<Asiento[]>();
    private LinkedList<Pasajero> listaCircularPasajeros = new LinkedList<Pasajero>(); 
    private Queue<Pasajero> listaEspera = new Queue<Pasajero>();
   
    public void ReservarAsiento(string nombre, int numeroAvion)
    {
        if (numeroAvion < 1 || numeroAvion > aviones.Count)
        {
            Console.WriteLine("Número de avión no válido.");
            return;
        }

        Asiento[] avion = aviones[numeroAvion - 1];
        bool asientoReservado = false;

        for (int i = 0; i < avion.Length; i++)
        {
            if (avion[i].Estado == "L") 
            {
                avion[i].Estado = "O"; 
                listaCircularPasajeros.AddLast(new Pasajero(nombre));
                Console.WriteLine($"Asiento {i + 1} reservado para {nombre} en el avión {numeroAvion}.");
                asientoReservado = true;
                break;
            }
        }

        if (!asientoReservado)
        {
            Console.WriteLine("No hay asientos disponibles. Añadiendo a la lista de espera...");
            listaEspera.Enqueue(new Pasajero(nombre));
        }
    }

    
    public void CancelarReserva(string nombre, int numeroAvion)
    {
        if (numeroAvion < 1 || numeroAvion > aviones.Count)
        {
            Console.WriteLine("Número de avión no válido.");
            return;
        }

        Asiento[] avion = aviones[numeroAvion - 1];
        bool reservaEncontrada = false;

       
        foreach (var pasajero in listaCircularPasajeros)
        {
            if (pasajero.Nombre == nombre)
            {
                listaCircularPasajeros.Remove(pasajero);
                reservaEncontrada = true;
                Console.WriteLine($"Reserva de {nombre} cancelada.");
                break;
            }
        }

        if (reservaEncontrada)
        {
           
            for (int i = 0; i < avion.Length; i++)
            {
                if (avion[i].Estado == "O")
                {
                    avion[i].Estado = "L";
                    Console.WriteLine($"Asiento {i + 1} liberado en el avión {numeroAvion}.");

                    
                    if (listaEspera.Count > 0)
                    {
                        Pasajero pasajeroEnEspera = listaEspera.Dequeue();
                        avion[i].Estado = "O";
                        listaCircularPasajeros.AddLast(pasajeroEnEspera);
                        Console.WriteLine($"Asignado el asiento {i + 1} a {pasajeroEnEspera.Nombre} de la lista de espera.");
                    }
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine($"Pasajero {nombre} no encontrado.");
        }
    }
   
}

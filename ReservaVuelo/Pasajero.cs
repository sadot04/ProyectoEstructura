using System;

namespace ReservaVuelo;


public class Pasajero{

    string nombre = "";
    string apellido = "";
    int ci = 0;
    int edad = 0;
    int celular = 0;
    int nro_asiento = 0;


    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Ci { get => ci; set => ci = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Celular { get => celular; set => celular = value; }
    public int Nro_asiento { get => nro_asiento; set => nro_asiento = value; }


    public Pasajero(){
        nombre = Nombre;
        apellido = Apellido;
        ci = Ci;
        edad = Edad;
        celular = Celular;
        nro_asiento = Nro_asiento;
    }
}
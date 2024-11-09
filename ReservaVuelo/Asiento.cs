using System;

namespace ReservaVuelo;


public class Asiento{

    bool libre = true;

    public bool Libre { get => libre; set => libre = value; }


    public Asiento(){
        libre = Libre;
    }
}


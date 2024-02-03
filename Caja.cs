using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace MaquinaExp{


//atributos
    public class Caja{


 double cobrar;
 //fin

    public Caja(double credito){
    this.cobrar=credito;

    

    }

    public int cobrarproducto(double pago, double precioProducto,int contador){
    double pagotemp=pago;
    double preciotemp=precioProducto;
    double cambio;
    int contadortemp=contador;

    if (pagotemp<preciotemp){
         Console.WriteLine("Crédito insuficiente");

        
    
    }
    else{
        cambio=pagotemp-preciotemp;
        Console.WriteLine("su cambion es: "+ cambio);
        contador=contador-1;
        return contador;


    

    }
    return 0;

    
    }





    }


}
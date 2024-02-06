using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace MaquinaExp{

//clase caja
    public class Caja{

//atributos
 double cobrar;
 int contador;
 //fin

//constructor
    public Caja(double credito, int contadorInicial ){
    this.cobrar=credito;
    this.contador=contadorInicial=5;
    }

    //metodo

    public void cobrarproducto(double pago, double precioProducto){
    double pagotemp=pago;
    double preciotemp=precioProducto;
    double cambio;


    if (pagotemp<preciotemp){
         Console.WriteLine("Crédito insuficiente");
    
    }
    else{
        cambio=pagotemp-preciotemp;
        Console.WriteLine("su cambion es: "+ cambio);

    }

    }

}
 }
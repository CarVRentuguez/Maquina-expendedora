namespace MaquinaExp{


public class Slot{
string codigo {get;set;}
Producto produc{get;set;}
int contador=10;


public Slot (string codigo,Producto produc){

    this.codigo= codigo;
    this.produc=produc;


}

public Producto buscarp(Slot s){
    
return s.produc;

}

public int devolvercontador(Slot s){


 if (contador > 0)
            {
                contador--;
            }
            else
            {
                
                Console.WriteLine("No hay suficientes productos en stock.");
                
            }

return  s.contador;
}




}


}


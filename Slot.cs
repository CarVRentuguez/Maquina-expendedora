namespace MaquinaExp{


public class Slot{
string codigo {get;set;}
Producto produc{get;set;}
int contador=5;


public Slot (string codigo,Producto produc){

    this.codigo= codigo;
    this.produc=produc;


}

public Producto buscarp(Slot s){
return s.produc;

}

public int devolvercontador(Slot s){
return  s.contador;

}


}


}


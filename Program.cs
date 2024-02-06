using System.Runtime.Serialization;

namespace MaquinaExp;

class Program
{
    static void Main(string[] args)
    {
        
        Slot[] arregloslots = new Slot[9];
        Producto p=new Producto(0,"chetos",13);
        Producto p2=new Producto(1,"Doritos",14);
        Producto p3=new Producto(2, "Pepsi",22);
        Producto p4=new Producto(3,"chetos",20);
        Producto p5=new Producto(4,"Doritos",19);
        Producto p6=new Producto(5, "Pepsi",18);
        Producto p7=new Producto(6,"chetos",15);
        Producto p8=new Producto(7,"Doritos",17);
        Producto p9=new Producto(8, "Pepsi",10);

        arregloslots[0] = new Slot("codigo1",p);
        arregloslots[1] = new Slot("codigo2",p2);
        arregloslots[2] = new Slot("codigo3",p3);
        arregloslots[3] = new Slot("codigo4",p4);
        arregloslots[4] = new Slot("codigo5",p5);
        arregloslots[5] = new Slot("codigo6",p6);
        arregloslots[6] = new Slot("codigo7",p7);
        arregloslots[7] = new Slot("codigo8",p8);
        arregloslots[8] = new Slot("codigo9",p9);

        MaquinaExp M = new MaquinaExp(arregloslots);
        
        while(true){
        Console.WriteLine("             'MENU'        ");
        Console.WriteLine("                           ");

        Console.WriteLine("Nombre       codigo   precio");
        Console.WriteLine("Cheetos        0        13");
        Console.WriteLine("Doritos        1        14");
        Console.WriteLine("Pepsi          2        22");
        Console.WriteLine("Pinguinos      3        20");
        Console.WriteLine("Rancheritos    4        19");
        Console.WriteLine("Rufless        5        18");
        Console.WriteLine("Coca cola      6        15");
        Console.WriteLine("Gansito        7        17");
        Console.WriteLine("Nito           8        10");



        Console.WriteLine("Ingrese el codigo de la casilla");
        int casilla;
        casilla= Convert.ToInt32(Console.ReadLine());
    

        Slot slot4 =M.buscar(arregloslots[casilla]); //
        
        Producto pbuscar=slot4.buscarp(slot4);
        int contador_slot=slot4.devolvercontador(slot4);



        String nombredelproducto=p.productobuscarnombre(pbuscar);
        Console.WriteLine("El nombre del producto es" + " " + nombredelproducto);
        int idproducto=p.idproducto(pbuscar);
        Console.WriteLine("el id del producto es"+ " " + " " + idproducto);
        double precioProducto=p.preciop(pbuscar);
        Console.WriteLine("El precio del producto es" + " " + precioProducto);

        Console.WriteLine("Ingrese el dinero");
        double pago;
        pago=Convert.ToDouble(Console.ReadLine());

        Caja cajita=new Caja ( pago, contador_slot); //instanciado

        
        
        int contadornuevo=slot4.devolvercontador(slot4); //<---- contador
        Console.WriteLine("Producto en existencia: " + contadornuevo);

        cajita.cobrarproducto(pago,precioProducto);

        

        Console.WriteLine("Si desea volver a comprar pulse A");
        string continuar=Console.ReadLine();
        if(continuar!="A"){
            break;
        }

        }





    }
}

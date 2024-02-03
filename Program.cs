namespace MaquinaExp;

class Program
{
    static void Main(string[] args)
    {
        
        Slot[] arregloslots = new Slot[3];
        Producto p=new Producto(0,"chetos",13);
        Producto p2=new Producto(1,"Doritos",14);
        Producto p3=new Producto(2, "Pepsi",22);

        arregloslots[0] = new Slot("codigo1",p);
        arregloslots[1] = new Slot("codigo2",p2);
        arregloslots[2] = new Slot("codigo3",p3);
        
        MaquinaExp M = new MaquinaExp(arregloslots);
        while(true){
        Console.WriteLine("MENU");
         Console.WriteLine("Cheetos codigo------0");

        



        Console.WriteLine("Ingrese el codigo de la casilla");
        int casilla;
        casilla= Convert.ToInt16(Console.ReadLine());

    

        Slot slot4 =M.buscar(arregloslots[casilla]); //<---- este slot es el que nos sirve de bandera

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

        Caja cajita=new Caja(pago); //instanciamos una caja

        cajita.cobrarproducto(pago,precioProducto,contador_slot);
        int contadornuevo=slot4.devolvercontador(slot4); //<---- por verificar

        Console.WriteLine("Aque en existencia " + contadornuevo);

        Console.WriteLine("Si desea volver a comprar pulse A");
        string continuar=Console.ReadLine();
        if(continuar!="A"){
            break;
        }

        }





    }
}

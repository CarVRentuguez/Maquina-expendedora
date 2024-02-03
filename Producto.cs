namespace MaquinaExp{

    public class Producto{

        int id{get;set;}
        string nombre{get;set;}
        double precio{get;set;}

        public Producto( int id, string nombre, double precio  ){

            this.id= id; 
            this.nombre=nombre;
            this.precio=precio;
            

        }

        public string productobuscarnombre(Producto p){
        return p.nombre;


        }
        public int idproducto(Producto p){
        return p.id;

        }

        public double preciop(Producto p){
        return p.precio;

        }


        


    }
}


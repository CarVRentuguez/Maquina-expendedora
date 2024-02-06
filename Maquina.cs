using System.Collections;
using System.ComponentModel;
using System.Dynamic;

namespace  MaquinaExp
{

public class MaquinaExp{


 Slot[] arregloslots = new Slot[9];



 public MaquinaExp(Slot[] arregloslots){
    this.arregloslots=arregloslots;
 }

public Slot buscar(Slot s){

foreach(Slot item in this.arregloslots){

    if(item.Equals(s)){
         return item;
    }
    
}
return null;


}






     










}




}


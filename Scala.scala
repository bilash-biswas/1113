import java.util.Scanner;
import scala.util.control.Breaks._
object Main {
  def main(args:Array[String]){ 
    val input = new Scanner(System.in)
    breakable  {
    while(true)
    {
    var a=input.nextInt()
    var b=input.nextInt()
    if(a==b){
        break
    }
     if(a>b)
    {
        printf("Decrescente\n")
    }
    if(a<b)
    {
        printf("Crescente\n")
    }
    }
    }

}
}
 

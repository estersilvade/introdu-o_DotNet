namespace Classes.Metodos// parametros do tipo ref  
{
  public class Ref
  {
    static void Inverter(ref int x, ref int y)// indica que ela vai receber por referencia 
    {
      int temp = x;
      x = y;
      y = temp;
    }
    public static void Inverter()
    {
      int i = 1, j = 2;
      Inverter(ref i, ref j);
      System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
    }
  }
}
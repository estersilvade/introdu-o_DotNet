namespace Classes.Herança
{
    public class Ponto3D : Ponto //erdando a class ponto  e ele so pode erda de uma class 
    {
        public int z;// ele passa   depois dos dois pontos a base que é o xy 
        public Ponto3D(int x, int y, int z) : base(x, y)  
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}
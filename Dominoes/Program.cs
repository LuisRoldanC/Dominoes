class Domino {
private int d1;
    private int d2;
    public int total;
    public Domino(int d1, int d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }
    public static int operator +(Domino a, Domino b)
    {
       int d1 = a.d1 + b.d2;
       int d2 = a.d2 * b.d2;
         return d1+d2;
    }
}
internal class Program
{
    /*
    public int d1;
    public int d2;
    public int total;
    public Program(int d1, int d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }
    public static Program operator +(Program a, Program b)
    {
       int d1 = a.d1 * b.d2 + a.d2 * b.d1 ;
       int d2 = a.d2 * b.d2;
       return new Program(d1, d2);
    }*/
    private static void Main(string[] args)
    {
        Domino a = new Domino(0, 1);
        Domino b = new Domino(2, 3);
        int total = a + b;

        Console.WriteLine(total);
      
    }
}
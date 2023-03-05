internal class Program
{
    private static void Main(string[] args)
    {
        //fibonacci 

        int n1=1, n2=0, aux, position;
        string t = "";

        Console.WriteLine("digite a posicao do fibonacci: ");
        position = int.Parse(Console.ReadLine());

        
        if (position >= 1)
        {
            for (int i = 0; i < position; i++)
            {
                aux = n2;
                n2 += n1;
                n1 = aux;

                t += n2+" ";
            }
            Console.WriteLine(t);
        }
        else
        {
            Console.WriteLine("nao contempla");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //fibonacci 2


        int n1 = 1, n2 = 0, position;
        string t = "";

        Console.WriteLine("digite a posicao do fibonacci: ");
        position = int.Parse(Console.ReadLine());


        if (position >= 1)
        {
            for (int i = 0; i < position; i++)
            {
                n2 = n1 + n2;
               

                n1 = n2 - n1;

                Console.WriteLine(n2);

            }
            
        }
        else
        {
            Console.WriteLine("nao contempla");
        }

    }
}
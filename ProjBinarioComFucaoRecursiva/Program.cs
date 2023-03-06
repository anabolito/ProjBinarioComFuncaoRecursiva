internal class Program
{
    private static void Main(string[] args)
    {
        int nDecimal;
        int nBinario;
        int[] posicao = new int[8];

        Console.Write("Informe um valor inteiro para ser convertido em binário: ");
        nDecimal = int.Parse(Console.ReadLine());
        nBinario = binario(nDecimal);
        Console.WriteLine(nBinario);

        int divPorDois(int n)
        {
            if (n / 2 == 1)
                return 0;
            else
                return n % 2;                
        }

        int binario(int n)
        {
            Console.Write("A conversão do número decimal " + n + " para binário é ");

            int i;
            
            for ( i = 0; i <= 7; i++)
            {
                posicao[i] = divPorDois(n);
                if (n % 2 == 1)
                    n = (n - 1) / 2;
                else
                    if (n / 2 > 0)
                    n = n / 2;
                    else
                    n = 2;
            }
            Console.Write(posicao[0]);
            for ( i=7; i > 0; i--)
            {
                Console.Write(posicao[i]);
            }               
            return n;
        }
    }
}
// binário de 141 : 10001101
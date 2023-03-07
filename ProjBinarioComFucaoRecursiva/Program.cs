internal class Program
{
    private static void Main(string[] args)
    {
        int numero, i = 7;
        int[] bin = new int[8];
        Console.Write("Informe o valor a ser convertido em binário: ");
        numero = int.Parse(Console.ReadLine());

        binario(numero);

        for (i = 0; i < 8; i++)
        {
            Console.Write(bin[i]);
        }
        int binario(int numero)
        {
            if (numero > 0)
            {
                bin[i] = numero % 2;
                i--;
                return binario(numero / 2);
            }
            return 0;
        }
    }
}


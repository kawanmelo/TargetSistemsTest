namespace Question5_InverterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teste = "TargetSystems";
            string stringInvertida = ReverseString(teste);

            Console.WriteLine(teste);
            Console.WriteLine(stringInvertida);
        }

        public static string ReverseString(string str)
        {
            char[] caracteres = str.ToCharArray();
            int tamanho = caracteres.Length;

            for (int i = 0; i < tamanho / 2; i++)
            {
                char temp = caracteres[i];
                caracteres[i] = caracteres[tamanho - 1 - i];
                caracteres[tamanho - 1 - i] = temp;
            }

            return new string(caracteres);
        }
    }
}

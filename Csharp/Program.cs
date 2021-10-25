

using System.Collections.Generic;

public class Program
{
    public void Main()
    {
        char[] primeiraSequencia = new char[] { 'A', 'B', 'X', 'O' };
        char[] segundaSequencia = new char[] { 'X', 'P', 'T', 'O', 'A', 'B', 'X', 'O', 'V', 'B', 'X', 'G', 'H', 'O', 'A', 'B', 'X', 'A', 'B', 'X', 'A', 'B', 'X', 'O', 'O', 'P', 'T', 'V', 'B' };

        ComparaSequencias(primeiraSequencia, segundaSequencia);
    }

    public int[] ComparaSequencias(char[] primeiraSequencia, char[] segundaSequencia)
    {
        int tamanhoPrimeiraSequencia = primeiraSequencia.Length;
        int tamanhoSegundaSequencia = segundaSequencia.Length;
        List<int> indices = new List<int>();

        for (int i = 0; i < (tamanhoSegundaSequencia - tamanhoPrimeiraSequencia); i++)
        {
            if (segundaSequencia[i] == primeiraSequencia[0])
            {
                if (segundaSequencia.ToString().Substring(i, tamanhoPrimeiraSequencia) == primeiraSequencia.ToString())
                    indices.Add(i);
            }
        }

        return indices.ToArray();
    }
}
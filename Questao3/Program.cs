using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "ifailuhkqq";

            var resultado = ParesSubstring(s);        

            Console.WriteLine(resultado);
        }

        public static int ParesSubstring(string s)
        {
            var contador = 0;
            for (var l = 1; l <= s.Length; l++)
            {
                for (var i = 0; i <= s.Length - l - 1; i++)
                {
                    var arr1 = s.Substring(i, l).ToCharArray();
                    Array.Sort(arr1);
                    for (var j = i + 1; j <= s.Length - l; j++)
                    {
                        var arr2 = s.Substring(j, l).ToCharArray();
                        Array.Sort(arr2);

                        var anagrama = true;
                        for (var n = 0; n < arr1.Length; n++)
                        {
                            if (arr1[n] != arr2[n])
                            {
                                anagrama = false;
                                break;
                            }
                            if (anagrama && s.Length < 4) contador ++;
        
                        }
                        if (anagrama && s.Length > 3) contador++;

                    }
                }
            }
            return contador;
        }
    }
}

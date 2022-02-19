using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Digite sua senha: ");
                var senha = Console.ReadLine();

                if (senha.Length < 6)
                {
                    var caracteresRestantes = (6 - senha.Length);
                    Console.WriteLine($"Você deve adicionar pelo menos mais {caracteresRestantes} caracteres.\n");

                    AdicionarCaracteres(ref senha, caracteresRestantes);
                }

                if (SenhaValida(ref senha))
                {
                    Console.WriteLine("Senha cadastrada com sucesso!");
                    break;
                } 
            }
        }

        public static bool SenhaValida(ref string senha)
        {
            char[] cEspeciais = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+'  };
            bool digito = false, maiuscula = false, minuscula = false, especiais = false;

            foreach (char letra in senha)
            {
                if (letra >= 'A' && letra <= 'Z')
                    maiuscula = true;

                if (letra >= 'a' && letra <= 'z')
                    minuscula = true;

                if (letra >= '0' && letra <= '9')
                    digito = true;

                if (senha.IndexOfAny(cEspeciais) != -1)
                    especiais = true;
            }

            bool eValido = (digito && maiuscula && minuscula && especiais);
            if (eValido)
                return true;
            else    
            {
                string criterio = string.Empty;
                if (digito == false)
                    criterio = "um dígito";
                else if (maiuscula == false)
                    criterio = "uma letra maiúscula";
                else if (minuscula == false)
                    criterio = "uma letra minúscula";
                else if (especiais == false)
                    criterio = "um caracter especial";

                Console.WriteLine($"É necessário incluir no mínimo {criterio}.\n");
                return false;
            }
        }

        public static void AdicionarCaracteres(ref string senha, int caracteresRestantes)
        {                
            string restoSenha = string.Empty;

            while (senha.Length < 6)
            {
                Console.WriteLine("Digite o restante da senha: ");
                restoSenha = Console.ReadLine();

                if (restoSenha.Length < caracteresRestantes)
                {
                    caracteresRestantes -= restoSenha.Length;
                    Console.WriteLine($"\nVocê precisa adicionar pelo menos mais {caracteresRestantes} caracteres.\n");
                }
                senha = senha + restoSenha;
            }
            SenhaValida(ref senha);
        }
    }
}

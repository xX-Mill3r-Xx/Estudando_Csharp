using System;

namespace FuncoesInteressantes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   -";

            string s1 = original.ToUpper(); //Imprime todos os caracteres em maiusculo
            string s2 = original.ToLower(); //Imprime todos os caracteres em minusculo
            string s3 = original.Trim(); //apaga os espaços em branco;
            int n1 = original.IndexOf("bc"); //Imrpime a primeira ocorrencia do valor passado entre parametros;
            int n2 = original.LastIndexOf("bc"); //Imrpime a ultima ocorrencia do valor passado entre parametros;
            string s4 = original.Substring(3); // recorta uma string a partir de uma determinada posição;
            string s5 = original.Substring(3, 5); // recorta uma string a partir de uma determinada posição até a posição desejada;
            string s6 = original.Replace('a', 'x');//Substitui um caracter por outro;
            string s7 = original.Replace("abc", "xy"); //Substitui uma cadeia de caracteres por outros;

            bool b1 = string.IsNullOrEmpty(original); //Testa se o conteudo da string é nullo ou vazio;
            bool b2 = string.IsNullOrWhiteSpace(original); //Testa se a variavel é nulla ou espaço em branco;

            Console.WriteLine(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(b1);
            Console.WriteLine(b2);


            /*Checklist
                • Formatar: ToLower(), ToUpper(), Trim()
                • Buscar: IndexOf, LastIndexOf
                • Recortar: Substring(inicio), Substring(inicio, tamanho)
                • Substituir: Replace(char, char), Replace(string, string)
                • String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
                • str.Split(' ')
                • Conversão para numero: int x = int.Parse(str), int x =Convert.ToInt32(str)
                • Conversão de número: str = x.ToString(), str = x.ToString("C"), str = 
                x.ToString("C3"), str = x.ToString("F2")*/
        }
    }
}

using System;
using System.Collections.Generic;

namespace DictionaryTKey_TValue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionary<TKey, TValue>
                • É uma coleção de pares chave / valor • Não admite repetições do objeto chave
                • Os elementos são indexados pelo objeto chave (não possuem posição) • Acesso, inserção e remoção de elementos são rápidos

                • Uso comum: cookies, local storage, qualquer modelo chave-valor • Dictionary
                • https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx

                • SortedDictionary
                • https://msdn.microsoft.com/en-us/library/f7fta44c(v=vs.110).aspx
             
            Diferenças
                • Dictionary
                • Armazenamento em tabela hash
                • Extremamente rápido: inserção, remoção e busca O(1) • A ordem dos elementos não é garantida
                • SortedDictionary
                • Armazenamento em árvore
                • Rápido: inserção, remoção e busca O(log(n)) 
                • Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

            Alguns métodos importantes
                • dictionary[key] - acessa o elemento pela chave informada
                • Add(key, value) - adiciona elemento (exceção em caso de repetição) 
                • Clear() - esvazia a coleção
                • Count - quantidade de elementos
                • ContainsKey(key) - verifica se a dada chave existe
                • ContainsValue(value) - verifica se o dado valor existe
                • Remove(key) - remove um elemento pela chave
             */

            #region Demo
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }
            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            #endregion
        }
    }
}

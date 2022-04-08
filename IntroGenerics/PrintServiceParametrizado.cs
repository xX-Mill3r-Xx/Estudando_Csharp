using System;

namespace IntroGenerics
{
    class PrintServiceParametrizado<T>
    {
        /*Exemplo da classe parametrizado*/

        /*Toda essa classe agora é de um tipo generico do tipo T*/

        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print service is full");
            }
            else
            {
                _values[_count] = value;
                _count++;
            }
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Print service is empty");
            }
            else
            {
                return _values[0];
            }
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write($"{_values[i]}, ");
            }
            if (_count > 0)
            {
                Console.Write($"{_values[_count - 1]}");
            }
            Console.WriteLine("]");
        }
    }
}

﻿using System;

namespace IntroGenerics
{
    class PrintServiceObject
    {
        /*Modelo da segunda aula - versão object*/
        /*Esta solução não tem Type Safety*/

        private object[] _values = new object[10];
        private int _count = 0;

        public void AddValue(object value)
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

        public object First()
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

        /*Devemos evitar o uso do object, pois o object pode ser qualquer objeto e não tera o suporte do Type Safety*/
    }
}

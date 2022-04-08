using System;
using System.Collections.Generic;

namespace Services
{
    class CalculationService
    {
        #region Este metodo NÃO é generic
        /*Este exemplo ainda não é do tipo generic, faz parte do modelo Light da versão do sistema*/
        //public int Max(List<int> list)
        //{
        //    if(list.Count == 0)
        //    {
        //        throw new ArgumentException("The list can not be empty");
        //    }

        //    int max = list[0];
        //    for(int i = 0; i < list.Count; i++)
        //    {
        //        if(list[i] > max)
        //        {
        //            max = list[i];
        //        }
        //    }
        //    return max;
        //}
        #endregion

        #region Este metodo é Generic
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
        #endregion
    }
}

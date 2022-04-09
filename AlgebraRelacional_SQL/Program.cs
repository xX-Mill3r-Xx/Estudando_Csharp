using System;

namespace AlgebraRelacional_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Operações básicas da álgebra relacional
                • Restrição
                • Projeção
                • Produto cartesiano 
                • Junção (produto cartesiano + restrição de chaves correspondentes)

            Operação "produto cartesiano":
                SELECT * FROM PRODUCT, CATEGORY

            ___________________________________________________________________________________________________________________

            Operação "junção":
            SELECT * FROM PRODUCT, CATEGORY WHERE PRODUCT.CATEGORY_ID = CATEGORY.ID

            SELECT * FROM PRODUCT INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID

            ___________________________________________________________________________________________________________________

            Operação "restrição":
            SELECT * FROM PRODUCT INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID WHERE CATEGORY.NAME = 'Computers'

            ___________________________________________________________________________________________________________________

            Operação "projeção":
            SELECT PRODUCT.*, CATEGORY.NAME FROM PRODUCT INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID WHERE CATEGORY.NAME = 'Computers'
             */
        }
    }
}

﻿using System;

namespace HerdarVSCumprir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Aspectos em comum entre herança e interfaces
                • Relação é-um
                • Generalização/especialização
                • Polimorfismo

            Diferença fundamental
                • Herança => reuso
                • Interface => contrato a ser cumprido
             */

            /*Herança múltipla e o problema do diamante*/

            /*
             * Problema do diamante
             * 
             A herança múltipla pode gerar o problema do diamante: uma ambiguidade causada pela existência do mesmo método em   mais de uma superclasse.
               Herança múltipla não é permitida na maioria das linguagens!

            Porém, uma classe (ou struct) pode implementar mais de uma interface

            ATENÇÃO:
                Isso NÃO é herança múltipla, pois NÃO HÁ REUSO na relação entre ComboDevice e as interfaces Scanner e Printer.
                ComboDevide não herda, mas sim implementa as interfaces (cumpre o contrato).
             */
        }
    }
}

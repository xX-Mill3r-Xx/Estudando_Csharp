
namespace InterfaceE.Services
{
    interface ITaxService
    {
        /*Obs.: Por convensão em C#, uma boa pratica é sempre começar uma interface com a letra "I" em maiusculo antes do seu nome propiamente dito;*/

        double Tax(double amount);
    }
}

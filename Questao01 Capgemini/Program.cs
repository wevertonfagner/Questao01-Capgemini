/* Escreva um algoritmo que mostre na tela uma escada de tamanho n utilizando o caractere *
e espaços. A base e altura da escada devem ser iguais ao valor de n. A última linha não deve conter
nenhum espaço.

Exemplo:

Entrada:
n = 6

Saída:
*
**
***
****
*****
******

 */

Console.WriteLine("Ecolha o tamanho da sua escada na escala de 1 a 10");

int tamanhoEscada = int.Parse(Console.ReadLine());

switch (tamanhoEscada)
{

    case 1:
        Console.WriteLine("*");
        break;
    case 2:
        Console.WriteLine(" *" + "\n" +
                          "**");
        break;
    case 3:
        Console.WriteLine("  *" + "\n" +
                          " **" + "\n" +
                          "***");
        break;
    case 4:
        Console.WriteLine("   *" + "\n" +
                          "  **" + "\n" +
                          " ***" + "\n" +
                          "****");
        break;
    case 5:
        Console.WriteLine("    *" + "\n" +
                          "   **" + "\n" +
                          "  ***" + "\n" +
                          " ****" + "\n" +
                          "*****");
        break;
    case 6:
        Console.WriteLine("     *" + "\n" +
                          "    **" + "\n" +
                          "   ***" + "\n" +
                          "  ****" + "\n" +
                          " *****" + "\n" +
                          "******");
        break;
    case 7:
        Console.WriteLine("      *" + "\n" +
                          "     **" + "\n" +
                          "    ***" + "\n" +
                          "   ****" + "\n" +
                          "  *****" + "\n" +
                          " ******" + "\n" +
                          "*******");
        break;
    case 8:
        Console.WriteLine("       *" + "\n" +
                          "      **" + "\n" +
                          "     ***" + "\n" +
                          "    ****" + "\n" +
                          "   *****" + "\n" +
                          "  ******" + "\n" +
                          " *******" + "\n" +
                          "********");
        break;
    case 9:
        Console.WriteLine("        *" + "\n" +
                          "       **" + "\n" +
                          "      ***" + "\n" +
                          "     ****" + "\n" +
                          "    *****" + "\n" +
                          "   ******" + "\n" +
                          "  *******" + "\n" +
                          " ********" + "\n" +
                          "*********");
        break;
    case 10:
        Console.WriteLine("         *" + "\n" +
                          "        **" + "\n" +
                          "       ***" + "\n" +
                          "      ****" + "\n" +
                          "     *****" + "\n" +
                          "    ******" + "\n" +
                          "   *******" + "\n" +
                          "  ********" + "\n" +
                          " *********" + "\n" +
                          "**********");
        break;
    default:
        Console.WriteLine("Número inválido, tente novamente digitando um número de 1 a 10");
        break;
}
 #include <ctype.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>

int main(void)
{
    char frase[50], frase_nova[550];
    char palavra[50];
    int tam, i, j, cont;
    printf(" Digite uma frase: \n");
    gets(frase);
    tam = strlen(frase);
    i = 0;
    cont = 0;
    while (i<tam)
    {
        j=i;
        while (j <tam && frase[j] != ' ')
        {
            palavra[cont] = frase[j];
            cont++;
            j++;
        }
        palavra[cont] = '\0';
        cont = 0;
        if (strcmp(palavra, "TECLADO")==0)
        {
            strcat(frase_nova, "TECLADO OU MOUSE");
        }
        else
        {
            strcat(frase_nova, palavra);
        }
        if (j < tam)
            strcat(frase_nova, " ");
        i = j + 1;
    }
    strcat(frase_nova, "\0");
    printf("\n Nova Frase : %s", frase_nova);
    getchar();
    return 0;
}

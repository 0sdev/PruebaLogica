// See https://aka.ms/new-console-template for more information

using PruebaLogica;
using System.Collections;

ArrayList lista = new ArrayList();

Console.WriteLine("\nIngresa tus letras:");
String letras = Console.ReadLine();
Operaciones(letras);

void Operaciones(String value){
    
    int posicion = 26;
    int total = 0;
    foreach (char letra in value)
    {
        if (posicion == 26)
        {
            lista.Add(new Nodo(letra.ToString(), posicion));
            posicion--;
        }
        else {
            for (int i = 0; i < lista.Count; i++) {
                Nodo n = (Nodo)lista[i];
                if (letra.ToString().Equals(n.letra))
                {
                    posicion = n.valor;
                    break;
                }
            }

            lista.Add(new Nodo(letra.ToString(), posicion));
            posicion--;
        }        
    }


    for (int i = 0; i < lista.Count; i++)
    {
        Nodo n = (Nodo)lista[i];
        total = total +  n.valor;

    }

    Console.WriteLine("La suma total es: " + total);
    Console.ReadLine();    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PairOrNotPair : MonoBehaviour
{
    public List<string> studentsName = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //cosas para un ejercicio
        studentsName.Add("christian");
        studentsName.Add("karen");
        studentsName.Add("Mia"); 


        //Even or not Even 
        for (int i = 0; i <= 10; i++)
        {
            if (i == 0)
            {
                Debug.Log("el numero es 0 y este es un numero especial");
            }
            else if (IsNumberEven(i))
            {
                Debug.Log("el numero "+i+"es par");
            }
            else
            {
                Debug.Log("el numero " + i + "es impar");
            }
        }

        //metodo que determina que numeros son primos de 1 a 100
        //prime or not prime
        for (int number = 1; number <= 100; number++)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                    isPrime = false;
            }
            if (isPrime)
            {
                Debug.Log("el numero " + number + "es primo");
            }
            /*
            else
            {
                Debug.Log("el numero " + number + "no es primo");
            }
            */


            //search algorithm
            int posicion = -1;
            for (int i=0;i<studentsName.Count;i++)
            {
                if (studentsName[i] == "antonio")
                {
                    posicion = i;
                    break;//esto rompe el loop para que deje de iterar 
                }
            }
            if (posicion == -1)
            {
                Debug.Log("no se ha encontrado el objeto buscado");
            }
            else
            {
                Debug.Log("el objeto se encuentra en la posicion: " + posicion);
            }
            //cuando se tiene un algoritmo de busqueda se debe romper el loop cuando se encuentra el objeto 
        }
    }

   /// <summary>
   /// metodo para saber si un numero es par o no es par
   /// </summary>
   /// <param name="numer"> numero que se evaluara si es par</param>
   /// <returns>es par o no es par</returns>
    private bool IsNumberEven(int numer)
    {
        int IsPair = numer / 2;
        if (IsPair == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

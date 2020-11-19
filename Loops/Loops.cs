using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public List<string> studentsName = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        /*FOREACH
         * sintaxis:
         *  foreach(Type elementName in collection)
         *  {
         *  //codigo del bucle
         *  }
         */

        //FOREACH EXAMPLE 
        studentsName.Add("christian");
        studentsName.Add("kate");
        studentsName.Add("karen");
        studentsName.Add("Mia");

        foreach(string person in studentsName)//por cada persona tipo string en studentsName imprime los nombres
        {
            Debug.Log(person);
        }
        //los foreach no me arroja la poscicion del objeto

        /*FOR 
         * sintaxis:
         * for(inicializacion; condicion de continuacion, iteracion)
         * {
         * codigo del bucle
         * }
         */

        //FOR EXAMPLE
        for (int i = 0; i== 10; i++) //como inicia el contador, donde termina o condicion de terminacion y incremento del contador 
        {
            Debug.Log(i);
        }

        for(int pos=0; pos<studentsName.Count; pos++)
        {
            Debug.Log("la posicion" + pos + "tiene el nombre de: " + studentsName[pos]);
        }
        //la variables declaradas en el for solo se pueden usar en el for 

        /*WHILE 
         * sintaxis:
         * Inicializacion
         * while(condicion de continuacion)
         * {
         * codigo del bucle
         * }
         * la variable del bucle sigue existiendo despues
         */

        int counter = 1;
        while (counter <= 10)
        {
            Debug.Log(counter);
            counter++;
        }
        //counter sigue existiendo despues del ciclo while
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndMore : MonoBehaviour
{
    /*ARRAY 
     * -es homogeneo (solo un tipo de dato)
     * -es de tamaño fijo()una vez creado, no puede contener mas elementos
     * -tiene un orden (se accede por posicion)
     * -son mas rapidos de procesar los arrays 
     */
    // Los arrays nos sirven para tener un compendio de cosas, como listas de cosas se declaran asi 
    public string[] Students = new string[] {"pablo","pablin","pablito","kate","antonio"};//asi se declara dessde un inicio 
    //los arrays no crecen de tamaño ni para abajo ni para arriba 
    public string[] familyNames = new string[4]; //{.,.,.,.,,} asi se hace un array vacio 
                                                 //se puede hacer un array de todas los tipos de variables 


    /*LISTA
     * using System.Collections.Generic;
     * -es homogeneo (solo un tipo de dato)
     * -es de tamaño ajustable (podemos aladir mas elementos en tiempo reak y eliminarlos)
     * -tiene un orden (se accede por posicion)
     */
    public List<string> studentsName = new List<string>();


    /*ARRAYLIST
     * using System.Collections.Generic;
     * -no es homogeneo (solo un tipo de dato)
     * -es de tamaño ajustable (podemos aladir mas elementos en tiempo reak y eliminarlos)
     * -tiene un orden (se accede por posicion)
     */
    public ArrayList invetory = new ArrayList();

    void Start()
    {
        //ARRAYS
        int numArray = Students.Length;//para saber el largo de un array es con length 

        //LISTAS
        //añadiendo partes a la lista  studetsName
        studentsName.Add("christian");
        studentsName.Add("karen");
        studentsName.Add("Mia");
        //quitando cosas de la lista studentsName
        if (studentsName.Contains("antonio"))
        {
            studentsName.Remove("antonio");
        }
        studentsName.Insert(2, "Paul");//insertando un valor en la lista a la fuerza 

        string[] studentsNamesToArray = studentsName.ToArray(); //convierte una lista a un array

        studentsName.Clear();//vaciando la lista por completo 

        Debug.Log(studentsName[2]);//para acceder en el array y en la lista se consulta asi a los dos 
        //no se puede accesar a posiciones negativas o que sean mas grandes de tamaño 

        int numList = studentsName.Count; //para saber el largo de una lista es con un count 

        //ARRAYLIST
        //añadiendo objetos al arraylist
        invetory.Add(30);
        invetory.Add(3.1415);
        invetory.Add("Juan Gabriel");
        invetory.Add(false);

        Debug.Log(invetory[0].GetType()); //como le cabe de todo es importante saber que esta agarrando 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

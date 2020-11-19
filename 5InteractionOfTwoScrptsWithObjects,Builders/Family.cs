using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public Person Father;
    public Person Mother;
    public Person son;

    // Start is called before the first frame update
    void Start()
    {
        /*para las variables y lo demas es necesario primero guardar espacio en la memoria para poder usarlo
         * por eso se usa el new 
         * en cada uno de los nombres se utilizan diferentes constructores 
         */
        Father = new Person("anakin", "skywalker");   //dehntro de la ram le digo que guarde un espacio de memoria para un nuevo gameObject person
        Father.age = 53;
        Father.isMale = true;
        Father.isMarried = true;


        Mother = new Person();//reservar espacio en memoria par la madre
        Mother.firstName = "padmen";
        Mother.lastName = "amidala";
        Mother.age = 28;
        Mother.isMale = false;
        Mother.isMarried = true;

        son = new Person("luke", "skywalker",8,true,false);

        Debug.Log(Father.firstName + " y " + Mother.firstName + "tienen un hijo llamado" + son.firstName);
        //asi se crean los objetos 
        //=========================================================================================
        //ahora queremos que esten ligados entre ellos podemos hacer:
        Father.isMarriedWith = Mother;

        Mother.isMarriedWith = Father;


        if (Father.IsMarriedWithSomeone(Mother))
        {
            Debug.Log(Father.firstName + " y " + Mother.firstName + "estan casados");
        }
        else
        {
            Debug.Log("no estan casdos");
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

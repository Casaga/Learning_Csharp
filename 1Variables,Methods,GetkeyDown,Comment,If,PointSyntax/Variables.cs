using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //lo llamado Variable es la clase de este scirpt, que hereda de MonoBehaviour, esto hara que todo
    //lo que tenga de MonoBehaviur tambien lo podra usar Variables

    /*De esta manera se podran hacer comentarios mas grandes y haciendo saltos de linea sin necesidad
     * de poner otra raya
     */
    /*En la parte superior del codigo siempre iran las variables del programa 
     *Las variables publicas se pueden ver en el editor si se husa el camel case 
     */
    // Tipos de datos:
    bool boolVariable; //esta en memoria solo ocupa 1 bit en la memoria !! True o False
    int intVariable; // numeros reales enteros desde negativos y posistivos, si se necesita mas es long
    float floatVariable;// numeros con decimales con negativos y positivos, si se necesita mas es double
    char charVariable;//estas son simples letras a e i u t 
    string stringVariable;// este corresponde a las entradas de texto 
    //aqui se declararan las variables, estos no permiten espacios ni caracteres extraños 
    public int MyNumber = 10; //las variables puden ser inicializadas o no 
    public int OtherNumber; //al usar este metodo se ira a los valores default dependiendo de la variable
    public int Num1=5;
    public int Num2 = 9;
    
    /*Las variables que se declaran fuera de los metodos son GLOBALES, estas pueden ser utilziadas por todo el scrpt
     * o por otros scripts si son publicos, pero cuando se declara dentro de metodo, solo se puede usar esta 
     * despues de ser declarada para abajo, hasta terminar el metodo, fuera del metodo esta variable deja de existir 
     * y no podra ser usada por otra vez, solo por el metodo en donde se encuentra 
     */

    public bool willItRainToday;
    private float x;
    //por lo general todas las variables deben de ser privados para que no sean hackeables
    void Start()
    {
      
        x=this.transform.position.x;  //asi se pone la sintaxis de el punto, al ir de una especificacion general a una mas especifica

        //la manera de tomar una decision es con un elemento if. este siempre tiene que resolevr en si o no 
        if (willItRainToday)
        {
            Debug.Log("agarra un paraguas que va a llover");
        }
        else
        {
            Debug.Log("no agarres el paraguas");
        }

        //para poder negar la manera de de poner el if se puede con el !
        if (!willItRainToday)
        {
            Debug.Log("iremos al cine");
        }

        //para poder utilizar la logica se puede usar && para AND, || para OR

        //PODEMUS USAR LOS PARAMETROS Y HACER ELSE  if dependiendo de las variables
        int maxspeed = 120;

        if (maxspeed == 120)
        {
            Debug.Log("podemos ir a fondo");
        }
        else if(maxspeed<120 && maxspeed >= 60)
        {
            Debug.Log("podemos ir a velocidad de crucero");
        }
        else if (maxspeed < 60 && maxspeed >= 40)
        {
            Debug.Log("Debemos ir a velocidad de ciudad");
        }
        else if (maxspeed < 40 && maxspeed >= 0)
        {
            Debug.Log("Mejor vamos dando un paseo");
        }
        else
        {
            Debug.LogError("velocidad no valida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//asi se pide que se ha pulsado una tecla en especifico 
        {
            SumTwoNumbers();
        }

        MyNumber = AddTwoNumbers(1, 2);
    }
    //un metodo sera capaz de hacerse cada vez que se le sea llamado para no hacer copiar y pegar 
    /// <summary>
    /// al poner 3 barras es posible darle una adecuada documentacion a un metodo
    /// </summary>
    void SumTwoNumbers()
    {
        Debug.Log(Num1 + Num2);
    }

    //los metodos pueden ser llamados y pasarle nuevos parametros para poder hacer cosas con ellos tambien pudiendo 
    //ser que ellos regresen valores 
    
    /// <summary>
    /// en este metodo se sumaran 2 numeros que se le den al metodo, regresando un numero, asi que sera necesario
    /// ser llamdo desde fuera y tambien se puede ver como se comenta bien un metodo 
    /// </summary>
    /// <param name="numero1"> numero 1 el cual se va a sumar</param>
    /// <param name="numero2"> numero 2 el cual se va a sumar</param>
    /// <returns> resultado de la suma de los dos numeros que entraron </returns>
    private int AddTwoNumbers(int numero1, int numero2)
    {
        int Number = numero1 + numero2;
        return Number;
    }
}

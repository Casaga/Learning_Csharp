using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{   //person no hereda de monobehaviour, asi que no puede hacer ni start ni update, person es un objeto, no un comportamiento 
    //no se puede hacer un new con los que heredan de monobehaviour ya que esos son  comportamientis 
    //y este es un objeto, por lo mismo este script no podra ser arrastrado a ningun GameObject
    public string firstName;
    public string lastName;
    public int age;
    public bool isMale;
    public bool isMarried;

    public Person isMarriedWith;

    //hacer el mismo contrsuctor de difernetes maneras se llama sobrecarga del metodo
    //constructor por defecto
    //se declara el constructor por defecto para que se puedan seguir pasando parametros con person();
    public Person()
    {

    }

    //este es un constructor, nos sirve para que cuando se inicie un nuevo objeto con estas caracteristicas poder darselas rapidamente 
    //sin necesidad de estar pasandole parametro por parametro 
    public Person(string pFirstname, string pLastName)
    {
        this.firstName = pFirstname;
        this.lastName = pLastName;
    }

    //un nuevo contructor para poder tener mas de 2 maneras de llamar a person 
    public Person(string pFirstname, string pLastName,int pAge,bool pIsMale, bool pIsMarried)
    {
        this.firstName = pFirstname;
        this.lastName = pLastName;
        this.age = pAge;
        this.isMale = pIsMale;
        this.isMarried = pIsMarried;
    }


    public bool IsMarriedWithSomeone(Person otherPerson)
    {
        if (isMarriedWith == null)
        {
            return false;
        }
        else
        {
            if (otherPerson == this.isMarriedWith)
            {
                return true;  
            }
            else
            {
                return false;
            }
        }
    }
}

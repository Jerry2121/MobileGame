using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMFruitNINJA : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //we made fruit a public class so we can create fruit from any script in the project
        Fruit myFruit = new Fruit("lemon","sweet","brown",2);
        Apple myApple = new Apple();
        //these two chop functions will behhave deifferently the apple chop has been identified as a new fuction that will
        //deviate from the parent
        myFruit.Chop();
        myApple.Chop();
        //this will downgrade my apple to be a fruit
        //this is callied variable casting
        Fruit faleApple = (Fruit)myApple;
        
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


public class Apple: Fruit
{
    public bool isOnTree;
    public Apple()
    {
        isOnTree = true;
        Debug.Log("Calling the fruit constructor");
    
    }

    //crate a differnt chop fuction for the apple   
    public new void Chop()
    {
        Debug.Log("the" + color + "apple has been sliced and diced");
    }
}


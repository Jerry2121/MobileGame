using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WATEVERIWANt : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //we create a new fruit object and set its values
        Fruit myFruit = new Fruit();
        myFruit.taste = "sour";
        myFruit.color = "green";
        myFruit.name = "GreenSourFruit";
        myFruit.size = 12;
        //we can use our fruit object in the same way
        //we can use any other variable.
        List<Fruit> fruitSalad = new List<Fruit>();
        Fruit fruit2 = new Fruit("Orange", "tangy", "pink", 20);

        Fruit fruit3 = new Fruit();
        myFruit.Chop();

		
	}
}
//we define the fruit object and all its properties
public class Fruit
{
    public string name;
    public string taste;
    public string color;
    public int size;

    public Fruit(string newName, string newTaste,
        string newColor, int newSize)
    {
        name = newName;
        taste = newTaste;
        color = newColor;
        size = newSize;


    }

    public Fruit()
    {


    }
    public void Chop()
    {
        Debug.Log("the" + color +"" + name + "has been chopped");  
    }
}

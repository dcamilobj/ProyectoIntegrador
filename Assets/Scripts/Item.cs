using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	//Definir coordenadaas X y Y

	public int x{
		get;
		//private set;
		set; 
	}

	public int y
	{
		get;
		//private set;
		set; 
	}
		
    public int id;

	//Método para saber si la posición de un item ha cambiado
	public void onItemPositionChanged(int newX, int newY)
	{	
		x=newX;
		y=newY;
		gameObject.name = string.Format ("{0},{1}", x, y);
	}

	//
	public void OnMouseDown()
	{
		print ("Ya estoy dando click acá");
		if (OnMouseOverItemEventHandler != null)
		{
			OnMouseOverItemEventHandler (this);
		}
	}

	public delegate void OnMouseOverItem(Item item);
	public static event OnMouseOverItem OnMouseOverItemEventHandler;

}

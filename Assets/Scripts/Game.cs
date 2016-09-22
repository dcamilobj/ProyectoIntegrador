using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    public int sizeX, sizeY;
    private GameObject[] items; //Arreglo de objetos
	private GameObject [] itemsToShow;
    private Item selectedItem; //Item seleccionado


    //Llenar la cuadricula con los elementos respectivos
    public void FillGrid()
    {
		for (int i = 0; i < sizeX; i=i+3)
        {
			for (int j = 0; j < sizeY; j=j+3)
            {
                InstantiateI(i, j);			
            }
        }
    }

    //Escogemos el item aleatoriamente 
     void InstantiateI(int x, int y)
    {
        GameObject rItem = items[Random.Range(0, items.Length)];
        //GameObject rItem = items[0];
       	GameObject newItem = (GameObject)Instantiate(rItem, new Vector3(x, y), Quaternion.identity);
       // newItem.GetComponent<Item>().onItemPositionChanged(x, y);
    }

    //Método para intercambiar la posición de dos items a los que se les ha dado click
    void OnMouseOverItem(Item item)
    {
        if (selectedItem == item)
            return;
        if (selectedItem == null)
        {
            selectedItem = item;
        }
        else
        {
            float differenceX = Mathf.Abs(item.x - selectedItem.x); //Diferencia en x entre los dos items a intercambiar
            float differenceY = Mathf.Abs(item.y - selectedItem.y); //Diferencia en y entre los dos items a intercambiar

            if (differenceX + differenceY == 1) //Se permite intercambio
            { }
            else //No se permite intercambio
            { }
        }

    }

    //IEnumerator intercambio(Item a, Item b)
   //{

    //}

    void getItems()
    {
        items = Resources.LoadAll<GameObject>("Imagenes");
      /*  for (int i = 0; i < items.Length; i++)
        {
            items[i].GetComponent<Item>().id=i ;
        }*/
    }

    // Use this for initialization
    void Start () {
		print ("Aca");
        getItems();
		print(items.Length);
        FillGrid();
	}
	
	// Update is called once per frame
	void Update() {		
		//if((Time.frameCount %60)==0){
			//FillGrid();
		//}
	}
}

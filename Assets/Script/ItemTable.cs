using UnityEngine;
using System.Collections;

public class ItemTable : MonoBehaviour 
{
	public GameObject item;
	public UIDraggableCamera camera;

	GameObject[] items = null;
	int itemMax = 100;
	int itemNum = 0;


	public void InsertItem()
	{

		GameObject obj = Instantiate (item) as GameObject;
		obj.transform.parent = transform;
		obj.transform.position = Vector3.zero;
		obj.transform.localScale = Vector3.one;
		obj.name = "item";
		
		obj.GetComponent<UIDragCamera> ().draggableCamera = camera;

		items [itemNum] = obj;
		itemNum++;
		
		GetComponent<UITable> ().Reposition ();
	}

	public void DeleteItem()
	{
		Destroy (items [itemNum - 1]);
		itemNum--;
	}


	// Use this for initialization
	void Start () 
	{
		items = new GameObject[itemMax];
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

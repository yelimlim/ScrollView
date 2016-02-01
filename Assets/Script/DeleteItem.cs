using UnityEngine;
using System.Collections;

public class DeleteItem : UIButton 
{
	public GameObject itemTable;

	void OnPress(bool isPressed)
	{
		if (!isPressed) 
		{
			return;
		}

		itemTable.GetComponent<ItemTable> ().DeleteItem ();
	}
}

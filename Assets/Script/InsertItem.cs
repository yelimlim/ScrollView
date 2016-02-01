using UnityEngine;
using System.Collections;

public class InsertItem : UIButton 
{
	public GameObject itemTable;

	void OnPress(bool isPressed)
	{
		if (!isPressed) 
		{
			return;
		}

		itemTable.GetComponent<ItemTable> ().InsertItem ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Characters and items in the case of chests or terminals are able to hold a collection of items.
public class Inventory : MonoBehaviour {

	List<item> items = new List<item>();

	void addItem(Item item) {
		items.Add (item);
	}

	void removeItem(Item item) {
		items.Remove (item);
	}

	bool containsItem(Item item) {
		return items.Contains (item);
	}

	int countOfItems() {
		return items.Count;
	}

}

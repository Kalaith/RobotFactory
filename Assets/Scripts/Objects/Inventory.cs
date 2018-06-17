using System.Collections;
using System.Collections.Generic;

// Characters and items in the case of chests or terminals are able to hold a collection of items.
public class Inventory {

	List<Item> items = new List<Item>();

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

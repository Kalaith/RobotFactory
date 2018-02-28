using System.Collections;
using System.Collections.Generic;

/// <summary>
/// An item, this can exisit in an inventory or a standalone item on the map
/// </summary>
public class Item {

	// Using a dictionary allows us to store key value pairs, so an item can have 1 attrbute or 100
	Dictionary<string, string> item;

	Item(Dictionary<string, string> attr) {
		item = new Dictionary<string, string>();
	}

	string getAttributeValue(string key) {
		if (item.ContainsKey (key)) {
			return item [key];
		}
	}

	Dictionary<string, string> addItemAttribute(string key, string value) {
		item.Add(key, value);
	}


}

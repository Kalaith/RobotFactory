using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TextGen {

	public static string ramble() {
		// Talk trash
		string ramble = "";

		int lines = Random.Range (1, 5);
		for (int i = 0; i < lines; i++) {
			int words = Random.Range (1, 20);
			for (int j = 0; j < words; j++) {
				int letters = Random.Range (1, 10);
				for (int k = 0; k < letters; k++) {
					char numToChar = (char)Random.Range (65, 90);
					ramble += numToChar.ToString ();
				}
				if (j == words) {
					ramble += ".";
				} else {
					ramble += " ";
				}
			}
			ramble += "\n";

		}
		return ramble;
	}
}

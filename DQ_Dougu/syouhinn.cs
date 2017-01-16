using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class syouhinn : MonoBehaviour {

	[SerializeField]
	Text[] itemNameTexts;
	[SerializeField]
	Text[] itemPricesTexts;

	[SerializeField]
	string[] itemNames;
	[SerializeField]
	int[] itemPrices;


	void Start ()
	{
		for (int i = 0; i < itemNames.Length; i++) {
			itemNameTexts [i].text = itemNames [i];
			itemPricesTexts [i].text = itemPrices [i].ToString ();
		}
	}
}

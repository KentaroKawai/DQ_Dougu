using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Item : MonoBehaviour {

	protected string itemName;
	protected int itemPrice;
	[SerializeField]
	protected Text nameText;
	[SerializeField]
	protected Text priceText;

	private void Start ()
	{
		OnStart ();
	}

	protected virtual void OnStart(){}
}

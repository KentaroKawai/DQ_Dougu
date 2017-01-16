using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class money : MonoBehaviour {

	[SerializeField]
	Text kanehyouji;

	public static int haveMon = 100;

	void Update () 
	{
		
		kanehyouji.text = haveMon.ToString ();
	}
}

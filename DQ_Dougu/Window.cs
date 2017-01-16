using UnityEngine;
using System.Collections;

public class Window : MonoBehaviour {

	[SerializeField]
	GameObject talkWin;

	public static bool ff;

	// Use this for initialization
	void Start () 
	{
		ff = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Return)) {
			talkWin.SetActive (true);
		}
	}
}

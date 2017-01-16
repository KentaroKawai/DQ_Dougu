using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sentakutennmetu : Tennmetu {

	[SerializeField]
	GameObject[] pos;
	int sentakuNum = 0;

	[SerializeField]
	Image _img;

	[SerializeField]
	GameObject 道具欄;
	[SerializeField]
	GameObject sentaku欄;

	[SerializeField]
	GameObject text;

	protected override void OnStart ()
	{
		img = _img;
		img.transform.position = pos [sentakuNum].transform.position;
	}

	protected override void OnUpdate ()
	{

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			sentakuNum = 0;
			img.transform.position = pos [sentakuNum].transform.position;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			sentakuNum = 1;
			img.transform.position = pos [sentakuNum].transform.position;
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			
			if (sentakuNum == 0) {
				道具欄.SetActive (true);
				Window.ff = false;
				text.SetActive (true);
				sentaku欄.SetActive (false);
			}
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dougutennmetu : Tennmetu {

	[SerializeField]
	GameObject[] dougupos;
	int sentakuNum = 0;
	[SerializeField]
	Image _img;

	protected override void OnStart ()
	{
		img = _img;
		img.transform.position = dougupos[0].transform.position;
	}
	
	protected override void OnUpdate ()
	{
		

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			sentakuNum--;
			sentakuNum = (int)(Mathf.Clamp (sentakuNum, 0,  dougupos.Length - 1));
			img.transform.position = dougupos[sentakuNum].transform.position;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			sentakuNum++;
			sentakuNum = (int)(Mathf.Clamp (sentakuNum, 0,  dougupos.Length - 1));

			img.transform.position = dougupos[sentakuNum].transform.position;
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			money.haveMon -= 2;
		}

		Debug.Log ( dougupos.Length - 1);
	}
}

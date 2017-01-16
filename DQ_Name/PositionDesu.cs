using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PositionDesu : MonoBehaviour {

	[SerializeField]
	GameObject[] objpos;

	[SerializeField]
	GameObject[] barPos;

	[SerializeField]
	GameObject bar;

	[SerializeField]
	Text[] inputName;

	[SerializeField]
	AudioSource audio;

	[SerializeField]
	AudioClip カーソル音;
	[SerializeField]
	AudioClip 選択音;

	int num = 0;
	int barNum = 0;
	int textNum = 0;



	// Use this for initialization
	void Start () 
	{ 
		this.transform.position = objpos [num].transform.position;
		bar.transform.position = barPos [barNum].transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			audio.PlayOneShot (カーソル音);
			++num;
			this.transform.position = objpos [num].transform.position;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			audio.PlayOneShot (カーソル音);
			--num;
			this.transform.position = objpos [num].transform.position;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			audio.PlayOneShot (カーソル音);
			//もどるに飛ぶ
			if (num == 46 || num == 47) {
				num = 56;
				this.transform.position = objpos [num].transform.position;
			}
			//終わりに飛ぶ
			if (num == 48 || num == 49) {
				num = 57;
				this.transform.position = objpos [num].transform.position;
			}

			if(!(num > 49)){
				num += 10;
				this.transform.position = objpos [num].transform.position;
			}

		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			audio.PlayOneShot (カーソル音);
			if (!(num < 10 && num >= 0)) {
				num -= 10;
				this.transform.position = objpos [num].transform.position;
			}
		}

		if (Input.GetKeyDown (KeyCode.Return)) {

			audio.PlayOneShot (選択音);

			//おわり
			if (num == 57) {
				SceneManager.LoadScene("dorakueName");
			}
			//濁点
			if (num == 54) {
				//Debug.Log ("濁点が押されてる");
				パワープレイ濁点 ();
			}
			//半濁点
			if (num == 55) {
				//Debug.Log ("半濁点が押されてる");
				パワープレイ半濁点();
			}

			if(num == 56 && !(textNum == 0)){
				--textNum;
				if (barNum == 0) {
					barNum = 0;
				} else {
					barNum--;
				}
				inputName [textNum].text = objpos [num].name;
				bar.transform.position = barPos [barNum].transform.position;

			}else if (!(num == 56)&&textNum >= 4) {
				inputName [3].text = objpos [num].name;
				barNum = 3;
			}else if(!(num == 56) && !(num == 54) && !(num == 55)){
				inputName [textNum].text = objpos [num].name;
				textNum++;
				if (barNum == 3) {
					bar.transform.position = barPos [3].transform.position;
				} else {
					barNum++;
					bar.transform.position = barPos [barNum].transform.position;
				}
			}

			//Debug.Log (barNum);
		}
	}

	void パワープレイ濁点()
	{
		int suuti = 1;
		//suuti = 1;
		if (textNum >= 4) {
			suuti = 0;
		}
		if (inputName [textNum - suuti].text == "か") {
			inputName [textNum - suuti].text = "が";
		} else if (inputName [textNum - suuti].text == "き") {
			inputName [textNum - suuti].text = "ぎ";
		} else if (inputName [textNum - suuti].text == "く") {
			inputName [textNum - suuti].text = "ぐ";
		} else if (inputName [textNum - suuti].text == "け") {
			inputName [textNum - suuti].text = "げ";
		} else if (inputName [textNum - suuti].text == "こ") {
			inputName [textNum - suuti].text = "ご";
		} else if (inputName [textNum - suuti].text == "さ") {
			inputName [textNum - suuti].text = "ざ";
		} else if (inputName [textNum - suuti].text == "し") {
			inputName [textNum - suuti].text = "じ";
		} else if (inputName [textNum - suuti].text == "す") {
			inputName [textNum - suuti].text = "ず";
		} else if (inputName [textNum - suuti].text == "せ") {
			inputName [textNum - suuti].text = "ぜ";
		} else if (inputName [textNum - suuti].text == "そ") {
			inputName [textNum - suuti].text = "ぞ";
		} else if (inputName [textNum - suuti].text == "た") {
			inputName [textNum - suuti].text = "だ";
		} else if (inputName [textNum - suuti].text == "ち") {
			inputName [textNum - suuti].text = "ぢ";
		} else if (inputName [textNum - suuti].text == "つ") {
			inputName [textNum - suuti].text = "づ";
		} else if (inputName [textNum - suuti].text == "て") {
			inputName [textNum - suuti].text = "で";
		} else if (inputName [textNum - suuti].text == "と") {
			inputName [textNum - suuti].text = "ど";
		} else if (inputName [textNum - suuti].text == "は") {
			inputName [textNum - suuti].text = "ば";
		} else if (inputName [textNum - suuti].text == "ひ") {
			inputName [textNum - suuti].text = "び";
		} else if (inputName [textNum - suuti].text == "ふ") {
			inputName [textNum - suuti].text = "ぶ";
		} else if (inputName [textNum - suuti].text == "へ") {
			inputName [textNum - suuti].text = "べ";
		} else if (inputName [textNum - suuti].text == "ほ") {
			inputName [textNum - suuti].text = "ぼ";
		}
	}

	void パワープレイ半濁点()
	{
		int suuti = 1;
		//suuti = 1;
		if (textNum >= 4) {
			suuti = 0;
		}

		if (inputName [textNum - suuti].text == "は") {
			inputName [textNum - suuti].text = "ぱ";
		} else if (inputName [textNum - suuti].text == "ひ") {
			inputName [textNum - suuti].text = "ぴ";
		}else if (inputName [textNum - suuti].text == "ふ") {
			inputName [textNum - suuti].text = "ぷ";
		}else if (inputName [textNum - suuti].text == "へ") {
			inputName [textNum - suuti].text = "ぺ";
		}else if (inputName [textNum - suuti].text == "ほ") {
			inputName [textNum - suuti].text = "ぽ";
		}
	}
}

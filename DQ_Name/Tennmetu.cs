using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tennmetu : MonoBehaviour {

	protected Image img;

	[SerializeField]
	float interval;

	float nextTime;

	private void Start () 
	{
		nextTime = Time.time;
		OnStart ();
	}

	private void Update ()
	{
		if (Time.time > nextTime) {
			img.enabled = !img.enabled;
			nextTime += interval;
		}

		OnUpdate ();
	}

	protected virtual void OnStart(){}
	protected virtual void OnUpdate(){}
}

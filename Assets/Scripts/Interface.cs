using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI()
	{
		GUI.Label (new Rect(20, 10, 100, 20), "Player 1");
		GUI.Label (new Rect(20, Screen.height / 2 + 10, 100, 20), "Player 2");
	}
}

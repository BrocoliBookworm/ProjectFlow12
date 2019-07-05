using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

public Text text1;
public Text text2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text1.text = "Score: " + GlobalVariable.pointsP1;
		text2.text = "Score: " + GlobalVariable.pointsP2;
	}
}

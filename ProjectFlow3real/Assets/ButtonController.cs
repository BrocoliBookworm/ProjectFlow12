using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour //changes the image of the input buttons
{
    private SpriteRenderer spriteRenderer; 
    public Sprite defaulted; //default image of the input
    public Sprite pressed; //when the input is pressed what the controller does
    public KeyCode keytoPress;
    private BoxCollider2D Trig;

	// Use this for initialization
	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Trig = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(keytoPress))
        {
            spriteRenderer.sprite = pressed;
            if (ObjectChecker.canBePressed == false){
                GlobalVariable.pointsP1 -= 1;
            }
        }

        if(Input.GetKeyUp(keytoPress))
        {
            spriteRenderer.sprite = defaulted;
        }
	}
}

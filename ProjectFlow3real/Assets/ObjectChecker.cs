using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChecker : MonoBehaviour //script checks to see if the button can be pressed or not
{
    public static bool canBePressed;
    public KeyCode keytoPress;
    public float x;
    public SpriteRenderer BodyColor;

	// Use this for initialization
	void Start ()
    {
		
	}
	void Change(){
        gameObject.SetActive(false);
        var r = Random.Range(1,5);
        Debug.Log(r);
        Debug.Log(GlobalVariable.pointsP1);
        if (r == 1){
            //StartCoroutine("Change");
            keytoPress = KeyCode.DownArrow;
            BodyColor.color = Color.green;
            x = -3.428f;
            gameObject.SetActive(true);
            new WaitForSeconds(1f);
            gameObject.transform.position = new Vector3(x, 6.12f, 0f);
            canBePressed = false;
            }
        else if (r == 2){
            //StartCoroutine("Change");
            keytoPress = KeyCode.LeftArrow;
            BodyColor.color = Color.blue;
            x = -5.128f;
            gameObject.SetActive(true);
            new WaitForSeconds(1f);
            gameObject.transform.position = new Vector3(x, 6.12f, 0f);
            canBePressed = false;
            }
        else if (r == 3){
            //StartCoroutine("Change");
            keytoPress = KeyCode.RightArrow;
            BodyColor.color = Color.yellow;
            x = -2.63425f;
            gameObject.SetActive(true);
            new WaitForSeconds(1f);
            gameObject.transform.position = new Vector3(x, 6.12f, 0f);
            canBePressed = false;
            }
        else if (r == 4){
            //StartCoroutine("Change");
            keytoPress = KeyCode.UpArrow;
            BodyColor.color = Color.red;
            x = -4.25f;
            gameObject.SetActive(true);
            new WaitForSeconds(1f);
            gameObject.transform.position = new Vector3(x, 6.12f, 0f);
            canBePressed = false;
        }
    }
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(keytoPress))
        {
            if(canBePressed)
            {
                Change();
                GlobalVariable.pointsP1 += 1;

            }
        }
        if (gameObject.transform.position.y <= -1f)
            {
                Change();
                GlobalVariable.pointsP1 -= 1;
            }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}

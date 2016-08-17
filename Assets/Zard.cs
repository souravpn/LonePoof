using UnityEngine;
using System.Collections;

public class Zard : MonoBehaviour {

	private float maxLeftEdge;
	private SpriteRenderer thisSprite;

	// Use this for initialization
	void Start () {
		thisSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow)){
			thisSprite.flipX = true;
			transform.Translate(Vector3.right * Time.deltaTime * 2);
		} else if(Input.GetKey(KeyCode.LeftArrow)){
			thisSprite.flipX = false;
			transform.Translate(Vector3.left * Time.deltaTime * 2);
		} else if(Input.GetKey(KeyCode.UpArrow)){
			//transform.Translate(Vector3.left * Time.deltaTime * 2);
		}

	}

}

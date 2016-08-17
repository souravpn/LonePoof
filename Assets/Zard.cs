using UnityEngine;
using System.Collections;

public class Zard : MonoBehaviour {

	private float maxLeftEdge;
	private SpriteRenderer thisSprite;
	private Animator animator;

	// Use this for initialization
	void Start () {
		thisSprite = GetComponent<SpriteRenderer>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow)){
			thisSprite.flipX = true;
			animator.SetBool("isWalking", true);
			transform.Translate(Vector3.right * Time.deltaTime * 2);
		} else if(Input.GetKey(KeyCode.LeftArrow)){
			thisSprite.flipX = false;
			animator.SetBool("isWalking", true);
			transform.Translate(Vector3.left * Time.deltaTime * 2);
		} else if(Input.GetKey(KeyCode.UpArrow)){
			//transform.Translate(Vector3.left * Time.deltaTime * 2);
		}

	}

}

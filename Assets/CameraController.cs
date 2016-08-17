using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject zard;

	private Vector3 offset;
	private float camPositionX;
	private float camPositionZ;
	private float camPositionY;

	// Use this for initialization
	void Start () {
		offset = new Vector3(0f,8f, -10f);
		camPositionZ = -10f;
		camPositionY = 0f;
		//transform.position = new Vector3(10f,10f,10f);
	}
	
	// Update is called once per frame
	void Update () {
		camPositionX = zard.transform.position.x;
		offset = new Vector3(camPositionX,camPositionY,camPositionZ);
		transform.position = offset;
	}


}

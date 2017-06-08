using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * 0.5f);
        transform.RotateAround(Camera.main.transform.position, Vector3.left, 5 * Time.deltaTime);
        transform.RotateAround(Camera.main.transform.position, Vector3.down, 5 * Time.deltaTime);

    }
}

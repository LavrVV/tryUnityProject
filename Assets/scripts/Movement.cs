using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * 0.1f, 0.0f, Input.GetAxis("Vertical") * 0.1f));
        transform.Rotate(new Vector3(0, 1, 0), Input.GetAxis("Mouse X"));
    }
}

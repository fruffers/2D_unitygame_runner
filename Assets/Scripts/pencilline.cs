using UnityEngine;
using System.Collections;

public class pencilline : MonoBehaviour {

	//to refer to our prefab pencilline
	public GameObject obj;
	
	float lastx = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//if we have moved far enough make a new pencilline
		
		if (transform.position.x > (lastx+0.02f)) {
			
			
			Instantiate (obj,transform.position,Quaternion.identity);
			lastx = transform.position.x;
			
			lastx = transform.position.x;
			
		}
		
	}
}
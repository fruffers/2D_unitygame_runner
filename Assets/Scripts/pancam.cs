using UnityEngine;
using System.Collections;

public class pancam : MonoBehaviour {

	float ydir = 0f;
	public GameObject player;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		//check that player exists and then proceed. otherwise we get an error when player dies
		if (player) {
			//if player has passed the x position of -1 then start moving camera forward with a randomish Y position
			if (player.transform.position.x > -1) {

				
				float randy = 0f;
				randy = Random.Range (0f, 100f);
				if (randy < 20) {
					ydir = ydir + .005f;
				} else if (randy > 20 && randy < 40) {
					ydir = ydir - .005f;
				} else if (randy > 80) {
					ydir = 0f;
				}
				transform.position = new Vector3 (transform.position.x + 0.03f, transform.position.y + ydir, -10);
			}
		}
	}
}

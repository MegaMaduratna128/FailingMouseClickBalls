using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBall : MonoBehaviour {
	
	public GameObject BallPrefab; 

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 worldpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log(worldpoint);
			Instantiate(BallPrefab,new Vector3(worldpoint.x, worldpoint.y,0),Quaternion.identity);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {

	public GameObject ceilingFanBlades;
	public GameObject gunState1, gunState2;
	public float ceilingFanBladesSpeed = 120f;
	
	void Start () {

		gunState1.renderer.enabled = true;
		gunState2.renderer.enabled = false;
	}

	void Update () {
		ceilingFanBlades.transform.Rotate(Vector3.forward * Time.deltaTime * ceilingFanBladesSpeed);

		if (Input.GetKey(KeyCode.R)) {
			gunState1.renderer.enabled = false;
			gunState2.renderer.enabled = true;
		}
	}
}

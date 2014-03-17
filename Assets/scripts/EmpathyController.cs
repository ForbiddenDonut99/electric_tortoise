using UnityEngine;
using System.Collections;

public class EmpathyController : MonoBehaviour {

	public GameObject empathyLight1, empathyLight2, empathyLight3, empathyLight4, empathyLight5, empathyLight6, empathyLight7;


	void Start () {
	
		empathyLight1.renderer.enabled = false;
		empathyLight2.renderer.enabled = false;
		empathyLight3.renderer.enabled = false;
		empathyLight4.renderer.enabled = false;
		empathyLight5.renderer.enabled = false;
		empathyLight6.renderer.enabled = false;
		empathyLight7.renderer.enabled = false;
	}

	public void ReactionDecider() {
		StartCoroutine ("WeakReaction");

		}
	
	private IEnumerator WeakReaction() {

		empathyLight1.renderer.enabled = true;
		empathyLight2.renderer.enabled = true;
		empathyLight3.renderer.enabled = true;

		yield return new WaitForSeconds(2);

		empathyLight2.renderer.enabled = false;
		empathyLight3.renderer.enabled = false;

		yield return new WaitForSeconds(1);

		empathyLight1.renderer.enabled = false;



	}


}

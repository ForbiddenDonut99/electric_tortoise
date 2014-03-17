using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {

	public TextMesh testQuestion1, testQuestion2, testQuestion3;

	void Start () {
		testQuestion1.text = "Your underaged daughter is pregnant. \n" +
							 "The father runs away. \n " +
							 "Your daughter begs you for an abortion.";

		testQuestion2.text = "A dog is brutally hit by a car in the street. \n" +
							 "Do you take it to a nearby veterinarian \n" +
							 "or put it out of its misery?";

		testQuestion3.text = "";

	}

	void Update () {
	
	}
}

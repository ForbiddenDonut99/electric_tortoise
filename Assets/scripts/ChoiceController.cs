using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChoiceController : MonoBehaviour {

	public GUIText choiceTextTopLeft, choiceTextTopRight, choiceTextBottomLeft, choiceTextBottomRight;
	public GUITexture choiceBarTopLeft, choiceBarTopRight, choiceBarBottomLeft, choiceBarBottomRight, timerBar;

	public Texture choiceBarBlack, choiceBarWhite;

	public List<GUIText> choiceTextList;
	public List<GUITexture> choiceBarList;
	public List<string> choiceTextContentList;

	public string choiceTextContent;

	public bool choiceActive = false;
	public int choicePick;

	public DialogueController dialogueController;

	void Start () {
		choiceTextList = new List<GUIText> ();
		choiceTextList.Add (choiceTextTopLeft);
		choiceTextList.Add (choiceTextTopRight);
		choiceTextList.Add (choiceTextBottomLeft);
		choiceTextList.Add (choiceTextBottomRight);

		choiceBarList = new List<GUITexture> ();
		choiceBarList.Add (choiceBarTopLeft);
		choiceBarList.Add (choiceBarTopRight);
		choiceBarList.Add (choiceBarBottomLeft);
		choiceBarList.Add (choiceBarBottomRight);
		choiceBarList.Add (timerBar);

		choiceTextContentList = new List<string> ();
		choiceTextContent = "1. Ask first test question.";
		choiceTextContentList.Add (choiceTextContent); // [0]
		choiceTextContent = "2. Ask second test question.";
		choiceTextContentList.Add (choiceTextContent); // [1]
		choiceTextContent = "3. Why are you so anxious?";
		choiceTextContentList.Add (choiceTextContent); // [2]
		choiceTextContent = "4. Retire android.";
		choiceTextContentList.Add (choiceTextContent); // [3]

		SetChoices ();
		DisableChoices ();
	}

	void Update() {

		/*if (choiceActive == true) {
			GetComponent<SimpleSmoothMouseLook>().lockCursor = false;
			if (Input.mousePosition.x > 0 && Input.mousePosition.y > 0) {
				choiceBarList[1].texture = choiceBarWhite;
			} else if (Input.mousePosition.x < 0 && Input.mousePosition.y > 0) {

			} else if (Input.mousePosition.x > 0 && Input.mousePosition.y < 0) {

			} else if (Input.mousePosition.x < 0 && Input.mousePosition.y < 0) {

			}

		}*/


		// choice inputs

		if (Input.GetKey(KeyCode.Alpha1) && choiceActive == true) {
			choiceActive = false;
			choicePick = 1;
			DisableChoices ();
			dialogueController.DialogueReset ();

		} else if (Input.GetKey(KeyCode.Alpha2) && choiceActive == true) {
			choiceActive = false;
			choicePick = 2;
			DisableChoices ();
			dialogueController.DialogueReset ();
		
		} else if (Input.GetKey(KeyCode.Alpha3) && choiceActive == true) {
			choiceActive = false;
			choicePick = 3;
			DisableChoices ();
			dialogueController.DialogueReset ();
			
		} else if (Input.GetKey(KeyCode.Alpha4) && choiceActive == true) {
			choiceActive = false;
			choicePick = 4;
			DisableChoices ();
			dialogueController.DialogueReset ();
			
		}

		}

	private void SetChoices() {
		choiceTextTopLeft.text = choiceTextContentList [0];
		choiceTextTopRight.text = choiceTextContentList [1];
		choiceTextBottomLeft.text = choiceTextContentList [2];
		choiceTextBottomRight.text = choiceTextContentList [3];

	}

	public void EnableChoices() {
		for (int i = 0; i <= 3; i++) {
			
			choiceTextList[i].enabled = true;
			
		}
		for (int i = 0; i <= 4; i++) {
			
			choiceBarList[i].enabled = true;
			
		}
		
	}

	public void DisableChoices() {
		for (int i = 0; i <= 3; i++) {
			
			choiceTextList[i].enabled = false;
			
		}
		for (int i = 0; i <= 4; i++) {
			
			choiceBarList[i].enabled = false;
			
		}
		
	}
	


}

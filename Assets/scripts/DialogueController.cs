using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueController : MonoBehaviour {

	public TextMesh agentTextMesh;
	public TextMesh suspectTextMesh;
	public List<int> maxIndexList;

	public int gameState = 0;

	public ChoiceController choiceController;
	public ContentController contentController;
	public EmpathyController empathyController;

	public bool empathyReactionBool = false;
	
	private bool preventDialogue = true;
	private int maxIndex;



	void Start() {
		maxIndexList = new List<int> ();
		maxIndex = 2;
		maxIndexList.Add (maxIndex); // [0]
		maxIndex = 2;
		maxIndexList.Add (maxIndex); // [1]
		maxIndex = 2;
		maxIndexList.Add (maxIndex); // [2]
		maxIndex = 2;
		maxIndexList.Add (maxIndex); // [2]
		StartCoroutine ("IntroActivate");
	}

	void Update() {
		if (Input.GetMouseButton (0) && preventDialogue == false && GetComponent<ContentController> ().contentIndex < maxIndex) {
						preventDialogue = true;
						AgentResponse ();
						StartCoroutine ("SuspectResponse");
		} else if (GetComponent<ContentController> ().contentIndex == maxIndexList[GetComponent<ContentController> ().contentIndex] && choiceController.choiceActive == false) {
						gameState++;
						StartCoroutine("DelayChoice");	
				
				}
	}

	private IEnumerator IntroActivate() {
		agentTextMesh.renderer.enabled = false;
		suspectTextMesh.renderer.enabled = false;
		yield return new WaitForSeconds (0.15f);
		agentTextMesh.text = GetComponent<ContentController>().contentAgentList [GetComponent<ContentController> ().contentIndex];
		suspectTextMesh.text = GetComponent<ContentController>().contentSuspectList [GetComponent<ContentController> ().contentIndex];
		yield return new WaitForSeconds(3);
		agentTextMesh.renderer.enabled = true;
		yield return new WaitForSeconds(5);
		suspectTextMesh.renderer.enabled = true;
		GetComponent<ContentController> ().contentIndex++;
		preventDialogue = false;

		}

	private void AgentResponse() {
		agentTextMesh.text = GetComponent<ContentController>().contentAgentList [GetComponent<ContentController> ().contentIndex];

	}

	private IEnumerator SuspectResponse() {
		yield return new WaitForSeconds (3);
		if (empathyReactionBool == true) {
			empathyController.ReactionDecider();
			empathyReactionBool = false;
		}
		yield return new WaitForSeconds (1);
		preventDialogue = false;
		suspectTextMesh.text = GetComponent<ContentController>().contentSuspectList [GetComponent<ContentController> ().contentIndex];
		GetComponent<ContentController> ().contentIndex++;



	}

	private IEnumerator DelayChoice() {
		preventDialogue = true;
		choiceController.choiceActive = true;
		yield return new WaitForSeconds (2);
		choiceController.EnableChoices();

	}
			
	
	public void DialogueReset() {
		GetComponent<ContentController> ().contentIndex = 0;
		contentController.SetDialogue ();
		agentTextMesh.text = GetComponent<ContentController>().contentAgentList [GetComponent<ContentController> ().contentIndex];
		StartCoroutine ("SuspectResponse");

	}


}

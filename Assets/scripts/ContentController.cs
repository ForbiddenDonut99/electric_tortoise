using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ContentController : MonoBehaviour {

	public string contentAgent;
	public string contentSuspect;

	public List<string> contentAgentList;
	public List<string> contentSuspectList;
	public List<int> wordIndexList;
	
	public int contentIndex = 0;
	public int wordIndex = 0;



	void Start() {
		SetDialogue ();


		}

	public void SetDialogue() {
		if (GetComponent<DialogueController> ().gameState == 0) {
						contentAgentList = new List<string> ();
						contentAgent = "I'm going to ask you a series of questions. \n " +
									   "Answer them as quickly and simply as you can.";
						contentAgent = "I'm";
						contentAgentList.Add (contentAgent); // [0]
						contentAgent = "Reaction timing is a factor, so please pay attention.";
						contentAgentList.Add (contentAgent); // [1]
						
						contentSuspectList = new List<string> ();
						contentSuspect = "What kind of test is this?";
						contentSuspectList.Add (contentSuspect); // [0]
						contentSuspect = "Alright...";
						contentSuspectList.Add (contentSuspect); // [1]

				}

		if (GetComponent<DialogueController>().gameState == 1) {
				if (GetComponent<ChoiceController> ().choicePick == 1) {
						GetComponent<DialogueController> ().empathyReactionBool = true;
						contentAgentList = new List<string> ();
						contentAgent = "Your underaged daughter is pregnant. \n" +
								"The father runs away. She wants an abortion. \n" +
								"Do you let her have one?";
						contentAgentList.Add (contentAgent); // [0]
						contentAgent = "The question is hypothetical. Assume that you do.";
						contentAgentList.Add (contentAgent); // [1]

						contentSuspectList = new List<string> ();
						contentSuspect = "I don't have a daughter.";
						contentSuspectList.Add (contentSuspect); // [0]
						contentSuspect = "That is difficult to just imagine.";
						contentSuspectList.Add (contentSuspect); // [1]


				} else if (GetComponent<ChoiceController> ().choicePick == 2) {
						GetComponent<DialogueController> ().empathyReactionBool = true;
						contentAgentList = new List<string> ();
						contentAgent = "A dog is brutally hit by a car in the street. \n" +
								"Do you take it to a nearby veterinarian? \n" +
								"Or put it out of its misery?";
						contentAgentList.Add (contentAgent); // [0]
						contentAgent = "Even if there was a chance of survival?";
						contentAgentList.Add (contentAgent); // [1]
			
						contentSuspectList = new List<string> ();
						contentSuspect = "I suppose I would put it out of its misery.";
						contentSuspectList.Add (contentSuspect); // [0]
						contentSuspect = "That dog will probably never run again. \n" +
								"What kind of life for a dog is that?";
						contentSuspectList.Add (contentSuspect); // [1]


				} else if (GetComponent<ChoiceController> ().choicePick == 3) {
						contentAgentList = new List<string> ();
						contentAgent = "You seem rather anxious.";
						contentAgentList.Add (contentAgent); // [0]
						contentAgent = "Why is that?";
						contentAgentList.Add (contentAgent); // [1]
			
						contentSuspectList = new List<string> ();
						contentSuspect = "I don't like taking tests.";
						contentSuspectList.Add (contentSuspect); // [0]
						contentSuspect = "Does anyone really enjoy being put under scrutiny?";
						contentSuspectList.Add (contentSuspect); // [1]
				}
		
	
		}
	}
	
}

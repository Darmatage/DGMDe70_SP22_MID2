using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
		// public Text TextDelay;
		public Text Char4speech_shake;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ChoiceEvade1;
        public GameObject ChoiceEvade2;
        public GameObject ChoiceFight;
        public GameObject NextScene1aButton;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        ChoiceEvade1.SetActive(false);
        ChoiceEvade2.SetActive(false);
        ChoiceFight.SetActive(false);
        NextScene1aButton.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "COMMAND";
                 StartCoroutine(TypeText(Char1speech, "This is Commander Zurcik hailing Captain Asana of the SI-627. Do you read me?"));
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

            //  if (playerHealth <= 5){
              //    primeInt = 10;//send story to frame 11
              //}
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain Asana";
                Char2speech.text = "recieving, Commander...Like a book sir.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "COMMAND";
                  StartCoroutine(TypeText(Char1speech, "Requesting a status report from the Galactic Union’s most capable ambassadors."));
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain Asana";
                Char2speech.text = "We are en route to Beta 9’s Intergalactic Conference as planned. No events to report, no contact with vessels of any kind. Just another day in space.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "COMMAND";
                  StartCoroutine(TypeText(Char1speech,"Thank you, Captain. Anything to add, Lieutenant Rory"));
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Lieutenant Rory";
                Char3speech.text = "No, sir. Systems are stable and functioning as expected. We picked up some chatter a few hours back, but I was unable to lock onto the signal. It’s probably nothing.";
		}
       else if (primeInt == 8){
                Char1name.text = "COMMAND";
                  StartCoroutine(TypeText(Char1speech,"Thank you, Lieutenant. That may... {tchhkshhh} notice of a batt... {zztch} earby territory. Avoid at... {tzzkkshh} mission... {ktchhhhssshhhh}"));
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "";
                Char3speech.text = "";
                // // Turn off "Next" button, turn on "Choice" buttons
               // nextButton.SetActive(false);
                // allowSpace = false;
               //  Choice1a.SetActive(true); // function Choice1aFunct()
               // Choice1b.SetActive(true); // function Choice1bFunct()
        }
		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain Asana";
                Char2speech.text = "We're losing contact...Lieutenant, can you reconnect to command?";
				        Char3name.text = "";
                Char3speech.text = "";
                // // Turn off "Next" button, turn on "Choice" buttons
               // nextButton.SetActive(false);
                // allowSpace = false;
               //  Choice1a.SetActive(true); // function Choice1aFunct()
               // Choice1b.SetActive(true); // function Choice1bFunct()
        }
		else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lieutenant Rory";
                Char3speech.text = "My requests won’t go through. It’s almost as if we’re being jammed, but I don’t-";
        }



        else if (primeInt == 11){
                ArtChar2.SetActive(true);
                Char1name.text = "";
				        Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4speech_shake.text = "The ship rocks as a laser smashes into the ship’s side. A dreadnought looms to starboard.";
         }
else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain Asana";
			        	Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4speech_shake.text = "Shields up! 9";

			  }
				else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lieutenant Rory";
			          Char3speech.text = "";
                Char4speech_shake.text = "Evasive maneuvers! 11";
        }

				else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char4speech_shake.text = "With a hum, energy shields surround the ship. The next shot sends a ripple of energy across the porthole, but the ship holds stable.";
        }

				else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Shields at 80 percent, Captain. Here comes another volley!";
				 Char4speech_shake.text = "";
        }

				else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
			          Char3speech.text = "";
                Char4speech_shake.text = "As you bank the ship into a tight turn, something catches your eye- a laser meant for your ship suddenly bends into a sphere and disappears. A wormhole!";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
		       		  nextButton.SetActive(false);
                allowSpace = false;
                NextScene1aButton.SetActive(true);
		NextScene2Button.SetActive(true);
                //Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice2.SetActive(true); // function Choice1bFunct()
		}

}

// ENCOUNTER AFTER CHOICE #1
// else if (primeInt == 20){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "Lieutenant Rory";
                // Char3speech.text = "Suck plasma, you bastards! ...FIRE!";
				 // Char4speech_shake.text = ""
        // }else if (primeInt == 21){
                // Char1name.text = ""
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
                // Char3speech.text = "";
				 // Char4speech_shake.text = "A chunk of the Dreadnought's flank explodes outwards, oxygen igniting then imploding in a red and orange flash. "
        // }else if (primeInt == 22){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "Lieutenant Rory";
                // Char3speech.text = "Shields at 80 percent, Captain. Here comes another volley!";
				 // Char4speech_shake.text = "";
        // }
       // else if (primeInt == 23){
                // Char1name.text = "Jeda";
                // Char1speech.text = "Come back here! Do not think you can hide from me!";
                // Char2name.text = "";
                // Char2speech.text = "";
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene1Button.SetActive(true);
				// NextScene2Button.SetActive(true);
        // }



       // else if (primeInt == 200){
                // Char1name.text = "Jeda";
                // Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
                // Char2name.text = "";
                // Char2speech.text = "";
        // }
       // else if (primeInt == 201){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "You";
                // Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene2Button.SetActive(true);
        // }







     // }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void ChoiceEvade1Fun(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 20;
                ChoiceEvade1.SetActive(false);
                ChoiceEvade2.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceEvade2Fun(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 20;
                ChoiceEvade1.SetActive(false);
                ChoiceEvade2.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void NextScene1aFun(){
               SceneManager.LoadScene("Scene1a");
        }
        public void NextScene2Fun(){
                SceneManager.LoadScene("Scene2");
        }
		
		    IEnumerator TypeText(Text target, string fullText){
                float delay = 0.025f;
                nextButton.SetActive(false);
                allowSpace = false;
                for (int i = 0; i < fullText.Length; i++){
                        string currentText = fullText.Substring(0,i);
                        target.text = currentText;
                        yield return new WaitForSeconds(delay);
                }
                nextButton.SetActive(true);
                allowSpace = true;
        }

}

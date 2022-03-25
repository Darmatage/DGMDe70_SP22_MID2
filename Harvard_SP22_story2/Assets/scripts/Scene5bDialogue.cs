using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5bDialogue : MonoBehaviour {
      public int primeInt = 1; // This integer drives game progress!
      public Text Char1name;
      public Text Char1speech;
      public Text Char2name;
      public Text Char2speech;
      public Text Char3name;
      public Text Char3speech;
      public GameObject Char1Plate;
      public GameObject Char2Plate;
      public GameObject Char3Plate;
      public Text ButtonText1;
      public Text Char4speech_shake;
      public GameObject DialogueDisplay;
      public GameObject ArtBG1;
      public GameObject ArtOpenAirLock;
      public GameObject ArtHeadache;
      public GameObject ArtChar1;
      public GameObject ArtChar2;
      public GameObject ArtChar3Unholstered;
      public GameObject ArtLaser1;
      public GameObject ArtLaser2;
      public GameObject ArtLaser3;
      public GameObject ArtLaser4;
      public GameObject NextScene1Button;
      public GameObject TalkButton;
      // public GameObject NextScene2Button;
      public GameObject nextButton;
      //public GameHandler gameHandler;
      //public AudioSource audioSource;
      private bool allowSpace = true;
      public string playerName;
      public GameHandler gameHandler;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(false);
		    ArtChar1.SetActive(false);
		    ArtChar2.SetActive(false);
        ArtChar3Unholstered.SetActive(false);
		    ArtBG1.SetActive(true);
        ArtOpenAirLock.SetActive(false);
    		ArtHeadache.SetActive(false);
    		ArtLaser1.SetActive(false);
    		ArtLaser2.SetActive(false);
    		ArtLaser3.SetActive(false);
    		ArtLaser4.SetActive(false);
        NextScene1Button.SetActive(false);
		    nextButton.SetActive(true);
        allowSpace = true;
		    TalkButton.SetActive(false);
        Char1Plate.SetActive(false);
        Char2Plate.SetActive(false);
        Char3Plate.SetActive(false);

		       string pNameTemp = gameHandler.GetName();
       playerName = pNameTemp.ToUpper();
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";

                allowSpace = false;
        }else if (primeInt == 3){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 TalkButton.SetActive(true);
				 ButtonText1.text = "Go!";
				 nextButton.SetActive(false);
				 // nextButton.SetActive(false);
                // allowSpace = false;

		}else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";
				 resetArt();
				 resetButton();
				 ArtOpenAirLock.SetActive(true);
				 ArtChar1.SetActive(true);
				 ArtChar2.SetActive(true);
				 nextButton.SetActive(true);
				 allowSpace = true;

        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Alt Lieutenant";
                Char3speech.text = "Your orders, Captain?";
				 Char4speech_shake.text = "";
				 ArtBG1.SetActive(false);
				 ArtOpenAirLock.SetActive(true);
				 ArtChar3Unholstered.SetActive(true);
				 ArtChar1.SetActive(false);



        }
		else if (primeInt == 6){
				         Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Alt Lieutenant";
                Char3speech.text = "Your orders, Captain?";
				 Char4speech_shake.text = "";
				 ArtBG1.SetActive(false);
				 ArtOpenAirLock.SetActive(true);
				 ArtChar3Unholstered.SetActive(true);
				 ArtChar1.SetActive(false);


        }
		else if (primeInt == 7){

				         Char1name.text = "Alt Captain";
                Char1speech.text = "Fire!";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Alt Lieutenant";
                Char3speech.text = "Your orders, Captain?";
				 Char4speech_shake.text = "";



        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";
				 ArtLaser1.SetActive(true);
				 ArtLaser2.SetActive(true);
				 ArtLaser3.SetActive(true);

        }
      // else if (primeInt == 9){
                // Char1name.text = "";
                // Char1speech.text = "";
				// Char2name.text = "Captain Asana";
                // Char2speech.text = "You’re a good man, Rory. Thank you.";
               // Char3name.text = "";
                // Char3speech.text = "";
				 // Char4speech_shake.text = "";

        // }
		 // else if (primeInt == 10){
                // Char1name.text = "********";
                // Char1speech.text = "Lieutenant Rory's steady eyes fade into scarlet lightning as the world roars into oblivion.";
                // Char2name.text = "";
                // Char2speech.text = "";
				// Char3name.text = "";
                // Char3speech.text = "";

				// }
		// else if (primeInt == 11){
                // ArtBG1.SetActive(false);
                // ArtOpenAirLock.SetActive(true);
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
                // Char3name.text = "";
                // Char3speech.text = "";


			     	    // nextButton.SetActive(false);
				        // allowSpace = false;
				        // NextScene1Button.SetActive(true);
				// }



        // else if (primeInt == 11){
                 // Char1name.text = "********";
				 // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
                // Char3speech.text = "";
                 // Char4speech_shake.text = "The ship rocks as a laser smashes into the ship’s side. A dreadnought looms to starboard.";

         // }
// else if (primeInt == 12){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "Captain Asana";
				// Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
                // Char3speech.text = "";
                // Char4speech_shake.text = "Shields up! 9";

			  // }
				// else if (primeInt == 13){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "Lieutenant Rory";
			   // Char3speech.text = "";
                // Char4speech_shake.text = "Evasive maneuvers! 11";
        // }

				// else if (primeInt == 14){
                // Char1name.text = "********";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
                // Char4speech_shake.text = "With a hum, energy shields surround the ship. The next shot sends a ripple of energy across the porthole, but the ship holds stable.";
        // }

				// else if (primeInt == 15){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "Lieutenant Rory";
                // Char3speech.text = "Shields at 80 percent, Captain. Here comes another volley!";
				 // Char4speech_shake.text = "";
        // }

				// else if (primeInt == 16){
                // Char1name.text = "********";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
			   // Char3speech.text = "";
               // Char4speech_shake.text = "As you bank the ship into a tight turn, something catches your eye- a laser meant for your ship suddenly bends into a sphere and disappears. A wormhole!";
				//Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene1Button.SetActive(true);
				 //NextScene2Button.SetActive(true);
                //Choice1a.SetActive(true); // function Choice1aFunct()
                //Choice2.SetActive(true); // function Choice1bFunct()
		// }

}

// ENCOUNTER AFTER CHOICE #1
// else if (primeInt == 100){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "Lieutenant Rory";
                // Char3speech.text = "Suck plasma, you bastards! ...FIRE!";
				 // Char4speech_shake.text = ""
        // }else if (primeInt == 101){
                // Char1name.text = "********"
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
                // Char3speech.text = "";
				 // Char4speech_shake.text = "A chunk of the Dreadnought's flank explodes outwards, oxygen igniting then imploding in a red and orange flash. "
        // }else if (primeInt == 102){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "Lieutenant Rory";
                // Char3speech.text = "Shields at 80 percent, Captain. Here comes another volley!";
				 // Char4speech_shake.text = "";
        // }
       // else if (primeInt == 103){
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
                // Char2name.text = playerName;
                // Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene2Button.SetActive(true);
        // }







     // }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        // public void Choice1aFunct(){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = playerName;
                // Char2speech.text = "I don't know what you're talking about!";
                // primeInt = 99;
                // Choice1a.SetActive(false);
                // Choice2.SetActive(false);
                // nextButton.SetActive(true);
                // allowSpace = true;
        // }
        public void TalkButton1(){
			talking();
                nextButton.SetActive(true);
                allowSpace = true;
        }

		public void resetArt(){
			ArtChar1.SetActive(false);
		ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
        ArtChar3Unholstered.SetActive(false);
		ArtBG1.SetActive(false);
        ArtOpenAirLock.SetActive(false);
		ArtOpenAirLock.SetActive(false);
		ArtHeadache.SetActive(false);
		ArtLaser1.SetActive(false);
		ArtLaser2.SetActive(false);
		ArtLaser3.SetActive(false);
		ArtLaser4.SetActive(false);
		}

		public void resetButton() {
		NextScene1Button.SetActive(false);
		nextButton.SetActive(false);
        allowSpace = false;
		TalkButton.SetActive(false);
		}

        public void SceneChange7Lose(){
               SceneManager.LoadScene("Scene7");
        }
        // public void SceneChange2a(){
                // SceneManager.LoadScene("Scene2");
        // }
}

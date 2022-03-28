using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5a_2Dialogue : MonoBehaviour {
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
        public GameObject ArtBG2;
		    public GameObject ArtHeadache;
		    public GameObject ArtBridge;
        public GameObject ArtWormhole;
		    public GameObject ArtConvergence;
		    public GameObject ArtShip;
		    public GameObject ArtChar1;
		    public GameObject ArtChar11;
        public GameObject ArtChar2;
        public GameObject ArtChar3;
		    public GameObject ArtBadgeClose;
            public GameObject ArtBadgeFar;
    public GameObject ArtCaptainClose;
            public Text BadgeText;
		    public GameObject ArtCharShip;
		    public GameObject ArtLaser1;
		    public GameObject ArtLaser2;
		    public GameObject ArtLaser3;
		    public GameObject ArtLaser4;
            public GameObject ArtLaser5;
        public GameObject NextScene1Button;
		    public GameObject TalkButton;
		    public GameObject ButtonChoice1;
		    public GameObject ButtonChoice2;
        // public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

		     public string playerName;
       public GameHandler gameHandler;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        Char1Plate.SetActive(false);
        Char2Plate.SetActive(false);
        Char3Plate.SetActive(false);
        ArtChar1.SetActive(true);
		    ArtChar11.SetActive(false);
		    ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
		    ArtBadgeClose.SetActive(false);
		    ArtBadgeFar.SetActive(false);
		    ArtConvergence.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtCaptainClose.SetActive(false);
		    ArtShip.SetActive(false);
		    ArtLaser1.SetActive(false);
		    ArtLaser2.SetActive(false);
		    ArtLaser3.SetActive(false);
		    ArtLaser4.SetActive(false);
        ArtLaser5.SetActive(false);
		    ArtBridge.SetActive(false);
        ArtWormhole.SetActive(false);
		    ArtHeadache.SetActive(false);
		    ArtCharShip.SetActive(false);
        NextScene1Button.SetActive(false);
		    ButtonChoice1.SetActive(false);
		    ButtonChoice2.SetActive(false);
		    nextButton.SetActive(true);
        allowSpace = true;
		    TalkButton.SetActive(false);

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
          Char1Plate.SetActive(false);
          Char2Plate.SetActive(false);
          Char3Plate.SetActive(true);
                DialogueDisplay.SetActive(true);
                ArtChar1.SetActive(true);
                nextButton.SetActive(false);
                TalkButton.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Airlocks attached, Captain. Doors open on your word.";
				        Char4speech_shake.text = "";
			          ButtonText1.text = "Go!";
                allowSpace = true;
        }
        else if (primeInt == 3){
          Char1Plate.SetActive(false);
          Char2Plate.SetActive(false);
          Char3Plate.SetActive(false);
          DialogueDisplay.SetActive(false);
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                ArtChar1.SetActive(false);
                ArtChar11.SetActive(true);
                ArtBadgeFar.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
            // ArtBG1.SetActive(false);
            // ArtBG2.SetActive(true);

            nextButton.SetActive(true);
            Char4speech_shake.text = "";
				 TalkButton.SetActive(false);
				 ButtonText1.text = "";
				 ArtChar2.SetActive(true);
				 ArtChar3.SetActive(true);
				

		}else if (primeInt == 4){
      Char1Plate.SetActive(false);
      Char2Plate.SetActive(false);
      Char3Plate.SetActive(true);
      DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lt. Rory";
                Char3speech.text = "What should we do Captain? ";
				 Char4speech_shake.text = "";
				 nextButton.SetActive(false);
                allowSpace = false;
            ButtonChoice1.SetActive(true);
            ButtonChoice2.SetActive(true);


        }
       else if (primeInt == 5){
         Char1Plate.SetActive(false);
         Char2Plate.SetActive(false);
         Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Yes, Captain!";
				 Char4speech_shake.text = "";
				 TalkButton.SetActive(false);
				 nextButton.SetActive(true);
				 allowSpace = true;


        }
		else if (primeInt == 6){
      DialogueDisplay.SetActive(false);
      Char1Plate.SetActive(false);
      Char2Plate.SetActive(false);
      Char3Plate.SetActive(false);
				 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";
				 TalkButton.SetActive(false);
				 ArtBG2.SetActive(true);
				 ArtBG1.SetActive(false);
				 ArtChar1.SetActive(false);
				 ArtChar11.SetActive(true);
				 ArtChar2.SetActive(true);
				 ArtLaser1.SetActive(true);
				 ArtLaser2.SetActive(true);
				 ArtLaser3.SetActive(true);
				 ArtLaser4.SetActive(true);
                 ArtLaser5.SetActive(true);

        }
		else if (primeInt == 7){
      DialogueDisplay.SetActive(true);
      Char1Plate.SetActive(false);
      Char2Plate.SetActive(true);
      Char3Plate.SetActive(false);
      ArtHeadache.SetActive(true);
  			 Char1name.text = playerName;
                Char1speech.text = "We should be dead... What's happening?";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";

        }
       else if (primeInt == 8){
         ResetArt();
            ArtLaser5.SetActive(false);
         DialogueDisplay.SetActive(false);
         Char1Plate.SetActive(false);
         Char2Plate.SetActive(false);
         Char3Plate.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";
				  ArtBG2.SetActive(false);
				  ArtWormhole.SetActive(true);
          ArtHeadache.SetActive(true);

        }
      else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "";
				        ArtWormhole.SetActive(false);
				        ArtHeadache.SetActive(true);
      				  ArtBridge.SetActive(true);
      				  NextScene1Button.SetActive(true);
      				  nextButton.SetActive(false);
      				  allowSpace = false;

        }
		 else if (primeInt == 10){
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "We hailed you earlier - why didn't you answer?";
                Char2name.text = "";
                Char2speech.text = "";
        				Char3name.text = "";
                Char3speech.text = "";
				        ResetButtons();
				        nextButton.SetActive(true);
				        allowSpace=true;

				}

		else if (primeInt == 11){
                Char1Plate.SetActive(true);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Unknown";
                Char2speech.text = "Our computers got fried by an EMP...";  // KAI ADD DELAY TEXT!
                Char3name.text = "";
                Char3speech.text = "";
				}



        else if (primeInt == 12){
                Char1name.text = "";
				        Char1speech.text = "";
                Char2name.text = "Unknown";
                Char2speech.text = "And that was before we went through the wormhole.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4speech_shake.text = "";

         }
else if (primeInt == 13){
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				        Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Captain, look! Their badge!";
                Char4speech_shake.text = "";

			  }
				else if (primeInt == 14){
        				ResetArt();
        				ArtBG2.SetActive(true);
        				ArtBadgeClose.SetActive(true);
                        ArtCaptainClose.SetActive(true);
                        BadgeText.text = playerName;
                
                Char1Plate.SetActive(true);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "That's impossible!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
			          Char3speech.text = "";
                Char4speech_shake.text = "";
        }


else if (primeInt == 15){
				ResetArt();
        Char1Plate.SetActive(false);
        Char2Plate.SetActive(false);
        Char3Plate.SetActive(false);
        DialogueDisplay.SetActive(false);
            ArtCaptainClose.SetActive(false);
            ArtBadgeClose.SetActive(false);
        ArtBG2.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
				ArtHeadache.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";
        }

	else if (primeInt == 16){
				ResetArt();
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ResetButtons();
        ArtHeadache.SetActive(true);
				ArtConvergence.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "";
				 NextScene1Button.SetActive(true);

        }
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

		public void ButtonChoice1Fun(){
				primeInt = 9;
				talking();
				ButtonChoice1.SetActive(false);
				ButtonChoice2.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = true;
		}

			public void ButtonChoice2Fun(){
				talking();
				ButtonChoice1.SetActive(false);
				ButtonChoice2.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = true;
		}

        public void TalkButton1(){
			talking();
                nextButton.SetActive(true);
                allowSpace = true;
        }

		public void ResetButtons(){
			NextScene1Button.SetActive(false);
		ButtonChoice1.SetActive(false);
		ButtonChoice2.SetActive(false);
		nextButton.SetActive(false);
        allowSpace = false;
		TalkButton.SetActive(false);
		}
		  public void ResetArt(){
			ArtChar1.SetActive(false);
		ArtChar11.SetActive(false);
		ArtChar2.SetActive(false);
    ArtChar3.SetActive(false);
		ArtBadgeClose.SetActive(false);
        ArtBG1.SetActive(false);
		ArtConvergence.SetActive(false);
		ArtBadgeFar.SetActive(false);
        ArtBG2.SetActive(false);
		ArtShip.SetActive(false);
		ArtLaser1.SetActive(false);
		ArtLaser2.SetActive(false);
		ArtLaser3.SetActive(false);
		ArtLaser4.SetActive(false);
		ArtWormhole.SetActive(false);
    ArtBridge.SetActive(false);
		ArtHeadache.SetActive(false);
		ArtCharShip.SetActive(false);
    NextScene1Button.SetActive(false);
		ButtonChoice1.SetActive(false);
		ButtonChoice2.SetActive(false);
		nextButton.SetActive(true);
    allowSpace = true;
		TalkButton.SetActive(false);
        }

        public void SceneChange22(){
			if (primeInt == 16)
			{
				SceneManager.LoadScene("Scene6");
			}
      if (primeInt != 16){SceneManager.LoadScene("Scene2Loop");
        }
      }
		        public void SceneChange6(){
               SceneManager.LoadScene("Scene6");
        }
        // public void SceneChange2a(){
                // SceneManager.LoadScene("Scene2");
        // }
}

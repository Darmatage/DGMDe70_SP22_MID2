using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        // public Text Char3name;
        // public Text Char3speech;
		    // public Text ButtonText1;
		    // public Text Char4speech_shake;
        public GameObject DialogueDisplay;
        public GameObject ArtBG1;
        // public GameObject ArtBG2;
		    public GameObject ArtChar1;
		    //  GameObject ArtChar11;
        public GameObject ArtChar2;
    		// public GameObject ArtLaser1;
    		// public GameObject ArtLaser2;
    		// public GameObject ArtLaser3;
    		// public GameObject ArtLaser4;

        public GameObject nextButton;
        public GameObject ButtonChoice1a;
		    public Text textButtonChoice1a;
        public GameObject ButtonChoice1b;
		    public Text textButtonChoice1b;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
        public GameObject Char1Plate;
        public GameObject Char2Plate;
        public GameObject Char3Plate;

void Start(){
           // initial visibility settings
		resetArt();
		// resetButtons();

    DialogueDisplay.SetActive(false);
    ArtChar1.SetActive(true);
		// ArtChar11.SetActive(false);
		ArtChar2.SetActive(false);
    ArtBG1.SetActive(true);
	  textButtonChoice1a.text="";
	  textButtonChoice1b.text="";
        // ArtBG2.SetActive(false);
		// ArtLaser1.SetActive(false);
		// ArtLaser2.SetActive(false);
		// ArtLaser3.SetActive(false);
		// ArtLaser4.SetActive(false);
		nextButton.SetActive(true);

    ButtonChoice1a.SetActive(false);
    ButtonChoice1b.SetActive(false);

    allowSpace = true;
		// TalkButton.SetActive(false);
    Char1Plate.SetActive(false);
    Char2Plate.SetActive(false);
    Char3Plate.SetActive(false);
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
          DialogueDisplay.SetActive(true);
          Char1name.text = "RORY";
          Char1speech.text = "Captain, something's been bothering me.";
          Char2name.text = "";
          Char2speech.text = "";

        } else if (primeInt == 3){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "What is it, Lieutenant?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

		} else if (primeInt == 4){
          Char1name.text = "RORY";
          Char1speech.text = "The EMP... we entered the wormhole just as it hit us. Yet our ship seems unaffected.";
          Char2name.text = "";
          Char2speech.text = "";

        } else if (primeInt == 5){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "You have a theory?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 6){
          Char1name.text = "RORY";
          Char1speech.text = "The best explanation I have is that when we went through, the milliseconds of time between entry and impact became... well, longer.";
          Char2name.text = "";
          Char2speech.text = "";
				 // Char4speech_shake.text = "Fire! Fire! Fire! Fire! FIRE!";
				 // ArtLaser3.SetActive(true);
        } else if (primeInt == 7){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "Explain.";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

       } else if (primeInt == 8){
          Char1name.text = "RORY";
          Char1speech.text = "Time and space aren’t linear around wormholes. Dimensions shift, bend, diverge, converge... ";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 9){
          Char1name.text = "RORY";
          Char1speech.text = "So not only could we be anywhere... but we could be any-when, too.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 10){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "We’re not making it to the Intergalactic Convention this year, are we?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 11){
          Char1name.text = "RORY";
          Char1speech.text = "No. But that’s the least of our worries, now.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 12){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "What could be more pressing than the mission?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 13){
          Char1name.text = "RORY";
          Char1speech.text = "I can’t wrap my head around it. The other ship... it could only have come from our time, give or take a century.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 14){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "And?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 15){
          Char1name.text = "RORY";
          Char1speech.text = "The odds of another ship from our time going through a wormhole and landing right here, right now must be nearly zero.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 16){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "Do you know why you were chosen for this mission?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 17){
          Char1name.text = "RORY";
          Char1speech.text = "Because I’m fluent in 14 languages and was the only one crazy enough to say yes to a 2 year mission?";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 18){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "Because you keep your head on straight when the world goes sideways.";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 19){
          Char1name.text = "RORY";
          Char1speech.text = "You think too highly of me, Captain.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 20){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "Are you contradicting me, Lieutenant?";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 21){
          Char1name.text = "RORY";
          Char1speech.text = "No, of course not!";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 22){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "At ease, Lieutenant. That was a joke.";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 23){
          Char1name.text = "RORY";
          Char1speech.text = "Ah. Very good, Captain.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 24){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "Now, let’s focus on the task at hand.";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 25){
          Char1name.text = "RORY";
          Char1speech.text = "Right. We are boarding an unidentified ship at an unknown location and time. Do I have all the facts straight?";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 26){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "That about sums it up.";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

        } else if (primeInt == 27){
          Char1name.text = "RORY";
          Char1speech.text = "Our hail attempt was unsuccessful, as well. How should we board?";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 28){ // KAI ADD BUTTON
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

		  resetButtons2();
		  ButtonChoice1a.SetActive(true);
		  textButtonChoice1a.text = "We'll arm ourselves to the teeth. Prepare for anything!";
		  ButtonChoice1b.SetActive(true);
		  textButtonChoice1b.text = "This is arescue mission. We will bring medkits, not weapons.";
        } else if (primeInt == 29){
          Char1name.text = "RORY";
          Char1speech.text = "Permission to voice a concern, Captain?";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 30){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

		  resetButtons2();
		  ButtonChoice1a.SetActive(true);
		  textButtonChoice1a.text = "Denied. We could be under fire immediately and I need you to follow my orders without question. Let's do this!";
		  ButtonChoice1b.SetActive(true);
		  textButtonChoice1b.text = "Permission granted. Speak your mind.";
        } else if (primeInt == 31){
          Char1name.text = "RORY";
          Char1speech.text = "They never responded to the hail. It’s possible they never even received it.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 32){
          Char1name.text = "RORY";
          Char1speech.text = "If the first thing they see is the barrel of a rifle, they may see us as a threat.";
          Char2name.text = "";
          Char2speech.text = "";
        } else if (primeInt == 33){
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "YOU";
          Char2speech.text = "";
          Char2Plate.SetActive(true);
          Char3Plate.SetActive(false);

		  resetButtons2();
		  ButtonChoice1a.SetActive(true);
		  textButtonChoice1a.text = "That's a risk well have to take. To the airlock!";
		  ButtonChoice1b.SetActive(true);
		  textButtonChoice1b.text= "Alright, Lieutenant, I'll meet you halfway. Weapons holstered, but at the ready. Follow my lead";
        }
}


	   // this turns off ALL art to make it easier to reset the canvas
	   public void resetArt(){
       ArtChar1.SetActive(false);
		   // ArtChar11.SetActive(false);
		   ArtChar2.SetActive(false);
       ArtBG1.SetActive(false);
       // ArtBG2.SetActive(false);
		   // ArtLaser1.SetActive(false);
		   // ArtLaser2.SetActive(false);
		   // ArtLaser3.SetActive(false);
		   // ArtLaser4.SetActive(false);
	   }


	   public void resetButtons(){

		    nextButton.SetActive(false);
        allowSpace = false;
		    // TalkButton.SetActive(false);
	   }

	   public void resetButtons2(){

		    nextButton.SetActive(false);
        allowSpace = false;
    ButtonChoice1a.SetActive(false);
    ButtonChoice1b.SetActive(false);
	   }


    public void TalkButton1(){
			talking();
      nextButton.SetActive(true);
      allowSpace = true;
        }


public void choice1button(){
		// hostile ++;
		gameHandler.updateAggressionScore(10);
		 if (primeInt == 28){
			 resetButtons2();
           nextButton.SetActive(true);
           allowSpace = true;
           talking();
         }

		if (primeInt == 30) {
			SceneManager.LoadScene("Scene5a");
		}
     if (primeInt == 33){
			SceneManager.LoadScene("Scene5c");
      }
}


public void choice2button() {
			gameHandler.updatePeacefulnessScore(10);
		   if (primeInt == 28){

            // resetButtons2();
            // nextButton.SetActive(true);
            // allowSpace = true;
            SceneManager.LoadScene("Scene5c");
       }
	   	if (primeInt == 30) {
			resetButtons2();
			 nextButton.SetActive(true);
            allowSpace = true;
			talking();
		}
       if (primeInt == 33){
             SceneManager.LoadScene("Scene5b");
		   }
}

    public void SceneChange7Lose(){
      SceneManager.LoadScene("Scene7");
        }
}

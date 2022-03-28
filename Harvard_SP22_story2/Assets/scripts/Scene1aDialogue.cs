using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1aDialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
		    public Text Char4speech_shake;
        public GameObject Char1Plate;
        public GameObject Char2Plate;
        public GameObject Char3Plate;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject ArtBG3;
        public GameObject ArtBG4;
        public GameObject ArtBG5;
        public GameObject ArtBG6;
        public GameObject ArtBG7;
        public GameObject Red1;
	//	    public GameObject red1;
	//	    public GameObject red2;
	//	    public GameObject red3;
	//	    public GameObject red4;
//	    public GameObject red5;
	//	    public GameObject red6;
	//	    public GameObject blue1;
        // public GameObject Choice1a;
        // public GameObject Choice2;
        public GameObject NextScene1Button;
        // public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
       public GameHandler gameHandler;
        private bool allowSpace = true;
        	  public string playerName;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(true);
	//	red1.SetActive(false);
	//	red2.SetActive(false);
//		red3.SetActive(false);
//		red4.SetActive(false);
//		red5.SetActive(false);
//		red6.SetActive(false);
//		blue1.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtBG4.SetActive(false);
        ArtBG5.SetActive(false);
        ArtBG6.SetActive(false);
        ArtBG7.SetActive(false);
        // Choice1a.SetActive(false);
        // Choice2.SetActive(false);
        NextScene1Button.SetActive(false);
		    nextButton.SetActive(true);
        allowSpace = true;
        nextButton.SetActive(true);
        string pNameTemp = gameHandler.GetName();
           playerName = pNameTemp;
        Char1Plate.SetActive(false);
        Char2Plate.SetActive(true);
        Char3Plate.SetActive(false);
        Char2name.text = playerName;
        Char2speech.text = "Fire at will, Leiutenant!";
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
            talking();
        }
        else if (primeInt == 2){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(false);
                ArtBG3.SetActive(false);
                ArtBG4.SetActive(false);
                ArtBG5.SetActive(false);
                ArtBG6.SetActive(false);
                ArtBG7.SetActive(true);
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lt. Rory";
                Char3speech.text = "Suck plasma, you bastards! FIRE!";
				        Char4speech_shake.text = "";
        }
        else if (primeInt == 3){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(false);
                ArtBG3.SetActive(true);
                ArtBG4.SetActive(false);
                ArtBG5.SetActive(false);
                ArtBG6.SetActive(false);
                ArtBG7.SetActive(false);
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "A chunk of the Dreadnought's flank explodes outwards, oxygen igniting then imploding in a red and orange flash. ";
		}
    else if (primeInt == 4){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(false);
                ArtBG3.SetActive(false);
                ArtBG4.SetActive(true);
                ArtBG5.SetActive(false);
                ArtBG6.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "A blue flash from the belly of the ship follows quickly, and all lights in your cabin snap off. ";
				 //red1.SetActive(false);
				// blue1.SetActive(true);
        }
       else if (primeInt == 5){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(false);
                ArtBG3.SetActive(false);
                ArtBG4.SetActive(false);
                ArtBG5.SetActive(true);
                ArtBG6.SetActive(false);
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lt. Rory";
                Char3speech.text = "Captain " +playerName+ "?";
				        Char4speech_shake.text = "";
//				 red1.SetActive(true);
//				 blue1.SetActive(false);
//				 red2.SetActive(true);
        }
		    else if (primeInt == 6){
                Char2Plate.SetActive(true);
                Char1Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char2name.text = playerName.ToUpper();
                Char2speech.text = "Yes, Lieutenant?";
                Char1speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "";
	// red1.SetActive(true);
		//		 blue1.SetActive(false);
		//		 red2.SetActive(true);
		//		  red3.SetActive(true);
        }
		    else if (primeInt == 7){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(false);
                ArtBG3.SetActive(false);
                ArtBG4.SetActive(false);
                ArtBG5.SetActive(false);
                ArtBG6.SetActive(true);
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lt. Rory";
                Char3speech.text = "It's been an honor to serve with you.";
				        Char4speech_shake.text = "";
//	 red1.SetActive(true);
	//			 blue1.SetActive(false);
	//			 red2.SetActive(true);
	//			  red3.SetActive(true);
	//			  red4.SetActive(true);
        }
       else if (primeInt == 8){
                Char2Plate.SetActive(true);
                Char1Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char2name.text = playerName.ToUpper();
                Char2speech.text = "The honor is mine, Lieutenant.";
				        Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "";
//	 red1.SetActive(true);
	//			 blue1.SetActive(false);
		//		 red2.SetActive(true);
		//		  red3.SetActive(true);
		//		  red4.SetActive(true);
		//		  red5.SetActive(true);
        }
      else if (primeInt == 9){
                Char2Plate.SetActive(true);
                Char1Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char2name.text = playerName.ToUpper();
                Char2speech.text = "You’re a good man.";
				        Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "";
//	 red1.SetActive(true);
	//			 blue1.SetActive(false);
	//			 red2.SetActive(true);
	//			  red3.SetActive(true);
		//		  red4.SetActive(true);
		//		  red5.SetActive(true);
        }
		 else if (primeInt == 10){
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "Lieutenant Rory fades into scarlet lightning as the world roars into oblivion.";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "";
                Char3speech.text = "";
                Red1.SetActive(true);
          //      blue1.SetActive(true);
				// red2.SetActive(true);
				//  red3.SetActive(true);
				//  red4.SetActive(true);
				//  red5.SetActive(true);
				}
		else if (primeInt == 11){
      ArtChar1.SetActive(false);
      ArtBG1.SetActive(false);
      ArtBG2.SetActive(true);
      ArtBG3.SetActive(false);
      ArtBG4.SetActive(false);
      ArtBG5.SetActive(false);
      ArtBG6.SetActive(false);
            Red1.SetActive(false);
            DialogueDisplay.SetActive(false);

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
    //            red1.SetActive(false);
  //          		red2.SetActive(false);
    //        		red3.SetActive(false);
    //        		red4.SetActive(false);
    //        		red5.SetActive(false);
    //            red6.SetActive(true);
			     	    nextButton.SetActive(false);
				        allowSpace = false;
				        NextScene1Button.SetActive(true);
				}

				if(Char1name.text != "") {
			Char1Plate.SetActive(true);
		}
		if(Char2name.text != "") {
			Char2Plate.SetActive(true);
		}
		if(Char3name.text != "") {
			Char3Plate.SetActive(true);
		}

}

        public void SceneChangeEnd(){
               SceneManager.LoadScene("SceneEarlyLose");
        }
        // public void SceneChange2a(){
                // SceneManager.LoadScene("Scene2");
        // }
}

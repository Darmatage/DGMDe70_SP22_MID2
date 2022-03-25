using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5a_aggressiveDialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
		public Text ButtonText1;
		public Text Char4speech_shake;
        public GameObject DialogueDisplay;
		public GameObject Char1Plate;
		public GameObject Char2Plate;
		public GameObject Char3Plate;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
		public GameObject ArtChar1;
		public GameObject ArtChar11;
        public GameObject ArtChar2;
		public GameObject ArtLaser1;
		public GameObject ArtLaser2;
		public GameObject ArtLaser3;
		public GameObject ArtLaser4;
        public GameObject NextScene1Button;
		public GameObject TalkButton;
        public GameObject nextButton;
        private bool allowSpace = true;
		
	  public string playerName;
       public GameHandler gameHandler;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        resetArt();
		resetButtons();
		ArtBG1.SetActive(true);
		nextButton.SetActive(true);
        allowSpace = true;

		// input player name
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
        }
        else if (primeInt == 2){
				DialogueDisplay.SetActive(true);
				ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Airlocks attached, Captain. Doors open on your word";
				 Char4speech_shake.text = "";
				 TalkButton.SetActive(true);
				 ButtonText1.text = "Go!";
				 nextButton.SetActive(false);
                allowSpace = false;
        }
		else if (primeInt == 3){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
				 Char4speech_shake.text = "";
				 TalkButton.SetActive(false);
				 ButtonText1.text = "";
				 ArtChar1.SetActive(false);
				 ArtChar11.SetActive(true);
				 // nextButton.SetActive(false);
                // allowSpace = false;
				
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

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
		// evade button
        public void resetArt(){
		ArtChar1.SetActive(false);
		ArtChar11.SetActive(false);
		ArtChar2.SetActive(false);
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(false);
		ArtLaser1.SetActive(false);
		ArtLaser2.SetActive(false);
		ArtLaser3.SetActive(false);
		ArtLaser4.SetActive(false);
		ArtChar1.SetActive(false);
		ArtChar11.SetActive(false);
	   }
	   
	   
	   public void resetButtons(){
        NextScene1Button.SetActive(false);
		nextButton.SetActive(false);
        allowSpace = false;
		TalkButton.SetActive(false);
	   }
	   
	   
        public void TalkButton1(){
			talking();
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange7Lose(){
               SceneManager.LoadScene("Scene7");
        }

}

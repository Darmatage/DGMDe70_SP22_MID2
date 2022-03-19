using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class TemplateScript : MonoBehaviour {
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
        // public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
		resetArt();
		resetButtons();
		
        DialogueDisplay.SetActive(true);
        // ArtChar1.SetActive(false);
		// ArtChar11.SetActive(false);
		// ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        // ArtBG2.SetActive(false);
		// ArtLaser1.SetActive(false);
		// ArtLaser2.SetActive(false);
		// ArtLaser3.SetActive(false);
		// ArtLaser4.SetActive(false);
        // NextScene1Button.SetActive(false);
		
		nextButton.SetActive(true);
        allowSpace = true;
		// TalkButton.SetActive(false);
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
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Airlocks attached, Captain. Doors open on your word";
				 Char4speech_shake.text = "";
				 TalkButton.SetActive(true);
				 ButtonText1.text = "Go!";
				 nextButton.SetActive(false);
                allowSpace = false;
        }else if (primeInt == 3){
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
				 ArtChar1.SetActive(true);
				 ArtChar11.SetActive(true);
				 // nextButton.SetActive(false);
                // allowSpace = false;
				
		}else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "They’re attacking! ";
				 Char4speech_shake.text = "";
				 ArtLaser1.SetActive(true);
				 TalkButton.SetActive(true);
				 ButtonText1.text = "Fire!!";
				 nextButton.SetActive(false);
                allowSpace = false;
				ArtChar1.SetActive(true);
				 ArtChar11.SetActive(true);
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				 Char4speech_shake.text = "Fire! Fire! Fire!";
				 ArtChar2.SetActive(true);
				 ArtLaser2.SetActive(true);
				 TalkButton.SetActive(false);
				 nextButton.SetActive(false);
				 
				 
        }
		else if (primeInt == 6){
				 Char4speech_shake.text = "Fire! Fire! Fire! Fire! FIRE!";
				 ArtLaser3.SetActive(true);
			
        }
		else if (primeInt == 7){
                Char1name.text = "";
              	 TalkButton.SetActive(false);
				 nextButton.SetActive(false);
				 NextScene1Button.SetActive(true);
				 ArtLaser4.SetActive(true);
				 Char4speech_shake.text = "Fire! Fire! Fire! Fire! FIRE! FIRE!";
        }
}
       
	   
	   // this turns off ALL art to make it easier to reset the canvas
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

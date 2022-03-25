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
        public GameObject Char1Plate;
        public GameObject Char2Plate;
        public GameObject Char3Plate;
		    public Text ButtonText1;
		    public Text Char4speech_shake;
        public GameObject DialogueDisplay;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject ArtBG3;
		    public GameObject ArtChar1;
		    public GameObject ArtChar2;
        public GameObject ArtChar22;
        public GameObject ArtChar3;
        public GameObject ArtChar4;
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
    resetArt();
    DialogueDisplay.SetActive(false);
    ArtChar1.SetActive(false);
    ArtChar2.SetActive(false);
    ArtChar22.SetActive(false);
    ArtChar3.SetActive(false);
    ArtChar4.SetActive(false);
    ArtBG1.SetActive(true);
    ArtBG2.SetActive(false);
    ArtBG3.SetActive(false);
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
                ArtBG3.SetActive(true);
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Airlocks attached, Captain. Doors open on your word.";
				        Char4speech_shake.text = "";
				        TalkButton.SetActive(true);
				        ButtonText1.text = "Go!";
				        nextButton.SetActive(false);
                allowSpace = false;
        }
        else if (primeInt == 3){
                ArtBG3.SetActive(false);
                ArtBG1.SetActive(true);
                Char1Plate.SetActive(false);
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Make it so.";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4speech_shake.text = "";
				        TalkButton.SetActive(false);
				        ButtonText1.text = "";
				 // nextButton.SetActive(false);
                // allowSpace = false;

		}
    else if (primeInt == 4){
            DialogueDisplay.SetActive(false);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            ArtChar1.SetActive(true);
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
            ButtonText1.text = "";
     // nextButton.SetActive(false);
            // allowSpace = false;

}
else if (primeInt == 5){
        DialogueDisplay.SetActive(false);
        ArtBG2.SetActive(true);
        ArtChar2.SetActive(false);
        ArtChar22.SetActive(true);
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
        ButtonText1.text = "";
 // nextButton.SetActive(false);
        // allowSpace = false;
}
    else if (primeInt == 6){
      DialogueDisplay.SetActive(true);
                Char3Plate.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Lieutenant Rory";
                Char3speech.text = "They’re attacking! ";
				        Char4speech_shake.text = "";
				        ArtLaser1.SetActive(true);
				        TalkButton.SetActive(true);
				        ButtonText1.text = "Fire!!";
				        nextButton.SetActive(false);
                allowSpace = false;
				        ArtChar3.SetActive(true);
				        ArtChar4.SetActive(true);
        }
       else if (primeInt == 7){
                Char3Plate.SetActive(false);
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
		else if (primeInt == 8){
				 Char4speech_shake.text = "Fire! Fire! Fire! Fire! FIRE!";
				 ArtLaser3.SetActive(true);

        }
		else if (primeInt == 9){
                Char1name.text = "";
              	 TalkButton.SetActive(false);
				 nextButton.SetActive(false);
				 NextScene1Button.SetActive(true);
				 ArtLaser4.SetActive(true);
				 Char4speech_shake.text = "Fire! Fire! Fire! Fire! FIRE! FIRE!";
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
          ArtChar2.SetActive(false);
          ArtChar22.SetActive(false);
          ArtChar3.SetActive(false);
          ArtChar4.SetActive(false);
          ArtBG1.SetActive(false);
          ArtBG2.SetActive(false);
          ArtBG3.SetActive(false);
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

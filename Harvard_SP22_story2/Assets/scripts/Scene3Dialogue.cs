using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;

        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar2;
        public GameObject ArtBG1;
		public GameObject ArtBG_UnidentifiedVessel;
		public GameObject ArtBG_MissileFire;
		public GameObject ArtBG_ShipExplodes;
		public GameObject ArtBG_Headache;
        public GameObject Choice1;
        public GameObject Choice2;
        public GameObject nextButton;
        public GameObject Char1Plate;
        public GameObject Char2Plate;
        public GameObject Char3Plate;
        private bool allowSpace = true;

    public string playerName;
    public GameHandler gameHandler;

    void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
		ArtBG_UnidentifiedVessel.SetActive(false);
		ArtBG_MissileFire.SetActive(false);
		ArtBG_ShipExplodes.SetActive(false);
		ArtBG_Headache.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1.SetActive(false);
        Choice2.SetActive(false);
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
                ArtChar1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lt. Rory";
                Char2speech.text = "Captain, are you okay? ";
                Char3name.text = "";
                Char3speech.text = "";
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);
           
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = playerName;
                Char3speech.text = "I think so... what happened? ";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);

            
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lt. Rory";
                Char2speech.text = "We escaped the Pyhrran Dreadnought, thanks to you. ";
				Char3name.text = "";
                Char3speech.text = "";
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);
		
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = playerName;
                Char3speech.text = "What about the ship? ";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
        }
       else if (primeInt == 6){
   Char1name.text = "";
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lt. Rory";
                Char2speech.text = "All systems are online, but...";
				Char3name.text = "";
                Char3speech.text = "";
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);
               
        }
       else if (primeInt == 7){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = playerName;
            Char3speech.text = "What? ";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
            allowSpace = true;
		}
       else if (primeInt == 8){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "There’s something you need to see.";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
		 else if (primeInt == 9){
            ArtBG_UnidentifiedVessel.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
		else if (primeInt == 10){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }		



        else if (primeInt == 11){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
else if (primeInt == 12){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
				else if (primeInt == 13){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }

				else if (primeInt == 14){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }

				else if (primeInt == 15){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }

		else if (primeInt == 16){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
		else if (primeInt == 17){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
		else if (primeInt == 18){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }
				else if (primeInt == 19){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
        }

}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1Funct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "I don't know what you're talking about!";
                  if (primeInt != 9 || primeInt != 11 || primeInt != 12 || primeInt != 15 || primeInt != 17){
					primeInt = primeInt + 1;
				}
				if (primeInt == 9){
					primeInt = 10;
				}
					if (primeInt == 11){
					primeInt = 12;
				}
				if (primeInt == 12){
					primeInt = 13;
				}
				if (primeInt == 15){
					 SceneChange2();
				}
				if (primeInt == 17){
					 primeInt = 18;
				}
				if (primeInt == 18){
					  SceneChange4();
				}
				// primeInt = 99;
				
				if (primeInt != 18 || primeInt != 15){
					Choice1.SetActive(false);
					Choice2.SetActive(false);
					nextButton.SetActive(true);
					allowSpace = true;
					
					talking();
				}
        }
        public void Choice2Funct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Sure, anything you want... just lay off the club.";
                if (primeInt != 9 ||  primeInt != 11 || primeInt != 12 || primeInt != 15 || primeInt != 18 || primeInt != 19){
					primeInt = primeInt + 1;
				}
					if (primeInt == 9){
					primeInt = 11;
				}
					if (primeInt == 11){
					primeInt = 16;
				}
				if (primeInt == 12){
					SceneChange4();
				}
				if (primeInt == 15){
					 primeInt = primeInt + 1;
				}
				if (primeInt == 17){
					 primeInt = 19;
				}
				if (primeInt == 19){
					 SceneChange4();
				}
				// primeInt = 199;
				if ( primeInt != 12 || primeInt != 19) {
					Choice1.SetActive(false);
					Choice2.SetActive(false);
					nextButton.SetActive(true);
					allowSpace = true;
					
					talking();
				}
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene1a");
        }

		  public void SceneChange4(){
                SceneManager.LoadScene("Scene4");
        }
		
		// Not sure how to specifically go to scene 2.2?
		 public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }
}

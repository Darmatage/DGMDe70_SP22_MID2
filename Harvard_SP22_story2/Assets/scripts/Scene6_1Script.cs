using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6_1Script : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtAltBridge;
        public GameObject ArtNonAltBridge;
		public GameObject ArtRory;
		public GameObject ArtRory2;
		public GameObject ArtRory3;
        public GameObject NextScene1Button;
        public GameObject nextButton;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
		resetArt();
		resetButtons();
        DialogueDisplay.SetActive(true);
		ArtAltBridge.SetActive(true);
		nextButton.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
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
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
               // Char3name.text = "";
                // Char3speech.text = "";
				talking();
        }else if (primeInt == 3){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory3.SetActive(true);
				 // nextButton.SetActive(false);
                // allowSpace = false;
				
		}
		else if (primeInt == 4){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
        }
       else if (primeInt == 5){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Oh God my head. Why do I have two sets of memories?";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
        }
		else if (primeInt == 6){
				Char1name.text = "YOU";
                Char1speech.text = "The wormhole must have split our timeline into two...";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
		else if (primeInt == 7){
				Char1name.text = "YOU";
                Char1speech.text = "In one timeline, the EMP hit us, and in the other, we dodged it";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
		else if (primeInt == 8){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "In the wormhole, you reached for me. But you also grabbed the helm";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
        }
		else if (primeInt == 9){
				Char1name.text = "YOU";
                Char1speech.text = "Eureka!";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
		else if (primeInt == 9){
				Char1name.text = "YOU";
                Char1speech.text = "Eureka!";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
				else if (primeInt == 10){
				Char1name.text = "YOU";
                Char1speech.text = "Making that decision in the wormhole must have cause the timelines to entagle.";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
				else if (primeInt == 11){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Do you... remember dying?";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
        }
						else if (primeInt == 12){
				Char1name.text = "YOU";
                Char1speech.text = "Many times. It seems the timelines needed to synchronize for us to progress.";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
						else if (primeInt == 13){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "COMMAND";
                 StartCoroutine(TypeText(Char2speech,"This is Camander Zurchik hailing Captain {Playername} of the Gyrafalcon. Do you read me?"));
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
				ArtRory2.SetActive(true);
        }
						else if (primeInt == 14){
				Char1name.text = "YOU";
                Char1speech.text = "Loud and clear, Command...";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
								else if (primeInt == 15){
				Char1name.text = "YOU";
                Char1speech.text = "Things went south pretty fast when your transmiision failed, but we made it out in one piece";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
			else if (primeInt == 16){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "COMMAND";
                 StartCoroutine(TypeText(Char2speech, "When our transmission failed? Captain, this is our first attempt to hail."));
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
				ArtRory2.SetActive(true);
        }
			else if (primeInt == 17){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "The clock, Captain! We've gone back to before the dreadnought's attack!";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
        }
			else if (primeInt == 18){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "COMMAND";
                StartCoroutine(TypeText(Char2speech, "A dreadnought attack? We revieved notice of a battle over a territory on your course, but..."));
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
				ArtRory.SetActive(true);
        }
			else if (primeInt == 19){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "COMMAND";
                StartCoroutine(TypeText(Char2speech, "How did you survive a dreadnought attack?? And what's this about --gone back to before--?"));
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
				ArtRory2.SetActive(true);
        }
			else if (primeInt == 20){
				Char1name.text = "YOU";
                Char1speech.text = "Let's open that can of wormholes in a bit. Lieutenant Rory?";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
        }
					else if (primeInt == 20){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Lieutenant Rory";
                Char3speech.text = "Yes, Captain Playername";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory2.SetActive(true);
        }
					else if (primeInt == 21){
				Char1name.text = "YOU";
                Char1speech.text = "Full power to engines. We've a mission to complete.";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				resetArt();
				ArtNonAltBridge.SetActive(true);
				ArtRory.SetActive(true);
				resetButtons();
				NextScene1Button.SetActive(true);
        }
}
       
	   
	   // this turns off ALL art to make it easier to reset the canvas
	   public void resetArt(){
      ArtAltBridge.SetActive(false);
       ArtNonAltBridge.SetActive(false);
	ArtRory.SetActive(false);
		ArtRory2.SetActive(false);
		ArtRory3.SetActive(false);
	   }
	   
	   
	   public void resetButtons(){
        NextScene1Button.SetActive(false);
		nextButton.SetActive(false);
        allowSpace = false;
	   }
	   
	   

        public void SceneChange8(){
               SceneManager.LoadScene("Scene8");
        }
		
       IEnumerator TypeText(Text target, string fullText){
                float delay = 0.03f;
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

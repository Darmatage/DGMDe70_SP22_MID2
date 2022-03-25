using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5_winDialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
		  //  public Text TextOneAtATime; // shaking text
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar2;
        public GameObject ArtChar3;
        public GameObject ArtChar4;
        public GameObject ArtChar5;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject ArtBG3;
        public GameObject ArtBG4;
        public GameObject ArtBG5;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
		
       public string playerName;


void Start(){         // initial visibility settings
        resetArt();
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG4.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
		
	   string pNameTemp = gameHandler.GetName();
       playerName = pNameTemp.ToUpper();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking5c();
                }
        }
   }

//Story Units:
public void talking5c(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
			//Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(10f);
                DialogueDisplay.SetActive(true);
                Char3name.text = "Rory";
                Char3speech.text = "Airlock is attached, Captain. Doors open on your word.";
		//		TextOneAtATime.text = "Centurion Alpha Speca System. Star Date 5550. Star Code 234j22d1";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1.SetActive(true);
                ArtBG4.SetActive(false);
                ArtBG1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
		//		TextOneAtATime.text = "";
                Char2speech.text = "Make it so, Lieutenant.";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1.SetActive(false);
                ArtBG1.SetActive(false);
                ArtChar2.SetActive(true);
                ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
				//TextOneAtATime.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar3.SetActive(true);
                ArtChar4.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "We hailed you earlier - why didn't you answer?";
			//	TextOneAtATime.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char3name.text = "Unknown";
                Char3speech.text = "Our computers got fried by an EMP...";
                Char2name.text = "";
                Char2speech.text = "";
				//TextOneAtATime.text = "";
        }
       else if (primeInt ==7){
                Char3name.text = "Unknown";
                Char3speech.text = "And that was before we went through that wormhole.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt ==8){
                 Char3name.text = "Rory";
                 Char3speech.text = "Captain, look! The badge!";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==9){
                  ArtBG1.SetActive(true);
                  ArtChar2.SetActive(false);
                  ArtBG2.SetActive(false);
                  ArtChar3.SetActive(false);
                  ArtChar4.SetActive(false);
                  ArtBG5.SetActive(true);
                  ArtChar5.SetActive(true);
                  Char3name.text = playerName;
                  Char3speech.text = "That's impossible...";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt ==10){
                   ArtBG1.SetActive(false);
                   ArtChar2.SetActive(false);
                   ArtBG2.SetActive(true);
                   ArtChar3.SetActive(true);
                   ArtChar4.SetActive(true);
                   ArtBG5.SetActive(true);
                   ArtChar5.SetActive(false);
                   Char3name.text = playerName;
                   Char3speech.text = "Agh!";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt ==11){
                    ArtBG1.SetActive(false);
                    ArtChar2.SetActive(false);
                    ArtBG2.SetActive(true);
                    ArtChar3.SetActive(true);
                    ArtChar4.SetActive(true);
                    ArtBG5.SetActive(true);
                    ArtChar5.SetActive(false);
                    Char2name.text = "Unknown";
                    Char2speech.text = "Agh!";
                    Char3name.text = "";
                    Char3speech.text = "";
                    nextButton.SetActive(false);
                    NextScene1Button.SetActive(true);
            }
    //   else if (primeInt == 8){
      //          Char1name.text = "Rory";
        //        Char1speech.text = "Captain, look! The badge!";
          //      Char2name.text = "";
            //    Char2speech.text = "";
				//TextOneAtATime.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
              //  nextButton.SetActive(false);
              //  allowSpace = false;
              //  Choice1a.SetActive(true); // function Choice1aFunct()
              //  Choice1b.SetActive(true); // function Choice1bFunct()
        }




     public void resetArt(){
       ArtChar1.SetActive(false);
       ArtChar2.SetActive(false);
       ArtChar3.SetActive(false);
       ArtChar4.SetActive(false);
       ArtChar5.SetActive(false);
       ArtBG1.SetActive(false);
       ArtBG2.SetActive(false);
       ArtBG3.SetActive(false);
       ArtBG4.SetActive(false);
       ArtBG5.SetActive(false);
       // ArtChar11.SetActive(false);
      // ArtChar2.SetActive(false);
       //ArtBG1.SetActive(false);
       // ArtBG2.SetActive(false);
       // ArtLaser1.SetActive(false);
       // ArtLaser2.SetActive(false);
       // ArtLaser3.SetActive(false);
       // ArtLaser4.SetActive(false);
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
//        public void Choice1aFunct2a(){
  //              Char1name.text = "";
    //            Char1speech.text = "";
      //          Char2name.text = playerName;
        //        Char2speech.text = "I don't know what you're talking about!";
          //      primeInt = 99;
            //    Choice1a.SetActive(false);
              //  Choice1b.SetActive(false);
//                nextButton.SetActive(true);
  //              allowSpace = true;
    //    }
      //  public void Choice1bFunct2a(){
        //        Char1name.text = "";
          //      Char1speech.text = "";
            //    Char2name.text = playerName;
              //  Char2speech.text = "Sure, anything you want... just lay off the club.";
                //primeInt = 199;
//                Choice1a.SetActive(false);
  //              Choice1b.SetActive(false);
  //              nextButton.SetActive(true);
    //            allowSpace = true;
      //  }

//		IEnumerator TypeText(Text target, string fullText){
  //              float delay = 0.01f;
    //            nextButton.SetActive(false);
      //          allowSpace = false;
        //        delay = 0.01f;
          //      for (int i = 0; i < fullText.Length; i++){
            //            string currentText = fullText.Substring(0,i);
              //          target.text = currentText;
                //        yield return new WaitForSeconds(delay);
//                }
  //              nextButton.SetActive(true);
    //            allowSpace = true;
      //  }
//

       public void SceneChange1(){
              SceneManager.LoadScene("Scene6");
       }

      //  public void SceneChange5_win3(){
        //        SceneManager.LoadScene("Scene2b");
        //}
}

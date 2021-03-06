using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuScript : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public GameObject ArtBG;
        public GameObject TitleBG;
		public GameObject HookText;
		public GameObject PlayButton;
        public GameObject QuitButton;
		public GameObject CreditsButtons;
		public GameObject VolumeSlider;
		public GameObject ButtonNext;
		public GameObject InputTextField;
		public GameObject WelcomeDisplay;


void Start(){         // initial visibility settings
		// resetAll();

        ArtBG.SetActive(true);
        TitleBG.SetActive(true);
		HookText.SetActive(true);
		PlayButton.SetActive(true);
        QuitButton.SetActive(true);
		CreditsButtons.SetActive(true);
		VolumeSlider.SetActive(true);
		InputTextField.SetActive(false);
		WelcomeDisplay.SetActive(false);
		ButtonNext.SetActive(false);
   }


//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
		else if (primeInt == 2){
			   resetAll();
			   ArtBG.SetActive(true);
			   TitleBG.SetActive(true);
			   InputTextField.SetActive(true);
				WelcomeDisplay.SetActive(true);
				ButtonNext.SetActive(true);
				InputTextField.SetActive(true);
    
}
        // else if (primeInt == 3){
               // resetAll();
			   // ArtBG.SetActive(true);
			   // TitleBG.SetActive(true);
			   // InputTextField.SetActive(true);
				// WelcomeDisplay.SetActive(true);
				// ButtonNext.SetActive(true);
				// InputTextField.SetActive(true);
// }
}


	   // this turns off ALL art to make it easier to reset the canvas
	   public void resetAll(){
		ArtBG.SetActive(false);
        TitleBG.SetActive(false);
		HookText.SetActive(false);
		PlayButton.SetActive(false);
        QuitButton.SetActive(false);
		CreditsButtons.SetActive(false);
		VolumeSlider.SetActive(false);
		InputTextField.SetActive(false);
		WelcomeDisplay.SetActive(false);
		ButtonNext.SetActive(false);
	   }


        public void SceneChange7Lose(){
               SceneManager.LoadScene("Scene1");
        }

}

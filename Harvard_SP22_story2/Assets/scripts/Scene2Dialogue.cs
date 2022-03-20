using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
	public Text Choice1Text;
	public Text Choice2Text;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtBG1;
	public GameObject ArtBG_wormhole;
	public GameObject blue1;
        public GameObject Choice1;
        public GameObject Choice2;
        public GameObject ButtonScene3;
        // public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(true);
	ArtBG_wormhole.SetActive(true);
	blue1.SetActive(false);
        ArtBG1.SetActive(false);
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        ButtonScene3.SetActive(false);
        allowSpace = true;
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
                Char1name.text = "";
                Char1speech.text = "You punch it. As the nose of your vessel enters the wormhole, you see a flash of blue light from the Dreadnought. The blue ripples around you as the world as you knew it falls apart. ";
	// Char4speech_shake.text = "";

        }
        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "You feel reality rip into infinite threads yet somehow manage to perceive your lieutenant reaching for you through the quantum mire. You are floating out of your seat, away from the helm. You have an infinite moment to make your decision.";
	blue1.SetActive(true);
	ArtBG1.SetActive(true);
	ArtBG_wormhole.SetActive(false);
        Choice1.SetActive(true);
	Choice1Text.text = "Reach for Rory's hand";
        Choice2.SetActive(true);
	Choice2Text.text = "Reach for the helm";
        nextButton.SetActive(false);
	allowSpace = false;                       
	        }

       else if (primeInt == 100){
               Char1name.text = "";
               Char1speech.text = "You reach for Rory's hand and he pulls you to the floor beside him. For a brief moment, Rory's face seems split by a searing red glow and crackling blue electricity. Your vision darkens and your head aches. You lose consciousness.";

       }else if (primeInt == 200){
               Char1name.text = "";
               Char1speech.text = "You reach for the helm. You feel it in your hand and pull. A shock of blue electricity courses through your body and out into the room, dancing across monitors and into control boards. Your vision darkens and your head aches. You lose consciousness.";
       }
}		
	// Char4speech_shake.text = "";
	
        
        public void Choice1ButtonFun(){
                        Char1name.text = "";
                        Char1speech.text = "You reach for Rory's hand and he pulls you to the floor beside him. For a brief moment, Rory's face seems split by a searing red glow and crackling blue electricity. Your vision darkens and your head aches. You lose consciousness.";
                primeInt = 99;
                Choice1.SetActive(false);
                Choice2.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
                ButtonScene3.SetActive(true); 
        }
        public void Choice2ButtonFun(){
                        Char1name.text = "";
                        Char1speech.text = "You reach for the helm. You feel it in your hand and pull. A shock of blue electricity courses through your body and out into the room, dancing across monitors and into control boards. Your vision darkens and your head aches. You lose consciousness.";
                primeInt = 199;
                Choice1.SetActive(false);
                Choice2.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
                ButtonScene3.SetActive(true); 
        }       
        public void Scene3(){
               SceneManager.LoadScene("Scene3");
        }
}
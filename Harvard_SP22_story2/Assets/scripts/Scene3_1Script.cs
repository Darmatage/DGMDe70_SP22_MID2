using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3_1Script : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtBG1;
        public GameObject ArtBGExplosion;
	      public GameObject ArtBGShip;
		    public GameObject ArtBGHeadache;
        public GameObject ArtCharRory;
		    public GameObject choice1Button;
		    public Text choice1Text;
	    	public GameObject choice2Button;
	    	public Text choice2Text;
        public GameObject NextSceneButton;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
        public GameObject Char1Plate;
        public GameObject Char2Plate;
        public GameObject Char3Plate;
		
	   public string playerName;

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
        Char1Plate.SetActive(false);
        Char2Plate.SetActive(false);
        Char3Plate.SetActive(false);
		// TalkButton.SetActive(false);
		
		
		
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
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                Char1name.text = playerName;
                Char1speech.text = "Ow, my head.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                allowSpace = false;
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);
        }else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Glad to see you're awake, Captain. We took quite a beaing, and, well...";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);


		}else if (primeInt == 4){
                Char1name.text = playerName;
                Char1speech.text = "What is it, Rory?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = " Sorry, captain. It's just... I don't know where we are.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
	else if (primeInt == 6){
                Char1name.text = playerName;
                Char1speech.text = "You mean...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
		else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Yes, Captain. We entered the Wormhole and ended up.... Well, all I know is the star charts don't match any in our database.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 7){
                Char1name.text = playerName;
                Char1speech.text = "Lieutenant, do you know what this means?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Oh, we're lost?";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 9){
                Char1name.text = playerName;
                Char1speech.text = "I believe we've unlocked the secret to interdimensional travel! Damn it all! We're also going to miss the convention, ha. ";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "I… I suppose that's true, but... That won't matter unless we, you know.... Get back.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 11){
                Char1name.text = playerName;
                Char1speech.text = "Good point Lieutenant. Now scan the area.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Yes, Captain!";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 13){
	              resetArt();
	              ArtBGShip.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Sensors are picking up another standard class Galactic union ship! How did it get all the way out here?";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 14){
                Char1name.text = playerName;
                Char1speech.text = "Careful, this could be a pirate trap.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "They seem to be bouncing back our signal, Captain. We have no way of knowing whether they are Friend or Foe.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 16){
                Char1name.text = playerName;
                Char1speech.text = "Call them on the open Channel. Let's have a chat with our new neighbors.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Comms are open, Captain.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
              	resetButtons();
              	choice1Button.SetActive(true);
              	choice2Button.SetActive(true);
              	choice1Text.text = "Unidentified vessel! Respond immediately or we will be forced to treat you as hostile.";
              	choice2Text.text = "This is player name of the Galactic Union Fleet. If you hear this message please respond. We are here in peace.";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Nothing but space hiss. I don't like that one bit.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
else if (primeInt == 20){
                Char1name.text = playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                resetButtons();
              	choice1Button.SetActive(true);
              	choice2Button.SetActive(true);
              	choice1Text.text = "We've taken enough risks today. Destroy that ship, Lieutenant. That's an order.";
              	choice2Text.text = "Let's get some answers. Prepare to board.";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);
        }
else if (primeInt == 21){
                choice1Button.SetActive(false);
                choice2Button.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "FIRE MISSLES!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
else if (primeInt == 22){

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
	              resetArt();
	              ArtBGExplosion.SetActive(true);
                ArtCharRory.SetActive(false);
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(false);


        }
else if (primeInt == 23){
                Char1name.text = playerName;
                Char1speech.text = "My head…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
		            resetButtons();
		            resetArt();
                ArtBG1.SetActive(true);
                ArtCharRory.SetActive(false);
		          	ArtBGHeadache.SetActive(true);
		            NextSceneButton.SetActive(true);
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
		else if (primeInt == 24){
                Char1name.text = playerName;
                Char1speech.text = "My head…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
		            resetButtons();
		            NextSceneButton.SetActive(true);
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }
    else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "It's too silent out there for my liking.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }
    else if (primeInt == 31){
                Char1name.text = playerName;
                Char1speech.text = "I don't like it either... But I know what General Lome would say.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);
        }

    else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "What’s that Captain?";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);
        }

    else if (primeInt == 33){
                Char1name.text = playerName;
                Char1speech.text = "In the desperate nothing of space, even a rock could be a rescue.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }

    else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lieutenant Rory";
                Char2speech.text = "Sir? I'm not sure I catch your meaning.";
                Char3name.text = "";
                Char3speech.text = "";
                Char2Plate.SetActive(false);
                Char3Plate.SetActive(true);

        }

    else if (primeInt == 35){
                Char1name.text = playerName;
                Char1speech.text = "It means they're stranded, and we're all they've got. Prepare to board.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
            		resetButtons();
            		NextSceneButton.SetActive(true);
                Char2Plate.SetActive(true);
                Char3Plate.SetActive(false);

        }


}


	   // this turns off ALL art to make it easier to reset the canvas
	   public void resetArt(){
		     ArtBG1.SetActive(false);
         ArtBGExplosion.SetActive(false);
	       ArtBGShip.SetActive(false);
	       ArtBGHeadache.SetActive(false);
         ArtCharRory.SetActive(true);

	   }


	   public void resetButtons(){
        NextSceneButton.SetActive(false);
		    nextButton.SetActive(false);
        allowSpace = false;
	      choice1Button.SetActive(false);
        choice2Button.SetActive(false);


	   }

public void choice1button(){
		// hostile ++;
		gameHandler.updateAggressionScore(10);
		if (primeInt == 18){
       primeInt = 29;
       resetButtons();
       nextButton.SetActive(true);
       allowSpace = true;
       talking();
         }
    if (primeInt == 20){
  //mistake  if (primeInt == 20){
  //  SceneChange();
       nextButton.SetActive(true);
       allowSpace = true;
        talking();
      }
}


public void choice2button() {
// peaceful ++;
			gameHandler.updatePeacefulnessScore(10);
		   if (primeInt == 18){

            resetButtons();
            nextButton.SetActive(true);
            allowSpace = true;
            talking();
       }
       if (primeInt == 20){
             SceneChange();
		   }
}

public void SceneChange() {

   if (primeInt != 23) {
        SceneManager.LoadScene("Scene4");
   }
   else {
        SceneManager.LoadScene("Scene3");
   }
}

}

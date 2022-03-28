using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
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

    // public Text TextDelay;
    public Text Char4speech_shake;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject ArtBG4;
    public GameObject ArtBG5;
    public GameObject ChoiceNext;
    public GameObject ChoiceEvade1;
    public GameObject ChoiceEvade2;
    public GameObject ChoiceFight;
    public GameObject NextScene1aButton;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    // allow input name
    public string playerName;
    public GameHandler gameHandler;

    void Start() {         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtBG4.SetActive(false);
        ArtBG5.SetActive(false);
        ChoiceNext.SetActive(false);
        ChoiceEvade1.SetActive(false);
        ChoiceEvade2.SetActive(false);
        ChoiceFight.SetActive(false);
        NextScene1aButton.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        Char1Plate.SetActive(false);
        Char2Plate.SetActive(false);
        Char3Plate.SetActive(false);

        // input player name
        string pNameTemp = gameHandler.GetName();
        playerName = pNameTemp;
    }

    void Update() {         // use spacebar as Next button
        if (allowSpace == true) {
            if (Input.GetKeyDown("space")) {
                talking();
            }
        }
    }

    //Story Units:
    public void talking() {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1) {
            // AudioSource.Play();
        }
        else if (primeInt == 2) {
            ArtChar1.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "COMMAND";
            StartCoroutine(TypeText(Char1speech, "This is Commander Zurchik hailing Captain " + playerName + " of the Gyrfalcon. Do you read me? "));
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char1Plate.SetActive(true);
            Char2Plate.SetActive(false);
            //  if (playerHealth <= 5){
            //    primeInt = 10;//send story to frame 11
            //}
        }
        else if (primeInt == 3) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "Captain " + playerName + " receiving, Commander. ";
            //gameHandler.AddPlayerStat(1);
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(true);
        }
        else if (primeInt == 4) {
            Char1name.text = "COMMAND";
            StartCoroutine(TypeText(Char1speech, "We need a status report from the Galactic Union’s most capable ambassadors. How’s it going out there? "));
            Char2name.text = "";
            Char2speech.text = "";
            Char1Plate.SetActive(true);
            Char2Plate.SetActive(false);
        }
        else if (primeInt == 5) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "We are en route to Beta 9’s Intergalactic Conference as planned. In fact, we should arrive a few cycles before the Conference begins. ";
            //gameHandler.AddPlayerStat(1);
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(true);
        }
        else if (primeInt == 6) {
            Char1name.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "Anything to add, Lieutenant Rory?";
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(true);
        }
        else if (primeInt == 7) {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "No, Captain. Systems are stable and functioning as expected... ";
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
        }
        else if (primeInt == 8) {
            Char1name.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "We did move through some interference a few hours back, but that seems to have passed. ";
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
            // // Turn off "Next" button, turn on "Choice" buttons
            // nextButton.SetActive(false);
            // allowSpace = false;
            //  Choice1a.SetActive(true); // function Choice1aFunct()
            // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 9) {
            Char1name.text = "COMMAND";
            StartCoroutine(TypeText(Char1speech, "Thank you, Lieutenant. That may... {tchhkshhh} notice of a batt... {zztch} territory on your course. Avoid at... {tzzkkshh} mission... {ktchhhhssshhhh} "));
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char1Plate.SetActive(true);
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
            // // Turn off "Next" button, turn on "Choice" buttons
            // nextButton.SetActive(false);
            // allowSpace = false;
            //  Choice1a.SetActive(true); // function Choice1aFunct()
            // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 10) {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "Lieutenant, what’s going on? ";
            Char3name.text = "";
            Char3speech.text = "";
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);
        }
        else if (primeInt == 11) {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "It’s happening again, Captain. We must be getting jammed, there’s nothing wrong with our equip– ";
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
        }
        else if (primeInt == 12) {
            ArtBG1.SetActive(false);
            ArtBG5.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "";
            Char4speech_shake.text = "We’re receiving fire from a Pyhrran Dreadnought!! Your orders, Captain? ";
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
        }
        else if (primeInt == 13) {
            ArtBG5.SetActive(false);
            ArtBG2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4speech_shake.text = "";
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);
            ChoiceNext.SetActive(true);
            ChoiceEvade2.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 14) {
            DialogueDisplay.SetActive(false);
            Char1Plate.SetActive(false);
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(false);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(false);
            ArtBG3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char4speech_shake.text = "";
            ChoiceNext.SetActive(false);
            ChoiceEvade2.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }


        else if (primeInt == 15) {
            DialogueDisplay.SetActive(true);
            Char3Plate.SetActive(true);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(false);
            ArtBG3.SetActive(false);
            ArtBG4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "Shields at 80 percent, Captain. We’re safe for now, but we can’t do this all day! ";
            Char4speech_shake.text = "";
            Char3Plate.SetActive(true);
        }

        else if (primeInt == 16) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "No. We'll have to... ";
            Char3name.text = "";
            Char3speech.text = "";
            Char4speech_shake.text = "";
            Char3Plate.SetActive(false);
            Char2Plate.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            nextButton.SetActive(false);
            ChoiceEvade1.SetActive(true);
            ChoiceFight.SetActive(true);
        }

        //EVADE option

        else if (primeInt == 20) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "Captain " + playerName + ", look! It’s a wormhole! ";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            nextButton.SetActive(true);
            ChoiceEvade1.SetActive(false);
            ChoiceFight.SetActive(false);
            ChoiceNext.SetActive(false);
        }
        else if (primeInt == 21) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "Could we use it to escape? ";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);

        }
        else if (primeInt == 22) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "The risk would be huge. We can’t know what will happen once we enter its event horizon. ";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);

        }
        else if (primeInt == 23)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Lt. Rory";
            Char3speech.text = "Crap, they’re readying an EMP!! Your orders, Captain? ";
            Char2Plate.SetActive(false);
            Char3Plate.SetActive(true);

        }
        else if (primeInt == 24)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName.ToUpper();
            Char2speech.text = "For our best chance of survival, we must...";
            Char3name.text = "";
            Char3speech.text = "";
            Char2Plate.SetActive(true);
            Char3Plate.SetActive(false);
            NextScene1aButton.SetActive(true);
            NextScene2Button.SetActive(true);


        }
    }

        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        // evade button
        public void ChoiceEvade1Fun() {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 20 - 1;
            ChoiceEvade1.SetActive(false);
            ChoiceEvade2.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            talking();
        }

        // fight for our lives button
        //public void ChoiceEvade2Fun() {
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "";
        //    Char2speech.text = "";
        //    primeInt = 20 - 1;
        //    ChoiceEvade1.SetActive(false);
        //    ChoiceEvade2.SetActive(false);
        //    nextButton.SetActive(true);
        //    allowSpace = true;

        //}

        // just link this to fight for our lives button
        public void NextScene1aFun() {
            gameHandler.updateAggressionScore(10);
            SceneManager.LoadScene("Scene1a");
        }
        public void NextScene2Fun() {
            gameHandler.updatePeacefulnessScore(10);
            SceneManager.LoadScene("Scene2");
        }

        IEnumerator TypeText(Text target, string fullText) {
            float delay = 0.02f;
            nextButton.SetActive(false);
            allowSpace = false;
            for (int i = 0; i < fullText.Length; i++) {
                string currentText = fullText.Substring(0, i);
                target.text = currentText;
                yield return new WaitForSeconds(delay);
            }
            nextButton.SetActive(true);
            allowSpace = true;
        }


}

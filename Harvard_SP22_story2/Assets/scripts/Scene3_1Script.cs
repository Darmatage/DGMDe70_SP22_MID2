using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3_1Script : MonoBehaviour
{
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
    public GameObject ArtBGWormhole;
    public GameObject ButtonChoiceDestroy1;
    public GameObject ButtonChoiceDestroy2;
    public GameObject ButtonChoiceAggressive;
    public GameObject ButtonChoicePeaceful;
    public GameObject ButtonChoiceNext;
    public GameObject ButtonChoiceScene4;
    public GameObject nextButton;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;
    public GameObject CommandPlate;
    public GameObject YouPlate;
    public GameObject RoryPlate;

    public string playerName;

    void Start()
    {         // initial visibility settings
        resetArt();
        resetButtons();

        DialogueDisplay.SetActive(false);

        ArtBG1.SetActive(true);
        ArtBGExplosion.SetActive(false);
        ArtBGShip.SetActive(false);
        ArtBGHeadache.SetActive(true);
        ArtBGWormhole.SetActive(false);
        ArtCharRory.SetActive(true);

        nextButton.SetActive(true);
        allowSpace = true;
        CommandPlate.SetActive(false);
        YouPlate.SetActive(false);
        RoryPlate.SetActive(false);




        string pNameTemp = gameHandler.GetName();
        playerName = pNameTemp.ToUpper();
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    //Story Units:
    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }

        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "Captain, are you okay? ";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = playerName;
            Char3speech.text = "I think so... what happened? ";
            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);


        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "We escaped the Pyhrran Dreadnought, thanks to you. ";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = playerName;
            Char3speech.text = "What about the ship? ";
            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "All systems are online, but...";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = playerName;
            Char3speech.text = "What? ";
            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);
            allowSpace = true;
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "Clear your head. There’s something you need to see.";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);
        }
        else if (primeInt == 9)
        {
            ArtBGShip.SetActive(true);
            ArtBGHeadache.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "That ship was there when I regained consciousness... ";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lt. Rory";
            Char2speech.text = "According to the scanner, it’s the same model as the Gyrfalcon. Do you know what that means? ";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 11)
        {
            Char1name.text = playerName;
            Char1speech.text = "We must still be in the 29th century. Have they attempted to make contact? ";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 12)
        {
            Char1name.text = "Lt. Rory";
            Char1speech.text = "No, Captain. It seems they’re on emergency power- stranded out here. They may be having shipwide malfunctions. ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 13)
        {

            Char1name.text = playerName;
            Char1speech.text = "What else do we know about them?";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 14)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "This is where things get weird... ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 15)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "They’re not just the same model of ship. They’re exactly like us. ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 16)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "So they’re Galactic Union? We have to rescue them! ";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 17)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "It’s not that simple, Captain. According to their ID, the name of their ship is the Gyrfalcon... ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 18)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "And the Captain of the vessel is " + playerName + ". ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 19)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "That’s impossible. ";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 20)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "I do have a theory, but it’s a troubling one. ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 21)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "Well, out with it, Lieutenant! ";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 22)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "Sometimes, pirates are able to capture Galactic Union vessels intact, usually during refueling in dangerous territories. ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 23)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "They use these captured ships as decoys, and it would be a simple task to code an ID chip to copy and return the signal that scans it. ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 24)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "So they’re pirates?";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 25)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "That’s one possibility. But it’s just as likely that our scanner was busted by the wormhole.";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 26)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "If they are a Galactic Union crew, we are mandated to save them. ";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 27)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "Yes, Captain. But we can’t confirm their identity. They could kill us as soon as we turn our backs. ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 28)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "Well, shit. ";

            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 29)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "What are your orders, Captain? ";

            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 30)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "The mission must come first...";

            ButtonChoiceDestroy1.SetActive(true);
            ButtonChoiceNext.SetActive(true);
            allowSpace = false;
            nextButton.SetActive(false);
            YouPlate.SetActive(true);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 31)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "Understood. Comms open. ";

            resetButtons();
            nextButton.SetActive(true);
            allowSpace = true;
            YouPlate.SetActive(false);
            RoryPlate.SetActive(true);

        }
        else if (primeInt == 32)
        {
            //Char1name.text = "Lt. Rory";
            Char1name.text = playerName;
            Char1speech.text = "Unidentified vessel! You are being hailed by the Captain of the Gyrfalcon... ";

            resetButtons();
            ButtonChoiceAggressive.SetActive(true);
            ButtonChoicePeaceful.SetActive(true);
            YouPlate.SetActive(false);
            RoryPlate.SetActive(false);
        }
        else if (primeInt == 33)
        {
            Char1name.text = "RADIO";
            //Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "... ... ... ... "));

            CommandPlate.SetActive(true);
            YouPlate.SetActive(false);
            RoryPlate.SetActive(false);

        }
        else if (primeInt == 34)
        {
            Char1name.text = "Lt. Rory";
            //Char1name.text = playerName;
            Char1speech.text = "Nothing but space hiss. I don't like this one bit. ";

            CommandPlate.SetActive(true);
            YouPlate.SetActive(false);
            RoryPlate.SetActive(false);

        }



    }


    // this turns off ALL art to make it easier to reset the canvas
    public void resetArt()
    {
        ArtBG1.SetActive(false);
        ArtBGExplosion.SetActive(false);
        ArtBGShip.SetActive(false);
        ArtBGHeadache.SetActive(false);
        ArtCharRory.SetActive(false);

    }


    public void resetButtons()
    {
        ButtonChoiceScene4.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = false;
        ButtonChoiceAggressive.SetActive(false);
        ButtonChoicePeaceful.SetActive(false);
        ButtonChoiceDestroy1.SetActive(false);
        ButtonChoiceDestroy2.SetActive(false);
        ButtonChoiceNext.SetActive(false);
        ButtonChoiceScene4.SetActive(false);



    }

    public void ButtonChoiceDestroy1Fun()
    {
        resetArt();
        resetButtons();
        ArtBGExplosion.SetActive(true);
        primeInt = 100 - 1;
        nextButton.SetActive(true);
        allowSpace = true;
        talking();
    }


    public void ButtonChoiceAggressiveFun()
    {
        // hostile ++;
        gameHandler.updateAggressionScore(10);

        resetButtons();
        nextButton.SetActive(true);
        allowSpace = true;
        talking();
    }

    public void ButtonChoicePeacefulFun()
    {
        // peaceful ++;
        gameHandler.updatePeacefulnessScore(10);

        resetButtons();
        nextButton.SetActive(true);
        allowSpace = true;
        talking();
    }



    public void SceneChange()
    {

        if (primeInt != 25)
        {
            SceneManager.LoadScene("Scene4");
        }
        else
        {
            SceneManager.LoadScene("Scene3");

        }


    }
    IEnumerator TypeText(Text target, string fullText)
    {
        float delay = 0.02f;
        nextButton.SetActive(false);
        allowSpace = false;
        for (int i = 0; i < fullText.Length; i++)
        {
            string currentText = fullText.Substring(0, i);
            target.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        nextButton.SetActive(true);
        allowSpace = true;
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerStatsEndScenes : MonoBehaviour {

	public GameHandler gameHandler;
	public Text AggressionScore;
	public Text PeacefulnessScore;
	public Text WinMessage;
	public string playerName;
	
	   
    // Start is called before the first frame update
    void Start()
    {
		string pNameTemp = gameHandler.GetName();
       playerName = pNameTemp.ToUpper();
AggressionScore.text = "Aggression Score: " + gameHandler.checkAggressionScore().ToString();
		PeacefulnessScore.text = "Peacefulness Score: " + gameHandler.checkPeacefulnessScore().ToString();
		WinMessage.text = playerName + ", you have travailed through space, through wormholes and portals. And now your are victorious. You reach for Rory's hand in celebration and exit the bridge together.";
    }

    // Update is called once per frame
    void Update()
    {
        AggressionScore.text = "Aggression Score: " + gameHandler.checkAggressionScore().ToString();
		PeacefulnessScore.text = "Peacefulness Score: " + gameHandler.checkPeacefulnessScore().ToString();
		// StartCoroutine(TypeText(AggressionScore, "Aggression Score: " + gameHandler.checkAggressionScore().ToString()));
		 // StartCoroutine(TypeText(PeacefulnessScore,"Peacefulness Score: " + gameHandler.checkPeacefulnessScore().ToString()));
		// StartCoroutine(TypeText(WinMessage, playerName + ", you have travailed through space, through wormholes and portals. And now your are victorious. You reach for Rory's hand in celebration and exit the bridge together."));
		WinMessage.text = playerName + ", you have travailed through space, through wormholes and portals. And now your are victorious. You reach for Rory's hand in celebration and exit the bridge together.";


    }
	
	
        // IEnumerator TypeText(Text target, string fullText){
                // float delay = 0.035f;
                // for (int i = 0; i < fullText.Length; i++){
                        // string currentText = fullText.Substring(0,i);
                        // target.text = currentText;
                        // yield return new WaitForSeconds(delay);
                // }
        // }
}

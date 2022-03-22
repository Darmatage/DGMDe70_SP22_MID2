using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
	
	 public GameHandler gameHandler;
	 public Text AggressionScore;
	 public Text PeacefulnessScore;
    // Start is called before the first frame update
    void Start()
    {
        AggressionScore.text = "Aggression Score: " + gameHandler.checkAggressionScore().ToString();
		PeacefulnessScore.text = "Peacefulness Score: " + gameHandler.checkPeacefulnessScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour {

        public static int playerStat;
		public static int AggressionScore = 0;
		public static int PeacefulnessScore = 0;
		
		// InputName Code
		public static string playerName = "Dope Name";
		
		


        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;

        void Awake (){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start (){
			// AggressionScore = 0;  // this will activate every new scene
			// PeacefulnessScore = 0;
                pauseMenuUI.SetActive(false);
				  Debug.Log("gameHander start() activated");
        }

        void Update (){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
                {
                if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("MainMenu")) 
                {
                pauseMenuUI.SetActive(false);
                        }
                }

                
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }

        public void UpdatePlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        }
		
		public int setPlayerStats(){
				AggressionScore = 0;
				PeacefulnessScore = 0;
				return 0;
		}
		
		// PlayerStats
		public void updateAggressionScore(int amount){
                AggressionScore += amount;
                Debug.Log("Current Player AggressionScore Stat = " + AggressionScore);
        }
		
		public void updatePeacefulnessScore(int amount){
                PeacefulnessScore += amount;
                Debug.Log("Current Player PeacefulnessScore Stat = " + PeacefulnessScore);
        }
		
		public int checkAggressionScore(){
                return AggressionScore;
        }
		
		public int checkPeacefulnessScore(){
                return PeacefulnessScore;
        }

        public int CheckPlayerStat(){
                return playerStat;
        }

        public void StartGame(){
				AggressionScore = 0;
			PeacefulnessScore = 0;
			  Debug.Log("gameHander startGame() activated");
                SceneManager.LoadScene("Scene1");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
				AggressionScore = 0;
				PeacefulnessScore = 0;
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
		
		    public void SceneChangeCredits(){
               SceneManager.LoadScene("Credits");
        }
		
		  public void UpdateName(string newName){
            playerName = newName;
            Debug.Log("name changed to " + playerName);
      }
      public string GetName(){
            return playerName;
      }

}
    
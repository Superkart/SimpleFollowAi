using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //Instance of the UiManager class
    [SerializeField] private UiManagement uim;


    #region Button Click Methods

    //Function to Start Game (Loads scene 1)
    public void StartGame() 
    { 
        SceneManager.LoadScene(1);
    }

    //Function to quit the game
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    //Function that loads Main Menu Scene (Loads scene 0)
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    //Function to Resume the game if its paused
    public void ResumeGame()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1; ;
            uim.GetPauseMenu().SetActive(false);
        }
    }

    //Function to retry the level
    public void Retry()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    #endregion

}

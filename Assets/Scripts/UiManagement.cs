using UnityEngine;
using UnityEngine.UI;

public class UiManagement : MonoBehaviour
{
    //[SerializeField] private PlayerMovement player;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Text healthText;

    #region UnityMethods

    private void Awake()
    {
        gameOverMenu.SetActive(false);
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) //Opens the GameoverMenu when "K" is pressed
        {
            if(gameOverMenu.activeSelf == false)
            gameOverMenu.SetActive(true);
        }    
        if (Input.GetKeyDown(KeyCode.P)) //Pauses the game when "P" is pressed
        {
            if(Time.timeScale > 0)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
        }       
    }

    #endregion


    #region Getter and Setter Methods

    public GameObject GetGameOverMenu() { return gameOverMenu; }

    public GameObject GetPauseMenu() {  return pauseMenu; }

    #endregion

    public void UpdatePlayerHealthUi()
    {
        healthText.text = "Health:" + PlayerMovement.GetPlayerHealth();
    }

}

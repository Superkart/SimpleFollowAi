using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private UiManagement uim; // Uimanager instance 
    [SerializeField] private int playerSpeed = 5;
    private static int health = 100;

    #region Unity Methods

    private void Update()
    {
        #region Movement Mechanics

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * Vector3.right * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
        }
        #endregion
    }

    #endregion

    //Function that detects collision with the final goal 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Time.timeScale = 0f;
            uim.GetGameOverMenu().SetActive(true);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            //ReducePlayerHealth(5);
            //uim.UpdatePlayerHealthUi();
            //Debug.Log("Current player health = " + health);
            Time.timeScale = 0f;
            uim.GetGameOverMenu().SetActive(true);
        }
    }

    public static int ReducePlayerHealth(int value)
    {
        health = health - value;
        return health;
    }

    public static int GetPlayerHealth()
    {
        return health;
    }

    public static void SetPlayerHealth(int value)
    {
        health = value;
    }

}

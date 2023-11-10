using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{

    // Declare a delegate
    public delegate void StartButtonDelegate();

    // Declare an event using the delegate
    public static event StartButtonDelegate OnAccountCreated;

    private void Start()
    {
        // Check if the user has already gone through the setup
        /*  if (PlayerPrefs.HasKey("SetupComplete"))
          {
              // If yes, directly load the main page
              SceneManager.LoadScene("SignIn");
          }
          else
          {
              // If not, the user is in the welcome page
          }*/
    }


    public void OnStartButtonClicked()
    {

        // Set a PlayerPrefs key to indicate that the setup is complete
        PlayerPrefs.SetInt("SetupComplete", 1);

        // Save the preferences
        PlayerPrefs.Save();

        // Load the create account scene
        SceneManager.LoadScene("CreateAccount");
    }

    public void OnCreateAccountButtonClicked()
    {
        OnAccountCreated?.Invoke();

        // Load the main page
        SceneManager.LoadScene("MainPage");
    }

    public void OnSignInButtonClicked()
    {
        // Load the main page
        SceneManager.LoadScene("MainPage");
    }
}

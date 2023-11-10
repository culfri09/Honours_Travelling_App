using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Log_In_Manager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputFieldEmail;
    [SerializeField] private TMP_InputField inputFieldPassword;
    [SerializeField] private TextMeshProUGUI incorrectCredential;
    [SerializeField] private GameObject incorrectCredentialsLayout;

    private void Start()
    {
        // Subscribe to the SignInButtonDelegate's event
        Scene_Manager.OnSignIn += CheckCredentials;
    }

    public void CheckCredentials()
    {
        string storedEmail = PlayerPrefs.GetString("Email");
        string storedPassword = PlayerPrefs.GetString("Password");

        if (inputFieldEmail.text == storedEmail && inputFieldPassword.text == storedPassword)
        {
            SceneManager.LoadScene("MainPage");
            incorrectCredentialsLayout.SetActive(false);
            return; // Exit early for correct credentials
        }

        incorrectCredentialsLayout.SetActive(true);

        if (inputFieldEmail.text != storedEmail)
        {
            incorrectCredential.text = "email";
        }
         if (inputFieldPassword.text != storedPassword)
        {
            incorrectCredential.text = "password";
        }
         if (inputFieldEmail.text != storedEmail && inputFieldPassword.text != storedPassword)
        {
            incorrectCredential.text = "credentials";
        }


    }
    }


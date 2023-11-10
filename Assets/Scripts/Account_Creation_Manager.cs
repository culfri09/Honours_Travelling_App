using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Account_Creation_Manager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputFieldUserName;
    [SerializeField] private TMP_InputField inputFieldEmail;
    [SerializeField] private TMP_InputField inputFieldPassword;

    private void Start()
    {
        // Subscribe to the StartButtonHandler's event
        Scene_Manager.OnAccountCreated += SaveUserData;
    }

    // Save the user input to PlayerPrefs
    public void SaveUserData()
    {
        PlayerPrefs.SetString("User Name", inputFieldUserName.text);
        PlayerPrefs.SetString("Email", inputFieldEmail.text);
        PlayerPrefs.SetString("Password", inputFieldPassword.text);

        // Save the data
        PlayerPrefs.Save();
    }
}

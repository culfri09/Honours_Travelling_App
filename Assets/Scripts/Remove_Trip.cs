using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Remove_Trip : MonoBehaviour
{
    private Trip_Manager tripManager;

    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }


    public void RemoveLondonTrip()
    {
        tripManager.upcomingTripsNumber--;
        tripManager.DeleteTripFromList("London");
        SceneManager.LoadScene("MainPage");
    }

    public void RemoveJapanTrip()
    {
        tripManager.upcomingTripsNumber--;
        tripManager.DeleteTripFromList("Japan");
        SceneManager.LoadScene("MainPage");
    }
}

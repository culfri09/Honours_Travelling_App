using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choose_Trip : MonoBehaviour
{
    private Trip_Manager tripManager;
    [SerializeField] private GameObject londonTrip;
    [SerializeField] private GameObject japanTrip;

    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }
    

    public void ChooseLondonTrip()
    {
       // tripManager.upcomingTripsNumber++;
        tripManager.AddTripToList("London");     
        SceneManager.LoadScene("MainPage");
    }

    public void ChooseJapanTrip()
    {
        //tripManager.upcomingTripsNumber++;
        tripManager.AddTripToList("Japan");       
        SceneManager.LoadScene("MainPage");
    }
}

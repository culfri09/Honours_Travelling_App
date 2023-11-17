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
        if (!tripManager.TripList.Contains("London")){
            tripManager.AddTripToList("London");
        }        
        SceneManager.LoadScene("MainPage");
    }

    public void ChooseJapanTrip()
    {
        if (!tripManager.TripList.Contains("Japan"))
        {
            tripManager.AddTripToList("Japan");
        }
        SceneManager.LoadScene("MainPage");
    }
}

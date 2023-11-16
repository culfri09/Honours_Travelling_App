using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upcoming_Trips_Manager : MonoBehaviour
{
    private Trip_Manager tripManager;

    [SerializeField] private Text upcomingTripsText;

    private int upcomingTripsNumber = 0;


    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }

    // Update is called once per frame
    void Start()
    {
        if (tripManager.TripList.Contains("London")){
            AddLondonTrip();
        }

        if (tripManager.TripList.Contains("Japan")){
           AddJapanTrip();
            }
        }
  
    private void AddLondonTrip()
    {
            upcomingTripsNumber++;
            upcomingTripsText.text = upcomingTripsNumber.ToString() + " places";
     }
    private void AddJapanTrip()
    {
        upcomingTripsNumber++;
        upcomingTripsText.text = upcomingTripsNumber.ToString() + " places";
    }


}

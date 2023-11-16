using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upcoming_Trips_Manager : MonoBehaviour
{
    private Trip_Manager tripManager;

    [SerializeField] private Text upcomingTripsText;

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

    private void Update()
    {
        upcomingTripsText.text = tripManager.upcomingTripsNumber.ToString() + " places";
    }

    private void AddLondonTrip()
    {
        Debug.Log("Add London");
    }
    private void AddJapanTrip()
    {
        Debug.Log("Add Japan");
    }

}

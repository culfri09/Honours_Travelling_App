using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trip_Manager : MonoBehaviour
{

    public List<Trip> tripList = new List<Trip>();

    [SerializeField] private Text upcomingTripsText;

    private int upcomingTripsNumber = 1;
 /*   public void AddList(Trip trip)
    {
        tripList.Add(trip);
        upcomingTripsNumber++;
        Debug.Log(upcomingTripsNumber);
        upcomingTripsText.text = upcomingTripsNumber.ToString() + "places";
    }*/

    public void AddTrip()
    {
        upcomingTripsNumber++;
        upcomingTripsText.text = upcomingTripsNumber.ToString() + " places";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
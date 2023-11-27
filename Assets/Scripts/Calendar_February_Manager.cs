using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar_February_Manager : MonoBehaviour
{
    private Trip_Manager tripManager;

    [SerializeField] private GameObject calendar;

    [SerializeField] private GameObject londonTrip;


    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (tripManager.TripList.Contains("London"))
        {
            AddLondonTrip();
        }
        if (!tripManager.TripList.Contains("London"))
        {
            RemoveLondonTrip();
        }
    }
    private void RemoveLondonTrip()
    {
        calendar.SetActive(true);
        londonTrip.SetActive(false);
    }

    private void AddLondonTrip()
    {
        calendar.SetActive(false);
        londonTrip.SetActive(true);
    }
}

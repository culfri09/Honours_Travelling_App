using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar_Japan : MonoBehaviour
{
    private Trip_Manager tripManager;

    [SerializeField] private GameObject calendar;

    [SerializeField] private GameObject japanTrip;


    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (tripManager.TripList.Contains("Japan"))
        {
            AddJapanTrip();
        }
        if (!tripManager.TripList.Contains("Japan"))
        {
            RemoveJapanTrip();
        }
    }
    private void RemoveJapanTrip()
    {
        calendar.SetActive(true);
        japanTrip.SetActive(false);
    }

    private void AddJapanTrip()
    {
        calendar.SetActive(false);
        japanTrip.SetActive(true);
    }
}

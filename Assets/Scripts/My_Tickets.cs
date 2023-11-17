using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_Tickets : MonoBehaviour
{
    private Trip_Manager tripManager;

    [SerializeField] private GameObject londonTrip;

    [SerializeField] private GameObject japanTrip;

    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }

    // Update is called once per frame
    void Start()
    {

        if (tripManager.TripList.Contains("London"))
        {
            AddLondonTrip();
        }

        if (tripManager.TripList.Contains("Japan"))
        {
            AddJapanTrip();
        }
    }


    private void AddLondonTrip()
    {
        londonTrip.SetActive(true);
    }
    private void AddJapanTrip()
    {
        japanTrip.SetActive(true);
        if (londonTrip.activeSelf == false)
        {
            japanTrip.transform.position = londonTrip.transform.position;
        }
    }
}

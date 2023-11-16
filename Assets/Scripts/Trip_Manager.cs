using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Trip_Manager : MonoBehaviour
{
    // Singleton instance
    private static Trip_Manager _instance;

    // List to store trips
    public List<string> TripList = new List<string>();

    // Public property to access the instance
    public static Trip_Manager Instance
    {
        get
        {
            if (_instance == null)
            {
                // If there is no instance, find it in the scene
                _instance = FindObjectOfType<Trip_Manager>();

                // If no instance is found, create a new one
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("TripManagerSingleton");
                    _instance = singletonObject.AddComponent<Trip_Manager>();
                }
            }

            return _instance;
        }
    }

    void Awake()
    {
        // Ensure only one instance exists
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // If another instance exists, destroy this one
            Destroy(this.gameObject);
        }
    }


    public void AddTripToList(string trip)
    {
        TripList.Add(trip);
    }
}

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
    public List<string> FavoriteList = new List<string>();

    public string[] tripDates = { "13_March", "15_March", "17_March", "24_Feb", "25_Feb", "26_Feb"};

    public int upcomingTripsNumber;
    
    private const string UpcomingTripsKey = "UpcomingTripsNumber";
    private const string TripListKey = "TripList";
    private const string FavoriteListKey = "FavoriteList";


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

    private void Update()
    {
        upcomingTripsNumber = TripList.Count;
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

        // Load the TripList from PlayerPrefs
        LoadData();
     
    }

    public void AddTrip(string tripDate)
    {
        FavoriteList.Add(tripDate);
        SaveData();
    }
    public void AddTripToList(string trip)
    {
        TripList.Add(trip);
        SaveData(); // Save the updated TripList
    }

    public void DeleteTripFromList(string trip)
    {
        FavoriteList.Remove(trip);
        SaveData(); // Save the updated TripList
    }

    public void DeleteFavoriteFromList(string trip)
    {
        TripList.Remove(trip);
        SaveData(); // Save the updated TripList
    }

    // Save the TripList to PlayerPrefs
    private void SaveData()
    {
        PlayerPrefs.SetString("TripList", string.Join(",", TripList.ToArray()));
        PlayerPrefs.SetString(FavoriteListKey, string.Join(",", FavoriteList.ToArray()));
        PlayerPrefs.SetInt(UpcomingTripsKey,upcomingTripsNumber);
        PlayerPrefs.Save();
    }

    // Load the TripList from PlayerPrefs
    private void LoadData()
    {
        string savedTripList = PlayerPrefs.GetString("TripList", "");
        string savedFavoriteList = PlayerPrefs.GetString(FavoriteListKey, "");
        upcomingTripsNumber = PlayerPrefs.GetInt(UpcomingTripsKey, 0);

        if (!string.IsNullOrEmpty(savedTripList))
        {
            TripList = new List<string>(savedTripList.Split(','));
        }

        if (!string.IsNullOrEmpty(savedFavoriteList))
        {
            FavoriteList = new List<string>(savedFavoriteList.Split(','));
        }
    }
}

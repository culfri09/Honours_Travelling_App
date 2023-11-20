using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Favorites_Manager : MonoBehaviour
{
    private Trip_Manager tripManager;
    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }

    public void Add13March()
    {
        if (!tripManager.FavoriteList.Contains(tripManager.tripDates[0]))
        {
            tripManager.AddTrip(tripManager.tripDates[0]);
        }
    }
    public void Add15March()
    {
        if (!tripManager.FavoriteList.Contains(tripManager.tripDates[1]))
        {
            tripManager.AddTrip(tripManager.tripDates[1]);
        }
    }

    public void Add17March()
    {
        if (!tripManager.FavoriteList.Contains(tripManager.tripDates[2]))
        {
            tripManager.AddTrip(tripManager.tripDates[2]);
        }
    }

    public void Add24Feb()
    {
        if (!tripManager.FavoriteList.Contains(tripManager.tripDates[3]))
        {
            tripManager.AddTrip(tripManager.tripDates[3]);
        }
    }

    public void Add25Feb()
    {
        if (!tripManager.FavoriteList.Contains(tripManager.tripDates[4]))
        {
            tripManager.AddTrip(tripManager.tripDates[4]);
        }
    }

    public void Add26Feb()
    {
        if (!tripManager.FavoriteList.Contains(tripManager.tripDates[5]))
        {
            tripManager.AddTrip(tripManager.tripDates[5]);
        }
    }
}

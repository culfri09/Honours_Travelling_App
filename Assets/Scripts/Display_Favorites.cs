using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Display_Favorites : MonoBehaviour
{
    [SerializeField] private GameObject thirteenMarch;
    [SerializeField] private GameObject fifteenMarch;
    [SerializeField] private GameObject seventeenMarch;
    [SerializeField] private GameObject fifteen1March;


    private Trip_Manager tripManager;
    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tripManager.FavoriteList.Contains("13_March"))
        {
            AddThirteenMarch();
        }
        if (tripManager.FavoriteList.Contains("15_March"))
        {
            AddfifteenMarchMarch();
        }
        if (tripManager.FavoriteList.Contains("17_March"))
        {
            AddseventeenMarchMarch();
        }
    }

    public void RemoveThirteenMarch()
    {
        tripManager.DeleteTripFromList("13_March");
        thirteenMarch.SetActive(false);
    }

    void AddThirteenMarch()
    {
        thirteenMarch.SetActive(true);
    }

    public void RemoveFifteenMarchMarch()
    {
        tripManager.DeleteTripFromList("15_March");
        fifteenMarch.SetActive(false);
    }

    void AddfifteenMarchMarch()
    {
        fifteenMarch.SetActive(true);
        if (thirteenMarch.activeSelf == false)
        {
            fifteenMarch.transform.position = thirteenMarch.transform.position;
        }
    }

    public void RemoveseventeenMarchMarch()
    {
        tripManager.DeleteTripFromList("17_March");
        seventeenMarch.SetActive(false);
    }

    void AddseventeenMarchMarch()
    {
        if (thirteenMarch.activeSelf == true && fifteenMarch.activeSelf == false)
        {
            seventeenMarch.transform.position = fifteenMarch.transform.position;
        }

        if (thirteenMarch.activeSelf == false && fifteenMarch.activeSelf == true)
        {
            seventeenMarch.transform.position = fifteen1March.transform.position;
        }

        if (thirteenMarch.activeSelf == false && fifteenMarch.activeSelf == false)
        {
            seventeenMarch.transform.position = thirteenMarch.transform.position;
        }
        seventeenMarch.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Display_Favorites : MonoBehaviour
{
    [SerializeField] private GameObject thirteenMarch;
    [SerializeField] private GameObject fifteenMarch;
    [SerializeField] private GameObject seventeenMarch;


    private Trip_Manager tripManager;
    private void Awake()
    {
        tripManager = GameObject.FindObjectOfType<Trip_Manager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    public void RemoveseventeenMarchMarch()
    {
        tripManager.DeleteTripFromList("17_March");
        seventeenMarch.SetActive(false);
    }

    void AddseventeenMarchMarch()
    {
        seventeenMarch.SetActive(true);
    }
}

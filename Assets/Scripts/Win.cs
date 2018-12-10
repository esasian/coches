using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    public UiManager UImanager;



    public void Start()
    {
        UImanager = FindObjectOfType<UiManager>();
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "car01")
        {
            UImanager.Win01Text.SetActive(true);
            UImanager.Win02Text.SetActive(false);
        }

       if (coll.gameObject.tag == "car02")
        {
            UImanager.Win01Text.SetActive(false);
            UImanager.Win02Text.SetActive(true);
        }

        UImanager.WinUi();
    }
}



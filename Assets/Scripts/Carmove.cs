using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Carmove : MonoBehaviour
{
    //scripts
    public UiManager UIManager;

    public bool carPlay = false;  // se puede jugar (true), no (false)
    public GameObject car01;
    public GameObject car02;

    public int car01Pos;
    public int car02pos;

   

    public void Start()
    {

        UIManager = FindObjectOfType<UiManager>();
        car01 = GameObject.FindGameObjectWithTag("car01");
        car02 = GameObject.FindGameObjectWithTag("car02");
        car01Pos = 100;
        car02pos = 100;
        

    }

    public void Update()
    {
        if (carPlay == true)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                car01.transform.position = car01.transform.position + new Vector3(0.1f, 0, 0);
                car01Pos = car01Pos - 1;
            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                car02.transform.position = car02.transform.position + new Vector3(0.1f, 0, 0);
                car02pos = car02pos - 1;
            }
            UIManager.Count();
        }
    }

}

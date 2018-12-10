using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour{

    //scripts
    public Carmove Carmove; 

    public GameObject StartGamePanel;
    public GameObject CompletePanel;
    public GameObject Win01Text;
    public GameObject Win02Text;

    public Text Move01Count;
    public Text Move02count;


    public void Start()
    {
        Carmove = FindObjectOfType<Carmove>();
        StartGamePanel.SetActive(true);
        CompletePanel.SetActive(false);
        Move01Count.text = Carmove.car01Pos.ToString();
        Move02count.text = Carmove.car02pos.ToString();
     }

    public void Count()
    {
        Move01Count.text = Carmove.car01Pos.ToString();
        Move02count.text = Carmove.car02pos.ToString();
    }

    public void WinUi()
    {
        print("win!");
        CompletePanel.SetActive(true);
        Carmove.carPlay = false;
    }



    //BOTONES
    public void ButtonFirstStart() //inicio juego
    {
        Carmove.carPlay = true;
        StartGamePanel.SetActive(false);
    }

    public void ButtonQuit()
    {
        Application.Quit(); // salir del juego 
        print("salir");
    }

    public void Buttonstart() //reiniciar nivel
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

	

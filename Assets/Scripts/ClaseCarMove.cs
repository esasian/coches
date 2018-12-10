using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ClaseCarMove : MonoBehaviour {


    public GameObject CarPlayer;
    public GameObject CarEnemy;
    public KeyCode keyToPlay; //abre lista de teclas en inspector
    public KeyCode keyToPlay2;
    public float Speed; 
    public int moveCount;  //pasos para ganar

    int winCounter = 0;
    int enemyCounter = 0;
    bool movingPlayer = true;
    bool movingEnemy = true;

    public Text carPlayerCount;
    public Text carEnemyCount;
   
	void Start ()
    {
		
	}

    void Update()
    {
   

         if (Input.GetKeyDown(keyToPlay) && movingPlayer == true)
        {
            CarPlayer.transform.Translate(new Vector3(Speed, 0, 0)); //movimiento, translate mueve los objetos (diferencia con transform.position?)
            winCounter ++;
            carPlayerCount.text = winCounter.ToString();
         }

         if (Input.GetKeyDown(keyToPlay2) && movingEnemy == true)
        {
            CarEnemy.transform.Translate(new Vector3(Speed, 0, 0));
            enemyCounter++;
            carEnemyCount.text = enemyCounter.ToString();
        }
       

        if (winCounter == moveCount)
        {
            movingPlayer = false;
            movingEnemy = false;
            winCounter = 0; //parar consola
            print(CarPlayer + "wins");
        }

        if (enemyCounter == moveCount)
        {
            movingPlayer = false;
            movingEnemy = false;
            enemyCounter = 0; //para consola
            print(CarEnemy + "wins");

            

        }

        //para ejecutar algo fuera?  
        // ExecuteEvents.Execute )unity docs  mensajes?
        

    }

}

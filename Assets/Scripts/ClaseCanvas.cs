using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // public interfaz
using UnityEngine.UI;



//otra clase dentro del script, no entender
public interface IEventos : IeventoSystemHandler //activar usging
{
    void ShowScore(int numero);
}



public class ClaseCanvas : MonoBehaviour {

    public Text scoreText;

    public void ShowScore(int numero)
    {
        scoreText.text = "score: " + numero;
    }
}

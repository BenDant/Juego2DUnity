using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScore : MonoBehaviour
{
     [SerializeField] public int resistance; //Cada pez tendra cierta resistencia al tirar de la caña
     [SerializeField] private float numberPoints;//cantidad de puntos que da cada pez
     [SerializeField] private Score score; //script de puntaje para sumarlo a la interfaz

     public void Catch(int pullTimes)
     {
      this.resistance -= pullTimes; //el valor es reducido para cada vez que el pescador tira de la caña
      if(resistance <= 0)  //si los puntos llegan a 0
      {
        Destroy(this.gameObject);  //destruye el objeto
        score.AddPoints(numberPoints); //suma los puntos 
        Debug.Log("se destruyo"); //CONFIRMAR QUE COLISIONE
      }
     }

}
     
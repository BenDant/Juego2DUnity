using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScore : MonoBehaviour
{
     public float resistance; //Cada pez tendra cierta resistencia al tirar de la caña

     public void Catch(float pullTimes)
     {
      resistance -= pullTimes; //el valor es reducido para cada vez que el pescador tira de la caña
      if(resistance <= 0)  //si los puntos llegan a 0
      {
        Destroy(this.gameObject); 
        Debug.Log("se destruyo"); //CONFIRMAR QUE COLISIONE
      }
     }

}
     
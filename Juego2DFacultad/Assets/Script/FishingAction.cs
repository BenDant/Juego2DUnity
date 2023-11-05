using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingAction : MonoBehaviour
{

  public float pullTimes; //el valor de esta variable es enviado a la funcion Catch
    private void OnTriggerEnter2D(Collider2D collision) //cuando entra en colision
     {
      if(collision.isTrigger == true && collision.CompareTag("FIsh") ) //si colisiona al objeto con la etiqueta FIsh
      {
        collision.GetComponent<FishScore>().Catch(pullTimes); //obtiene la funcion del script FishScore
      }
     }

  void Update()
  {
    
    /*if (Input.GetKeyDown(KeyCode.Space))
    {
      Debug.Log("tira");
      GetComponent<FishingAction>().SetpullTimes(pullTimes);
      pullTimes = 1;

    }

  }

  public void SetpullTimes(float pullTimes2)
  {
    pullTimes = pullTimes2;*/
  }
}

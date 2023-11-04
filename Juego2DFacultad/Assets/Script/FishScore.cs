using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScore : MonoBehaviour
{
  [SerializeField] private GameObject efecto; 
  private  void OnTriggerEnter2D(Collider2D other)
     {
      if(other.CompareTag("Boat"))
      {
        
       Instantiate (efecto, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("esta chocando"); //CONFIRMAR QUE COLISIONE

      } 
      
     }
}
     
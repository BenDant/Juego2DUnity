/*Este Script es el encargado de que el personaje atrape a los peces*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchingAction : MonoBehaviour
{
private GameObject catchArea = default; //el area en el que un pez puede ser atrapado
private  bool catching = false; //la accion de atrapar los peces
private float timeToCatch = 0.25f;  //sirve para regularizar el tiempo en el que se activa el area
private float timer = 0f; //tiempo limitado en el que se activa el area para pescar 

    void Start()
    {
        catchArea = transform.GetChild(0).gameObject; //asigna a catchArea como hijo del Player
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //si se aprieta la barra espaciadora
        {
           if (!catching) //solo si no se esta atrapando actualmente
           { 
                StartCatching();
                //Debug.Log("esta tirando");
           }
            else // si ya se esta atrapando, reinicia el temporizador
           {
            ResetTimer();
           }
        }

        if(catching)  //reinicia la accion de atrapar
        {
            timer += Time.deltaTime;
            if(timer >= timeToCatch)
            {
                timer = 0;
                catching = false;
                catchArea.SetActive(catching);
            }
        }
            
    }

      private void StartCatching()
    {
        catching = true;
        catchArea.SetActive(catching); //Se activa el área según la variable 'catching'
    }

    private void StopCatching()
    {
        timer = 0;
        catching = false;
        catchArea.SetActive(catching);
    }

    private void ResetTimer()
   {
    timer = 0;
   }
}


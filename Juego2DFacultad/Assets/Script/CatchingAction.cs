/*Este Script es el encargado de que el personaje atrape a los peces*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchingAction : MonoBehaviour
{
private GameObject catchArea = default; //el area en el que un pez puede ser atrapado
private  bool catching = false; //la accion de atrapar los peces
private float timeToCatch = 0.25f;  //cooldown para agarrar cada pez
private float timer = 0f; //tiempo limitado en el que se activa el area para pescar 

    void Start()
    {
        catchArea = transform.GetChild(0).gameObject; //asigna a catchArea como hijo del Player
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //si se aprieta la barra espaciadora
        {
           Catch();
           //Debug.Log("aaaaa");
        }

        if(catching)
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

    private void Catch()
    {
        catching = true;
        catchArea.SetActive(catching); //Se activa el area segun la variable catching
    }
}

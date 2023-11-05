using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 public void Play()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;  //pasa a la siguiente escena
 }   

 public void Exit()
 {
    Debug.Log("Ha salido del juego");
    Application.Quit(); 
 }
}

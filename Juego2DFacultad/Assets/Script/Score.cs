using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
   private float points; //almacena la cantidad de puntos de cada pez
   private TextMeshProUGUI textMesh; //controla el componente de texto
   [SerializeField] public int requiredPoints;
   [SerializeField] public int SceneNumber;
 void Start()
 {
    textMesh = GetComponent<TextMeshProUGUI>(); //permite que este TextMesh funcione igual al que tenemos en el objeto
 }

 void Update()
 {
    textMesh.text = points.ToString("0"); //hace quel texto se modifique en relacion a este srcipt

    if (points >= requiredPoints) 
	{
		SceneManager.LoadScene(SceneNumber);
	}
 }
 

 public void AddPoints(float pointsEnter)
 {
    points+= pointsEnter;
 }

}

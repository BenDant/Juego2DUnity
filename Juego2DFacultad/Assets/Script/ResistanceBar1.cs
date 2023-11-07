using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResistanceBar : MonoBehaviour
{
  [SerializeField] private Slider slider;

  public void UpdateResistanceBar(float currentValue, float maxValue) //determina el valor actual y el maximo de la barra
  {
    slider.value = currentValue/maxValue;   //asigna el valor de la barra
  }
    void Update()
    {
        
    }
}

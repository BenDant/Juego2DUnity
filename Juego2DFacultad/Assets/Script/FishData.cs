using UnityEngine;

[CreateAssetMenu(fileName = "New Fish Data", menuName = "Fish Data")]
public class FishData : ScriptableObject
{
   [SerializeField] private string fishName;
   [SerializeField] private int score;
   [SerializeField] private float velocity; 



   public string  FishName { get { return  fishName; }  }
   public int Score { get { return  score; }  }
   public float Velocity { get { return  velocity; }  }
 }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
  public int firstNumber = 20;
  public int secondNumber = 30;
    // Start is called before the first frame update
    void Start()
    {
      ItemInventory();
      AddNumbers();
      int characterLevel = 32;
       GenerateCharacters("Spike", characterLevel);

      int max = 300;
      int min = 200;
      SubstractNumbers(max, min);
    }

    public void ItemInventory()
    {
      Dictionary<string, int> itemInventory = new Dictionary<string, int>()
      {
        {"Banana", 5},
        {"Mango", 7},
        {"Avocado", 2}
      };
      Debug.LogFormat("Items: {0}", itemInventory.Count);
    }

    public void GenerateCharacters (string name, int level)
    {
      Debug.LogFormat("Characters: {0} - level: {1}", name, level);
    }

    public void AddNumbers ()
    {
      Debug.Log(firstNumber + secondNumber);
    }

    // Using return instead of void
    public int SubstractNumbers (int max, int min) 
    {
      int result = max - min;
      Debug.Log(result);
      return result;

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

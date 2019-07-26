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
      QuestPartyMembers();
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

    public void QuestPartyMembers()
    {
      List<string> questPartyMembers = new List<string>()
        {"John", "Aimable", "Denis"};
      for (int i = 0; i < questPartyMembers.Count; i++)
      {
        Debug.LogFormat("index: {0} - {1}", i, questPartyMembers[i] );
        if (questPartyMembers[i] == "Aimable")
        {
          Debug.Log("Glad you are here!");
        }
      }
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
    
    public void PrintStatsInfo()
    {
      Debug.LogFormat("Hero: {0} - {1} EXP", name);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

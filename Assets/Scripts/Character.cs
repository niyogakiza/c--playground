using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // hero is class instance
        Character hero = new Character();
       

    }

    public  Character(string name)
    {
        this.name = name;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

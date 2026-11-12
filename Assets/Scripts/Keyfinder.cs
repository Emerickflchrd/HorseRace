using UnityEngine;
using System.Collections;

public class Keyfinder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKey(KeyCode.UpArrow))
        {
            print("up arrow key is held down");
        }
        if (input.GetKey(KeyCode.DownArrow))
        {
            print("Down arrow key is held down");
        }
    }
}

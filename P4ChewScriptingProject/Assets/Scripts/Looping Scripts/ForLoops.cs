using UnityEngine;

public class ForLoops : MonoBehaviour
{
    int numEnemies = 3;

    // Start is called before the first frame update
    void Start()

    {
        //my for loop is going to check if there are enemies in rhw tgame if there arent any
        // will print message in console saying it created an enemy
        for (int i = 0; i < numEnemies; i++) 
        {
            Debug.Log("Creating enemy number: " + i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColourChanger : MonoBehaviour
{

    //Added Custom
    [SerializeField] private Material playerMaterial;

    [SerializeField] private Material myMaterial;



    private void OnCollisionEnter(Collision other)
    {
        if(myMaterial.name == "Blue")
        {
        playerMaterial.color = Color.blue;
        other.gameObject.tag = "Blue";
        }


        if (myMaterial.name == "Red")
        {
            playerMaterial.color = Color.red;
            other.gameObject.tag = "Red";
        }

        if (myMaterial.name == "Yellow")
        {
            playerMaterial.color = Color.yellow;
            other.gameObject.tag = "Yellow";
        }

    }

    //Cleanup
    void OnApplicationQuit()
    {
        
        playerMaterial.color = Color.white;
    }
}

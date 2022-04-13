using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColourChanger : MonoBehaviour
{

    //Added Custom
    [SerializeField] private Material playerMaterial;

    [SerializeField] private Material myMaterial;

    public Text currentColour;


    private void OnCollisionEnter(Collision other)
    {
        if(myMaterial.name == "Blue")
        {
        playerMaterial.color = Color.blue;
        other.gameObject.tag = "Blue";

            currentColour.text = "Blue";
            currentColour.color = Color.blue;
        }


        if (myMaterial.name == "Red")
        {
            playerMaterial.color = Color.red;
            other.gameObject.tag = "Red";
            currentColour.text = "Red";
            currentColour.color = Color.red;
        }

        if (myMaterial.name == "Yellow")
        {
            playerMaterial.color = Color.yellow;
            other.gameObject.tag = "Yellow";

            currentColour.text = "Yellow";
            currentColour.color = Color.yellow;
        }

    }

    //Cleanup
    void OnApplicationQuit()
    {
        
        playerMaterial.color = Color.white;
    }
}

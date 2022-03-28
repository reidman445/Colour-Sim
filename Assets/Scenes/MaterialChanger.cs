using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{

    //Added Custom
        [SerializeField] private Material myMaterial;

    //Cleanup
    void OnApplicationQuit()
    {
   
        myMaterial.color = Color.white;
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Red"))
        {
            //Player is Red + Object is Blue = Purple
            if (myMaterial.color == Color.blue)
            {
                //Changes to purple - Last int is alpha always leave 255
                myMaterial.color = new Color32(128, 0, 128, 255);
            }
            else
            {
                myMaterial.color = Color.red;
            }
        }

        if (other.gameObject.CompareTag("Blue"))
        {
            //Player is Blue + Object is Red = Purple
            if (myMaterial.color == Color.red)
            {
               //Changes to purple - Last int is alpha always leave 255
                myMaterial.color = new Color32(128, 0, 128, 255);
            }
            else
            {
                myMaterial.color = Color.blue;
            }
            
        }

    }
}

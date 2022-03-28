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

            if (myMaterial.color == Color.blue || myMaterial.color == Color.yellow)
            {


                //Player is Red + Object is Blue = Purple
                if (myMaterial.color == Color.blue)
                {
                    //Changes to purple - Last int is alpha always leave 255
                    myMaterial.color = new Color32(128, 0, 128, 255);
                }
                //Player is Red + Object is Yellow = ORANGE
                if (myMaterial.color == Color.yellow)
                {
                    //Changes to ORANGE - Last int is alpha always leave 255
                    myMaterial.color = new Color32(255, 165, 0, 255);
                }
            }
            else
            {
                myMaterial.color = Color.red;
            }
            
               
            
        }

        if (other.gameObject.CompareTag("Blue"))
        {

            if (myMaterial.color == Color.red || myMaterial.color == Color.yellow)
            {

                //Player is Blue + Object is Red = Purple
                if (myMaterial.color == Color.red)
                {
                    //Changes to purple - Last int is alpha always leave 255
                    myMaterial.color = new Color32(128, 0, 128, 255);
                }
                //Player is BLUE + Object is YELLOW = GREEN
                if (myMaterial.color == Color.yellow)
                {
                    //Changes to GREEN - Last int is alpha always leave 255
                    myMaterial.color = new Color32(0, 128, 0, 255);
                }

            }
            else
            {
                myMaterial.color = Color.blue;
            }
            
                
            
            
        }

        if (other.gameObject.CompareTag("Yellow"))
        {

            if (myMaterial.color == Color.red || myMaterial.color == Color.blue)
            {

                //Player is Yellow + Object is Red = ORANGE
                if (myMaterial.color == Color.red)
                {
                    //Changes to ORANGE - Last int is alpha always leave 255
                    myMaterial.color = new Color32(255, 165, 0, 255);
                }

                //Player is Yellow + Object is Blue = GREEN
                if (myMaterial.color == Color.blue)
                {
                    //Changes to GREEN - Last int is alpha always leave 255
                    myMaterial.color = new Color32(0, 128, 0, 255);
                }

            }
            else
            {
                myMaterial.color = Color.yellow;
            }

           
                
           

        }

    }
}

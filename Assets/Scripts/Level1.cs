using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{

    [SerializeField] private Material myMaterial;

    public Text txt;
    public Text txt2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Green")
        {
            txt.text = "MISSION COMPLETED";
            txt2.text = "Transporting to Level 2...";
            
            StartCoroutine(WaitForABit());
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
           
            
        }
    }

    IEnumerator WaitForABit()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        LevelChange();
    }

    void LevelChange()
    {
        myMaterial.color = Color.white;
        SceneManager.LoadScene("Level 2");
    }

}

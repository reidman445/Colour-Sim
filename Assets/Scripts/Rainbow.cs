using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rainbow : MonoBehaviour
{

    [SerializeField] private Material floor1;
    [SerializeField] private Material floor2;
    [SerializeField] private Material floor3;
    [SerializeField] private Material floor4;
    [SerializeField] private Material floor5;
    [SerializeField] private Material floor6;

    public Text txt;
    public Text txt2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] checkRed = GameObject.FindGameObjectsWithTag("Red");
        GameObject[] checkBlue = GameObject.FindGameObjectsWithTag("Blue");
        GameObject[] checkYellow = GameObject.FindGameObjectsWithTag("Yellow");
        GameObject[] checkGreen = GameObject.FindGameObjectsWithTag("Green");
        GameObject[] checkOrange = GameObject.FindGameObjectsWithTag("Orange");
        GameObject[] checkPurple = GameObject.FindGameObjectsWithTag("Purple");

        if (checkRed.Length <= 2 &&
            checkBlue.Length <= 1 &&
            checkYellow.Length <= 1 &&
            checkGreen.Length <= 1 &&
            checkOrange.Length <= 1 &&
            checkPurple.Length <= 1)
        {
            txt.text = "MISSION COMPLETED";
            txt2.text = "Transporting to Level 5...";

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
        floor1.color = Color.white;
        floor2.color = Color.white;
        floor3.color = Color.white;
        floor4.color = Color.white;
        floor5.color = Color.white;
        floor6.color = Color.white;

        SceneManager.LoadScene("Level 5");
    }
}

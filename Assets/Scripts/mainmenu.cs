using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void Quit()
    {
        Debug.Log("Quit");

        Application.Quit();
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class play : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public void click()
    {
       
        SceneManager.LoadScene("Main Menue");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

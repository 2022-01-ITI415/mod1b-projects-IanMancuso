using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Apple()
    {
        SceneManager.LoadScene("Main-ApplePicker");
    }

    public void Title()
    {
        SceneManager.LoadScene("SceneMain");
    }

    public void MissionDemolition()
    {
        SceneManager.LoadScene("Main-MissionDemolition");
    }
    public void Prototype()
    {
        SceneManager.LoadScene("Main-Prototype 1");
    }
}

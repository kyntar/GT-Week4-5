using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    // Update is called once per frame
    public void ToScene3()
    {
        SceneManager.LoadScene("Scene3");
    }
}

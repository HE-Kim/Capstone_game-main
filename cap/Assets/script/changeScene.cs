using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        if (this.gameObject.name == "changetostart")
        {
            SceneManager.LoadScene("tutorial");
        }
       if (this.gameObject.name == "PressCom1")
        {
            SceneManager.LoadScene("FirstfloorMain");
        }
        if (this.gameObject.name == "PressCom_main")
        {
            SceneManager.LoadScene("Firstgame_main");
        }
        if (this.gameObject.name == "Firstgame_start")
        {
            SceneManager.LoadScene("Firstgame_s");
        }
        if (this.gameObject.name == "Firstgame_HTP")
        {
            SceneManager.LoadScene("Firstgame_HowPlay");
        }
    }
    
}

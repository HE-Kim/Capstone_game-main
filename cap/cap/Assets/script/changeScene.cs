using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour
{   
    //public
    //SoundManager.instance.SFXPlay("letter",clip);

    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "changetostart":
                SceneManager.LoadScene("tutorial");
                break;
            case "card_Button":
                 SceneManager.LoadScene("Firstfloor");
                 break;
            case "PressCom1":
                SceneManager.LoadScene("FirstfloorMain");
                break;
            case "PressCom_main":
                    SceneManager.LoadScene("inputPW");
                    break;
            case "PW_out":
                SceneManager.LoadScene("FirstfloorMain");
                break;
            case "Firstgame_start":
                SceneManager.LoadScene("First_game_map");
                break;
            case "Right_turn":
                SceneManager.LoadScene("F_Right_m");
                break;
            case "Rightmap_turnL":
                SceneManager.LoadScene("FirstfloorMain");
                break;
            case "Open_first_hint":
                SceneManager.LoadScene("F_Right_mopen");
                break;
            case "Open_first_hint2":
                SceneManager.LoadScene("F_Right_mopen");
                break;
            case "Open_book_hint":
                SceneManager.LoadScene("Book_hint");
                break;
            case "Out_book_hint":
                SceneManager.LoadScene("F_Right_mopen");
                break;
            case "wall_z":
                SceneManager.LoadScene("F_Right_wz");
                break;
            case "wall_zout":
                    SceneManager.LoadScene("F_Right_mopen");
                    break;
            case "wall_hint_op":
                SceneManager.LoadScene("wall_hint");
                break;
            case "wall_zout2":
                SceneManager.LoadScene("F_Right_mopen");
                break;
            case "ID_Card":
                SceneManager.LoadScene("ID_Card");
                break;
            case "ID_out":
                SceneManager.LoadScene("F_Right_mopen");
                break;
            case "Picture_hint":
                SceneManager.LoadScene("Picture_hint");
                break;
            case "Picture_hint2":
                SceneManager.LoadScene("Picture_hint2");
                break;
            case "Picture_out":
                SceneManager.LoadScene("F_Right_mopen");
                break;
            case "intogamepButton":
                SceneManager.LoadScene("gamestore1");
                break;
            case "ZoomtogameButton":
                SceneManager.LoadScene("zoomgame");
                break;
        }
    }   
}


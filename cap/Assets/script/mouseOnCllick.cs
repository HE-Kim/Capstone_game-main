using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOnCllick : MonoBehaviour
{
    public GameObject latter;
    public GameObject card;
    // Start is called before the first frame update
    public void OnClickButton()
    {
        if(latter!=null)
        {
            latter.SetActive(true);
            card.SetActive(true);
        }
    }
}

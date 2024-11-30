using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    
    public void OnClick()
    {
        menu.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject menu;

    public void OnClick()
    {
        menu.SetActive(true);
    }
}

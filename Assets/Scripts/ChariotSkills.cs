using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChariotSkills : MonoBehaviour
{
    RaycastHit hit;
    public GameObject chariot;
    public GameObject go;
    public bool canCast = false;
    public List<GameObject> pointers;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canCast)
        {
            if (Input.GetMouseButtonDown(0))//鼠标选择游戏对象
            {
                Debug.Log("点击左键");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(ray.origin, ray.direction, Color.red);

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log("检测到物体!");
                    Debug.Log(hit.collider.gameObject.name);
                    go = hit.collider.gameObject;
                    Chariot_01(go);
                    gameObject.GetComponent<Button>().interactable = true;
                }
            }
        }


    }
    void Chariot_01(GameObject target)
    {
        chariot.GetComponent<CharacterControl>().Damage(target);
        canCast = false;
        foreach (GameObject pointer in pointers)
        {
            pointer.SetActive(false);
        }


    }
    public void OnClick()
    {
        canCast = true;
        gameObject.GetComponent<Button>().interactable = false;
        foreach (GameObject pointer in pointers)
        {
            pointer.SetActive(true);
        }
    }
}

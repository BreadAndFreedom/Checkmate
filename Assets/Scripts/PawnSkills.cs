using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawnSkills : MonoBehaviour
{
    RaycastHit hit;
    public GameObject pawn;
    public GameObject go;
    public bool canCast=false;
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
                    Pawn_01(go);
                    gameObject.GetComponent<Button>().interactable = true;
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                gameObject.GetComponent<Button>().interactable = true;
                foreach (GameObject pointer in pointers)
                {
                    pointer.SetActive(false);
                }
            }
        }


    }
    void Pawn_01(GameObject target)
    {
        pawn.GetComponent<CharacterControl>().Damage(target);
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
        foreach (GameObject pointer in pointers){
            pointer.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleParallax : MonoBehaviour
{
    public Transform farBackGround, midBackGround, nearBackGround,foreGround;
    Vector3 tempFar, tempMid, tempNear, tempFore;
    public float farSpeed, midSpeed, nearSpeed,foreSpeed;
    Vector3 mousePosition, mouseWorldPosition;
    private bool isFree = true;

    // Start is called before the first frame update
    void Start()
    {
        tempFar = farBackGround.position;
        tempMid = midBackGround.position;
        tempNear = nearBackGround.position;
        tempFore = foreGround.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 获取鼠标位置
         mousePosition = Input.mousePosition;
        // 将鼠标位置从屏幕坐标转换为世界坐标
         mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.nearClipPlane));
        if (isFree)
        {
            MoveWithPointer();
        }
         

    }
    public void MoveWithPointer()
    {
        farBackGround.position = new Vector3(tempFar.x+mouseWorldPosition.x * farSpeed, tempFar.y+mouseWorldPosition.y * farSpeed, 0f);
        midBackGround.position = new Vector3(tempMid.x+mouseWorldPosition.x * midSpeed, tempMid.y+mouseWorldPosition.y * midSpeed, 0f);
        nearBackGround.position = new Vector3(tempNear.x+mouseWorldPosition.x * nearSpeed, tempNear.y+mouseWorldPosition.y * nearSpeed, 0f);
        foreGround.position = new Vector3(tempFore.x+mouseWorldPosition.x * foreSpeed, tempFore.y+mouseWorldPosition.y * foreSpeed, 0f);
    }
    public void SetFree()
    {
        isFree = true;
    }
}

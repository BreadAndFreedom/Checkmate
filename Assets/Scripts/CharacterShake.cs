using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOShakePosition(3f,0.05f,3,50,false).SetLoops(-1);
        transform.DOShakeRotation(3f,new Vector3(0.1f,0.1f,0f), 2, 50, true).SetLoops(-1);
        // transform.DOShakeRotation(3f,new Vector3(2,2,0)).SetLoops(-1);
        transform.DOShakeScale(3f,0.05f,3,90,false).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

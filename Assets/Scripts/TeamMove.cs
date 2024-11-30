using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamMove : MonoBehaviour
{
    public float speed;
    private float horizontal;
    public bool canMove=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            horizontal = Input.GetAxis("Horizontal");
            gameObject.transform.Translate(speed * Time.deltaTime * horizontal, 0, 0);
        }

    }
}

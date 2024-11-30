using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialog;
    public GameObject team;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        team.GetComponent<TeamMove>().canMove = false;
        dialog.SetActive(true);
    }
}

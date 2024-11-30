using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class BattleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> playerTeam;
    public List<GameObject> enemyTeam;
    public List<GameObject> tempTeam;
    public List<GameObject> slot;
    public int index = 0;
    public GameObject vicPanel;
    public GameObject losePanel;
    public EnemyAI enemyAI;
  

    private void Start()
    {
        tempTeam.AddRange(playerTeam);
        //tempTeam.AddRange(enemyTeam);
        
    }
    private void Update()
    {
        if(enemyTeam.Count>0 && playerTeam.Count > 0)
        {
            if (tempTeam[index].GetComponent<CharacterControl>().canMove)//先检测可以行动的，唤出技能UI
            {
                tempTeam[index].GetComponent<CharacterControl>().StartControl();
            }
            else
            {
                tempTeam[index].GetComponent<CharacterControl>().EndControl();//技能释放完成后隐藏当前UI，进入下一人回合
                Announce();
            }
        }
        else if (enemyTeam.Count == 0)
        {
            vicPanel.SetActive(true);
        }
        else if (playerTeam.Count == 0)
        {
            losePanel.SetActive(true);
        }
    }
    public void Announce()
    {

        if (index + 1 < tempTeam.Count)
        {
            index++;
            tempTeam[index].GetComponent<CharacterControl>().canMove=true;
        }
        else
        {
            enemyAI.EnemyAttack();
            Debug.Log("回合结束");
            index = 0;
            if (playerTeam.Count > 0)
            {
                tempTeam[index].GetComponent<CharacterControl>().canMove = true;
            }
                
        }


    }

}

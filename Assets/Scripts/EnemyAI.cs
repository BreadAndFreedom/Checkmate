using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update

    public BattleManager battleManager;
    private void Start()
    {
        battleManager = GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>();

    }
    public void EnemyAttack()
    {

        if (battleManager.enemyTeam.Count > 0)
        {
            foreach (GameObject enemy in battleManager.enemyTeam)
            {
                int randomNum = Random.Range(0, battleManager.playerTeam.Count);
                enemy.GetComponent<CharacterControl>().Damage(battleManager.playerTeam[randomNum]);

            }
        }
        else
        {

        }
        //int randomNum = Random.Range(1, 3);
    }
}

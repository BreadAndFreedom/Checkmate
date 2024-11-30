using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using DG.Tweening;

public class CharacterControl : MonoBehaviour
{
    public int moveSpeed;
    public bool canMove=false;
    public string name;
    public int maxHealth = 100;
    public int currentHealth;
    public int damage = 50;
    public int slot;//阶层

    public HealthBar healthBar;
    public BattleManager battleManager;
    public GameObject skillUI;




    private void Start()
    {
        battleManager= GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    public void StartControl()
    {
        skillUI.SetActive(true);
    }
    public void EndControl()
    {
        skillUI.SetActive(false);
    }
    public void Damage(GameObject go)
    {
        Debug.Log(name + "成功进行了攻击");
        if (go.GetComponent<CharacterControl>().currentHealth > 0)
        {
            go.GetComponent<CharacterControl>().currentHealth -= damage;
            go.GetComponent<CharacterControl>().healthBar.SetHealth(go.GetComponent<CharacterControl>().currentHealth);
            Debug.Log(go.GetComponent<CharacterControl>().name + "受到了" + damage + "点伤害");
            if (go.GetComponent<CharacterControl>().currentHealth <= 0)
            {
                Debug.Log(go.GetComponent<CharacterControl>().name + "死亡");
                battleManager.tempTeam.Remove(go);
                battleManager.enemyTeam.Remove(go);
                battleManager.playerTeam.Remove(go);
                Destroy(go);
            }
            
        }
        canMove = false;
        
    }
    public void Exchange(GameObject target)
    {
        int temp = slot;
        slot = target.GetComponent<CharacterControl>().slot;
        target.GetComponent<CharacterControl>().slot = temp;
        Vector3 tempPos1 = gameObject.transform.position;
        Vector3 tempPos2 = target.transform.position;
        gameObject.transform.DOMove(tempPos2, 1);
        target.transform.DOMove(tempPos1, 1);
        Debug.Log("交换成功");
        
        //衔接真实位置交换
    }

}

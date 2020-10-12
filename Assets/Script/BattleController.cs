﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum BattleState { start, playerturn, enemyturn, won, lost }    //枚举战斗状态


public class BattleController : MonoBehaviour
{
    /*
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    
    public Transform playerBattleStation;      //获取平台位置生成单位
    public Transform enemyBattleStation;
    */
    public Unit playerunit;
    public Unit enemyunit;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;
    public TurnHUD turnCounterText;
    public int maxTurn;
    public Text Log;
    public float delay;
    public BattleState state;

    private int turnCounter = 0;
    // Start is called before the first frame update
   void Start()
    {
        state = BattleState.start;
        StartCoroutine( SetupBattle( ) );            //战斗开始//延时操作3          
    }

    IEnumerator SetupBattle()     //回合交替的延时操作1
    {
        /*
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerunit = playerGO.GetComponent<Unit>( );

        GameObject enemyGO =  Instantiate(enemyPrefab, enemyBattleStation);
        enemyunit = enemyGO.GetComponent<Unit>();
        */
        Log.text = "Battle start";
        
        playerHUD.SetHUD(playerunit);
        enemyHUD.SetHUD(enemyunit);
        turnCounterText.SetHUD(maxTurn);
        yield return new WaitForSeconds(delay);        //延时操作2 

        state = BattleState.playerturn;
        PlayerTurn();
    }

     IEnumerator PlayerAttack()
    {

        bool isDead = enemyunit.TakeDamage(playerunit.damage);              //damge the enemy

        enemyHUD.SetHP(enemyunit.currentHP);
        Log.text = "Player attack ";

        yield return new WaitForSeconds(delay);

        if (isDead)
        {
            state = BattleState.won;
            EndBattle();
        }
        else
        {
            state = BattleState.enemyturn;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        Log.text = " enemy attack ";
        yield return new WaitForSeconds(delay);

        bool isDead = playerunit.TakeDamage(enemyunit.damage);

        playerHUD.SetHP(playerunit.currentHP);

        yield return new WaitForSeconds(delay);

        if(isDead)
        {
            state = BattleState.lost;
            EndBattle();
        }
        else
        {
            state = BattleState.playerturn;
            PlayerTurn();
        }

    }


    void EndBattle()
    {
        if(state == BattleState.won)
        {
            Log.text = "Player won";
        }
        else if(state == BattleState.lost)
        {
            Log.text = "Player lost ";
        }
    }
        
     void PlayerTurn ()
    {
        Log.text = "Player turn wait for command ";
        turnCounter++;
        turnCounterText.SetTurn(turnCounter);
        if(turnCounter > maxTurn)
        {
            state = BattleState.lost;
            EndBattle();
        }
    }

     public void OnAttackButton()
    {
        if (state != BattleState.playerturn)
            return;

        StartCoroutine(PlayerAttack());
    }
}

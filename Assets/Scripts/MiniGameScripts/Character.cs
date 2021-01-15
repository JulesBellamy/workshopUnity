using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    public int strength = 0;
    public int hp = 200;
    public Enemy enemy;

    public Character(Enemy enemy)
    {
        this.strength = 0;
        this.hp = 200;
        this.enemy = enemy;
    }


    public void Attack()
    {
        enemy.hp -= 10 * strength;

        GameObject text = GameObject.Find("Text (TMP)");
        TextMeshProUGUI tm = text.GetComponent<TextMeshProUGUI>();
        tm.text = enemy.Display();
    }

    public void Defend()
    {

    }

    public void Buff()
    {
        this.strength += 1;
    }

    public void Debuff()
    {

    }
}

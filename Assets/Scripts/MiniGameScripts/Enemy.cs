using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 75;
    public string Display()
    {
        return "Bandit - "+hp;
    }
}

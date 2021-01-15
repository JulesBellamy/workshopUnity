using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharp.Interface
{
    public class Attacker : IMyInterface
    {
        public void Attack()
        {
            Debug.Log("Attack !");
        }
    }
}


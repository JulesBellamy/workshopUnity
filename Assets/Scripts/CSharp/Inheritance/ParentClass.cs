using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharp.Inheritance
{
    public class ParentClass
    {
        public string name;
        private int age;
        private int hp;

        public ParentClass(string name, int age, int hp)
        {
            this.name = name;
            this.age = age;
            this.hp = hp;
        }
        public virtual void attack(ParentClass enemy)
        {
            enemy.setHp(enemy.getHp() - 5);
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            if(age < 0)
            {
                return;
            }
            this.age = age;
        }

        public int getHp()
        {
            return hp;
        }

        public void setHp(int hp)
        {
            this.hp = Mathf.Max(0, hp);
        }
    }
}


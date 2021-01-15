using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharp.Genericity
{
    public class Group<T> where T : User
    {
        private List<T> users;

        public Group()
        {
            users = new List<T>();
        }

        public void addUser(T user)
        {
            users.Add(user);
        }

        public void removeUser(T user)
        {
            users.Remove(user);
        }

        public List<T> GetList()
        {
            return users;
        }
    }
}


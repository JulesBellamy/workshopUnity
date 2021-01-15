using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharp.MemberHiding
{
    public class ParentClass
    {
        public virtual string Name
        {
            get
            {
                return "parent";
            }
        }
    }
}


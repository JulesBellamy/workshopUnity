using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharp.MemberHiding
{
    public class ChildClass : ParentClass
    {
        public override string Name
        {
            get { return "Child"; }
        }
    }
}


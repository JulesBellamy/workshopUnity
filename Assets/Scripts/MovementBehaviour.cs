using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSharp;
using CSharp.Inheritance;
using CSharp.Genericity;
using CSharp.MemberHiding;
using CSharp.Interface;

public class MovementBehaviour : MonoBehaviour
{

    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        /*Properties p = new Properties();
        p.Hours = 30;
        Debug.Log(p.Minutes);
        p.Minutes = 30;
        Debug.Log(p.Hours);

        StaticFields.monChamp = 60;

        MethodOverloading mo = new MethodOverloading();
        mo.text("Hello !");
        Debug.Log(mo.text());

        CSharp.Inheritance.ParentClass character1 = new CSharp.Inheritance.ParentClass("Jean",42,100);
        CSharp.Inheritance.ChildClass character2 = new CSharp.Inheritance.ChildClass("Marion", 69, 80, 40);
        character1.attack(character2);
        Debug.Log(character1.getHp());
        Debug.Log(character2.getHp());
        character2.attack(character1);
        Debug.Log(character1.getHp());
        Debug.Log(character2.getHp());
        Debug.Log(character2.getMp());

        Group<User> userGroup = new Group<User>();
        Female female = new Female();
        userGroup.addUser(female);
        Male male = new Male();
        userGroup.addUser(male);
        User user = new User();
        userGroup.addUser(user);

        foreach(User u in userGroup.GetList())
        {
            Debug.Log(u.selfDescribe());
        }

        CSharp.MemberHiding.ParentClass parent = new CSharp.MemberHiding.ParentClass();
        CSharp.MemberHiding.ParentClass child = new CSharp.MemberHiding.ChildClass();

        Debug.Log(parent.Name);
        Debug.Log(child.Name);

        IMyInterface attacker = new Attacker();
        attacker.Attack();*/

        Enemy enemy = new Enemy();
        Character chara = new Character(enemy);


    }

    // Update is called once per frame
    void Update()
    {
        /*float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(inputH, 0, inputV);
        transform.Translate(velocity * speed * Time.deltaTime);*/

    }

}

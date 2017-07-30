using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public string text = "Hello, World!";
    public bool turnOn = true;
    public float posX = 5.0f;
    public int intText = 5;

    List<string> animals = new List<string>() { "Mina", "Chappie" };

    string[] names = new string[] { "Raven", "Reggie" };

    // Dictionary <key, value>

    Dictionary<string, string> weapons = new Dictionary<string, string>();

    // Use this for initialization
    void Start() {

        animals.Add("Homer");
        animals.Add("Clarence");

        animals.Remove("Chappie");


        print("List to Array length " + animals.ToArray().Length);

        //names[0] = "Raven";

        // text = Test ("Calling Test()");

        //print(names[0] + names[1]);
        //print("Total Names " + names.Length);

        //print("Total Animals " + animals.Count);
        //print("Animal 1 " + animals[0]);
        //print("Last Animal " + animals[animals.Count - 1]);

        //weapons.Add("slot1", "toy");

        //print("Weapon in slot 1 " + weapons["slot1"]);
        //print("Slot 2 equipped " + weapons.ContainsKey("slot2"));

        ConditionTest();
    }

    // Update is called once per frame
    void Update() {

    }

    string Test(string value)
    {
        return value + "Update during Text()";
    }

    void ConditionTest()
    {
        string name = "Leigh";

        if (name == "Mo")
        {
            print("My name is Mo");
        } else if (name == "Leigh")
        {
            print("The name is Leigh");
        }
        else
        {
            print("Name is not Mo or Leigh");
        }

        int health = 10;

        bool isDead = health <= 0;

        print("Player is dead " + isDead);

        if (health > 0)
        {
            print("Player is alive");
        }

        string mode = isDead == true ? "Game Over" : "Is Playing";

        print("Game Mode " + mode);


    }


}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Controller : MonoBehaviour
{
    public string full_name;
    public string public_role;
    public string private_role;
    public string current_task;

    public string head_slot;
    public string body_slot;
    public string coat_slot;
    public string back_slot;
    public string feet_slot;

    public Node currentNode;
    public List<Node> path;

   
    private float speed = 3;

    public enum States
    {
        Wander,
        GoToCommsConsole,
    }

    public States currentstate;

    private void Start()
    {
        currentstate = States.Wander;
    }

    private void Update()
    {
        switch (currentstate)
        {
            case States.Wander:
                Wander();
                break;
            case States.GoToCommsConsole:
                GoToCommsConsole();
                break;
        }

        if(currentstate != States.Wander)
        {
            currentstate = States.Wander;
            path.Clear();
        }
        else if(currentstate != States.GoToCommsConsole && current_task == "Check Comms")
        {
            currentstate = States.GoToCommsConsole;
            path.Clear();
        }
    }

    void Wander()
    {

    }

    void GoToCommsConsole()
    {

    }
}

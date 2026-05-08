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
    public List<Node> path = new List<Node>();


    // Update is called once per frame
    void Update()
    {
        CreatePath();
    }

    public void CreatePath()
    {
        if (path.Count > 0)
        {
            int x = 0;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(path[x].transform.position.x, path[x].transform.position.y, -2), 33333 * Time.deltaTime);

            if (Vector2.Distance(transform.position, path[x].transform.position) < 0.1f)
            {
                currentNode = path[x];
                path.RemoveAt(x);
            }
        }
        else
        {
            Node[] nodes = FindObjectsOfType<Node>();
            while (path == null || path.Count == 0)
            {
                path = AStarManager.instance.GeneratePath(currentNode, nodes[Random.Range(0, nodes.Length)]);
            }
        }
    }
}

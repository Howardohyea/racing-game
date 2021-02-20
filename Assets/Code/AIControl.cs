using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{

    int index = 1;
    List<GameObject> waypoints;
    public GameObject allWaypoints;
    public int Speedcontroller;


    GameObject target;
    void Start()
    {
        Transform[] allChildren = allWaypoints.GetComponentsInChildren<Transform>();
        waypoints = new List<GameObject>();
        foreach (Transform child in allChildren)
        {
            waypoints.Add(child.gameObject);
        }

        Debug.Log(waypoints.Count);
        target = waypoints[1];
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetLocation = target.transform.position;
        Vector3 direction = targetLocation - transform.position;
        //the 10 controls the speed, larger = slower
        transform.Translate(direction.normalized / Speedcontroller);
        if (direction.magnitude < 1f)
        {
            if (index != waypoints.Count - 1)
            {
                index++;
            }
            else if (index == waypoints.Count - 1)
            {
                index = 1;
            }
            Debug.Log(index);
            Debug.Log(waypoints[index].transform.position.x);
            target = waypoints[index];
            
        }

    }
}
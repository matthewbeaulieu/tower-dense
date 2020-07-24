using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Enemymovmenttrackingpath : MonoBehaviour
{
    // Use this for initialization
    void Awake()
    {

        PathFinder pathfinder = FindObjectOfType<PathFinder>();
        var path = pathfinder.GetPath();
        StartCoroutine(FollowPath(path));
    }

    
    IEnumerator FollowPath(List<Waypoint> path)
    {
        print("Starting patrol...");
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1f);
        }
        print("Ending patrol");
    }
}
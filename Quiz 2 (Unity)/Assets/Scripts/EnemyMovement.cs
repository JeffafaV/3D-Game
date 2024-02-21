using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent nav;

    public Transform[] destinationPoints;
    private int destPoint;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 180, 0);

        if (!nav.pathPending && nav.remainingDistance < 0.5f)
        {
            NextPoint();
        }
    }

    void NextPoint()
    {
        if (destinationPoints.Length == 0)
        {
            return;
        }

        nav.destination = destinationPoints[destPoint].position;
        destPoint = (destPoint + 1) % destinationPoints.Length;
    }
}

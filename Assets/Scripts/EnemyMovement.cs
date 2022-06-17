using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private int wavepointindex = 0;

    private Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();
        target = WayPoints.points[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.3f)
        {
            GetNextWayPoint();
        }
        enemy.speed = enemy.startSpeed;
    }
    void GetNextWayPoint()
    {
        if (wavepointindex >= WayPoints.points.Length)
        {
            EndPath();
            return;
        }
        wavepointindex++;
        target = WayPoints.points[wavepointindex];
    }
    void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}

using UnityEngine;
using System.Collections.Generic;

public class EnemyLogger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnemyCreator creator = FindFirstObjectByType<EnemyCreator>();

        foreach (EnemyData enemy in creator.enemies)
        {
            Debug.Log(enemy.GetInfo());
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<EnemyData> enemies = new List<EnemyData>();

    void Awake()
    {
        EnemyData enemy1 = new EnemyData("HoverBot", 100);
            enemies.Add(enemy1);
        enemies.Add(new EnemyData("Turret", 200));
    }
    void Start()
    {
        EnemyData enemy1 = new EnemyData("HoverBot", 100);
        enemies.Add(enemy1);
        enemies.Add(new EnemyData("Turret", 200));
    }
    EnemyData CreateEnemy(string name, int hp)
    {
        return new EnemyData(name, hp);
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}

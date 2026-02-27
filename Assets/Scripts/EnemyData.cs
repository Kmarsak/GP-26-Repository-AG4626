using UnityEngine;

public class EnemyData
{
    public string Name;
    public int Health;

    public EnemyData(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public string GetInfo()
    {
        return Name + " HP " + Health; 
    }
}

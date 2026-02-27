using UnityEngine;

public class Enemy
{
    public string Name;
    public int Health;
    public int Damage;

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    public override string ToString()
    {
        return $"{Name} (HP:{Health}, DMG:{Damage})";
    }
}

using UnityEngine;

public enum HeroClass
{
    DragonTurtle,
    Magma,
    Kevak
}

[CreateAssetMenu(fileName = "New Hero", menuName = "Player/Hero")]
public class Hero : ScriptableObject
{
    public HeroClass heroClass;

    public Sprite heroPortrait;

    public int health = 50;
    public int armor;
    public int attack;
}

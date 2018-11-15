using System;
using UnityEngine;

public enum Targets
{
    NONE,
    ALL_MINIONS,
    ENEMY_MINIONS,
    ENEMY_CHARACTERS,
    ENEMY_HERO,
    ALL_CHARACTERS,
    FRIENDLY_HERO,
    FRIENDLY_CHARACTERS,
    FRIENDLT_MINIONS
}

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject, IComparable<Card>
{
    public Sprite cardSprite;

    [Header("Standard Card Information")]
    public string cardName;
    public string description;
    public int manaCost;
    public Targets targets;

    [Header("Minion Attributes")]
    public int attack;
    public int hitPoints;
    public int numberOfAttacks = 1;

    //Such as "Charge", "Taunt" & Such
    //[Header("Extra Attributes")]

    [Header("Card Clarification")]
    public bool isMinion;
    [HideInInspector]
    public string cardType;

    public int CompareTo(Card other)
    {
        return this.cardName.CompareTo(other.cardName);
    }

    public override string ToString()
    {
        if (isMinion == true)
        {
            return cardType = "Minon";
        }
        else
        {
            return cardType = "Spell";
        }
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "New Hero Power", menuName = "Player/Hero")]
public class HeroPower : ScriptableObject
{
    public int damage;
    public int heal;
    public int armor;
}

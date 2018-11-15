using UnityEngine;

[CreateAssetMenu(fileName = "New Hero Power", menuName = "Player Power/Hero Power")]
public class HeroPower : ScriptableObject
{
    public int damage;
    public int heal;
    public int armor;
}

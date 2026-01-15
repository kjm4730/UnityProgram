using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Knife : Weapon
{
    public override void Attack()
    {
        Debug.Log("Knife");
    }
}

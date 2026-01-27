using UnityEngine;

public class Idle : IStateable
{
    public void Enter(Character character)
    {
        Debug.Log("Idle able");
    }

    public void Exit(Character character)
    {
        Debug.Log("Exit state");
    }

    public void Update(Character character)
    {
        Debug.Log("Update state");
    }
}

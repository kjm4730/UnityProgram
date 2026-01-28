using UnityEngine;

public class Walk : IStateable
{
    public void Enter(Character character)
    {
        character.animator.SetInteger("X", 1);
        character.animator.SetInteger("Y", 1);
    }

    public void Exit(Character character)
    {
        character.animator.SetInteger("X", 1);
        character.animator.SetInteger("Y", 1);
    }

    public void Update(Character character)
    {
        int x = (int)Input.GetAxisRaw("Horizontal");
        int y = (int)Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            character.SwitchState(new Attack());
        }

        if((x == 0) && (y == 0))
        {
            character.SwitchState(new Idle());
        }
    }
}

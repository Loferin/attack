using UnityEngine;

public class Attack1Strategy : IAttackStrategy 
{
    public void ExecuteAttack(Animator animator) 
    {
        animator.SetTrigger("Attack1");
    }
}


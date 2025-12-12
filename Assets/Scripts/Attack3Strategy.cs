using UnityEngine;

public class Attack3Strategy : IAttackStrategy 
{
    public void ExecuteAttack(Animator animator) 
    {
        animator.SetTrigger("Attack3");
    }
}


using UnityEngine;

public class Attack2Strategy : IAttackStrategy 
{
    public void ExecuteAttack(Animator animator) 
    {
        animator.SetTrigger("Attack2");
    }
}



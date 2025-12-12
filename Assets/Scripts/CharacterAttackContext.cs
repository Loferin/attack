using UnityEngine;

public class CharacterAttackContext : MonoBehaviour 
{
    private IAttackStrategy currentStrategy;
    
    public void SetStrategy(IAttackStrategy strategy) 
    {
        currentStrategy = strategy;
    }
    
    public void PerformAttack() 
    {
        if (currentStrategy != null) 
        {
            currentStrategy.ExecuteAttack(GetComponent<Animator>());
        }
    }
}


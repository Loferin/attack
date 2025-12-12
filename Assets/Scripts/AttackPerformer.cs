using UnityEngine;

public class AttackPerformer : MonoBehaviour 
{
    [SerializeField] private CharacterAttackContext attackContext;
    private IAttackStrategy[] strategies = new IAttackStrategy[3];
    public int currentAttackType = 0;
    
    void Start() 
    {
        strategies[0] = new Attack1Strategy();
        strategies[1] = new Attack2Strategy();
        strategies[2] = new Attack3Strategy();
        SetAttackType(0); 
    }
    
    public void SetAttackType(int type) 
    {
        currentAttackType = type;
        attackContext.SetStrategy(strategies[type]);
        UpdateButtonHighlight();
    }
    
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            attackContext.PerformAttack();
        }
    }
    
    void UpdateButtonHighlight() 
    {
        Debug.Log($"Selected attack: {currentAttackType + 1}");
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlighter : MonoBehaviour 
{
    public int attackType;
    public Color accentColor = Color.yellow;
    private Button button;
    public AttackPerformer performer;
    
    void Start() 
    {
        button = GetComponent<Button>();
    }
    
    public void OnAttackSelected() 
    {
        bool isActive = performer.currentAttackType == attackType;
        button.image.color = isActive ? accentColor : Color.white;
    }
}

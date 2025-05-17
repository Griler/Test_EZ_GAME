using UnityEngine;

public class PlayerManager : CharManager,IAttack
{
    private IAnimation _iAnimation;
    [SerializeField]public GameObject hitboxLeft;
    [SerializeField]public GameObject hitboxRight;
    private void Awake()
    {   
        _iAnimation = GetComponent<IAnimation>();
    }

    public void hit()
    {
        
    }

    public void attack()
    {
        string positionHand = "Left";
        int randomInt = Random.Range(1, 3);
        positionHand = randomInt == 1 ? "Right" : "Left";
        _iAnimation.PlayAnimation("Kidney Punch " + positionHand);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            attack();
        }
    }

    private void demo()
    {
        
    }
}

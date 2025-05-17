using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : CharManager,IAttack
{
    private IAttack _attackImplementation;
    public void hit()
    {
    }

    public void attack()
    {
        _attackImplementation.attack();
    }
}

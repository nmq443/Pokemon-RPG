using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]

public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string desciption;

    [SerializeField] PokemonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp; // the number of times a move can be performed
    [SerializeField] MoveCategory category;
    [SerializeField] MoveEffects effects;
    [SerializeField] MoveTarget target;

    public string Name
    {
        get { return name; }
    }

    public  string Desciption
    {
        get { return desciption; } 
    }

    public PokemonType Type { get { return type; } }

    public int Power { get { return power; } }

    public int Accuracy { get { return accuracy; } }

    public int PP { get { return pp; } }

    public MoveCategory Category
    {
        get { return category; }
    }    

    public MoveTarget Target
    {
        get { return target; }
    }

    public MoveEffects Effects
    {
        get { return effects; }
    }
}

[System.Serializable]
public class MoveEffects
{
    [SerializeField] List<StatBoost> boosts;
    [SerializeField] ConditionID status;
    [SerializeField] ConditionID volatileStatus;

    public List<StatBoost> Boosts
    {
        get { return boosts; }
    }

    public ConditionID Status
    {
        get { return status;}
    }

    public ConditionID VolatileStatus
    {
        get { return volatileStatus; }
    }
}

[System.Serializable]
public class StatBoost
{
    public Stat stat;
    public int boost;
}

public enum MoveCategory
{
    Physical, Special, Status
}

public enum MoveTarget
{
    Foe, Self
}

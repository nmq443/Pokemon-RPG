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
}

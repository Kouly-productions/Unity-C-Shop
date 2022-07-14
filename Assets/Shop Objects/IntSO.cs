using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntSO : ScriptableObject
{
    [SerializeField]
    private int _Value;

    public int Value
    {
        get { return _Value; }
        set { _Value = value; }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "terrain", menuName= "pays/zone")]
public class Country : ScriptableObject {

    [Header("info")] 
    public new string terrain;
    public new string continent;

    [Header("paramètre")] 
    public int NbUnitéFabriquable;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Levels" , menuName = "Level")]
public class Progression : ScriptableObject
{
    public int[] nextLevelXp;
}

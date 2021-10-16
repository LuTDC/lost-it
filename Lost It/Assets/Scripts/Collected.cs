using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "collected", menuName = "ScriptableObjects/Collected")]
public class Collected : ScriptableObject
{
    public int[] col = new int[] {0, 0, 0, 0, 0, 0, 0, 0};
}

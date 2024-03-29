//Martin P�rez Villabrille
//Cat & Potions
//Last Modification 05/11/2022

using System.Collections;
using UnityEngine;

public abstract class CollisionSequence : ScriptableObject
{
    //Abstract main Coroutine for the Collecting sequences, use this in case of adding new anims to collectables.
    public abstract IEnumerator OnCollisionSequence(MonoBehaviour runner);
}
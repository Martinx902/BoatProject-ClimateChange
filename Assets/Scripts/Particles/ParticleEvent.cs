using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParticleEvent : ScriptableObject
{
    public abstract void PlayParticles(Transform position);

}

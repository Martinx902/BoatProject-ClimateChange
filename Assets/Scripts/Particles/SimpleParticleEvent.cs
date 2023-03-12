using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Particle Event/Simple Particle Event")]
public class SimpleParticleEvent : ParticleEvent
{
    [SerializeField]
    private ParticleSystem particleSystem;

    public override void PlayParticles(Transform position)
    {
        //particleSystem.transform = position;

        particleSystem.Play();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sequences /Collectable")]
public class CollectableSequence : CollisionSequence
{
    [SerializeField]
    [Tooltip("SO Audio Event that will play when the player interacts with the enviroment")]
    private AudioEvent pickUpAudioEvent;

    [SerializeField]
    private ParticleEvent particleEventSystem;

    public override IEnumerator OnCollisionSequence(MonoBehaviour runner)
    {
        //Generates an audioSource right at the point where the plant is being collected, then destroy it when the audio ends
        if (pickUpAudioEvent)
        {
            var audioPlayer = new GameObject("Pick Up SoundEffect", typeof(AudioSource)).GetComponent<AudioSource>();
            audioPlayer.transform.position = runner.transform.position;
            pickUpAudioEvent.Play(audioPlayer);
            Destroy(audioPlayer.gameObject, audioPlayer.clip.length * audioPlayer.pitch);
        }

        if (particleEventSystem)
        {
            particleEventSystem.PlayParticles(runner.transform);
        }

        yield return null;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : StateMachineBehaviour
{
    public AudioClip audioClip;
    public float volume = 1.0f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PlayerController playerController = animator.GetComponent<PlayerController>();
        if (playerController != null)
        {
            if (audioClip != null)
            {
                AudioSource audioSource = playerController.GetComponent<AudioSource>();
                if (audioSource == null)
                    audioSource = playerController.gameObject.AddComponent<AudioSource>();

                audioSource.clip = audioClip;
                audioSource.volume = volume;
                audioSource.Play();
            }
        }
    }
}

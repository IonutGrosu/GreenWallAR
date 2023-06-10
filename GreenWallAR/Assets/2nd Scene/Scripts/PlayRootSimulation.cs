using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRootSimulation : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private GameObject mask;
    [SerializeField] private Animator myAnimationController;

    private void Start()
    {
        myAnimationController.SetBool("playerTrigger", true);
        mask.SetActive(true);
        Console.WriteLine("Starting root");
        particleSystem.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Console.WriteLine("Starting flower animation");
            // myAnimationController.SetBool("playerTrigger", true);
            // mask.SetActive(true);
            // particleSystem.Play();
        }
        else
        {
            Console.WriteLine(other.tag);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("playerTrigger", false);
            mask.SetActive(false);
            particleSystem.Stop();
        }
    }
}

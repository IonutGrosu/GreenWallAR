using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayCloudAnimation : MonoBehaviour {
    [SerializeField] private Animator[] myAnimationController;
    [SerializeField] private ParticleSystem particleSystem;

    private void Start()
    {
        foreach (var controller in myAnimationController)
        {
            controller.SetBool("playerTrigger", true);   
        }

        Console.WriteLine("Starting rain");
        particleSystem.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Console.WriteLine("Starting rain animation");

            foreach (var controller in myAnimationController)
            {
                controller.SetBool("playerTrigger", true);   
            }
            particleSystem.Play();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var controller in myAnimationController)
            {
                controller.SetBool("playerTrigger", false);   
            }
            particleSystem.Stop();
        }
    }
}

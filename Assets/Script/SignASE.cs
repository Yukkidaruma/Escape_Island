using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignASE : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   
    public void SE()
    {
        audioSource.PlayOneShot(se);
    }
}

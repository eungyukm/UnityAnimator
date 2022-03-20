using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2DFreeformD : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}

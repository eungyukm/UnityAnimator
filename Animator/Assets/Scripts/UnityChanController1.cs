using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController1 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}

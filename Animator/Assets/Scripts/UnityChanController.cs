using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
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
        // Vertical의 범위 0 ~ 1
        float vertical = Input.GetAxis("Vertical");

        // Sprint 범위 0 ~ 1
        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;

        // Mathf.Abs() 절대값 
        float moveParameter = Mathf.Abs(vertical * offset);

        // 0 대기, 0.5 walk, 1 뛰는거
        animator.SetFloat("moveSpeed", moveParameter);
    }
}

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
        float vertical = Input.GetAxis("Vertical");

        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;

        float moveParameter = Mathf.Abs(vertical * offset);

        animator.SetFloat("moveSpeed", moveParameter);
    }
}

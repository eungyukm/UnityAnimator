using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Demo : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        Debug.Log("layer Count : " + animator.layerCount);
        Debug.Log("layer GetLayerIndex " + animator.GetLayerIndex("Upper Layer"));

        animator.SetLayerWeight(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

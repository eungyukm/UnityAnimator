using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerDirect : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //private IEnumerator KeyEvent(int type, KeyCode key, string parameter)
    //{
    //    float percent = animator.GetFloat(parameter);

    //    while(percent < 1)
    //    {
    //        percent += Time.deltaTime;
    //        animator.SetFloat(parameter, percent);

    //        yield return null;
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A))
        {
            //int param = animator.GetParameter(3);
            animator.SetFloat("angry", 1);
        }
    }
}

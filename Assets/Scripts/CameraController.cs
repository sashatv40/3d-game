using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public KeyCode cameraCode = KeyCode.U;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(cameraCode))
        {
            if (animator.GetBool("PUT") == false)
            {
                animator.SetBool("PUT", true);
            }
            else
            {
                animator.SetBool("PUT", false);
            }
        }
    }
}

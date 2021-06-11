using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_right_script : MonoBehaviour
{
    private bool isonscreen = true;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isonscreen = !isonscreen;
            anim.SetBool("turnon", isonscreen);
        }
    }
}

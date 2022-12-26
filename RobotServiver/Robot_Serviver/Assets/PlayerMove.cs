using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float speed = 20f;
    private Gamepad gamePad;
    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        gamePad = Gamepad.current;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gamePad.leftStick.ReadValue().y !=null)
        {
            rigidbody.velocity += transform.forward * speed * gamePad.leftStick.ReadValue().y * Time.deltaTime;
        }
        animator.SetFloat("Blend", Mathf.Abs(gamePad.leftStick.ReadValue().y));
    }
}

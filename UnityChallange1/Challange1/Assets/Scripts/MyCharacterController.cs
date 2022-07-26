using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyCharacterController : MonoBehaviour
{
    #region Variables
    [Header("External Objects")]
    public Camera playerCamera;
    public Rigidbody rb;

    private bool isGrounded = true;
    private bool isJump = false;
    private bool isOnLava = false;
    private float horizontalAxis;
    private float verticalAxis;
    private Vector3 currentRotation;
    private float xMouseAxis;
    private float yMouseAxis;

    [Header("User Parameters")]
    public float movementSpeed = 5;
    public float jumpForce = 30;
    public float mouseSensivity = 1;
    public float maxYAngle = 80;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetUserInput();
        if(isOnLava)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void GetUserInput()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            if(isGrounded)
            {
                isJump = true;
            }
        }
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
        xMouseAxis = Input.GetAxis("Mouse X");
        yMouseAxis = Input.GetAxis("Mouse Y");

    }

    private void FixedUpdate()
    {
        MoveCamera();
        MoveCharacter();
        Jump();
    }

    private void Jump()
    {
        if(isGrounded)
        {
            if(isJump)
            {
                rb.AddForce(Vector3.up * jumpForce);
                isGrounded = false;
            }
        }
    }

    private void MoveCharacter()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.TransformPoint(new Vector3(horizontalAxis, 0, verticalAxis)), Time.fixedDeltaTime*4);

    }

    private void MoveCamera()
    {
        currentRotation.x += xMouseAxis * mouseSensivity;
        currentRotation.y -= yMouseAxis * mouseSensivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);

        playerCamera.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
        transform.rotation = Quaternion.Euler(0, currentRotation.x, 0);

        Vector3 p = playerCamera.transform.rotation * new Vector3(0, 2, -8);
        playerCamera.transform.position = transform.position + p;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = Physics.CheckBox(transform.position, transform.localScale, transform.rotation, LayerMask.GetMask("Ground"));
        isOnLava = Physics.CheckBox(transform.position, transform.localScale, transform.rotation, LayerMask.GetMask("Lava"));
        isJump = false; 
    }
}

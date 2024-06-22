using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;
    public Rigidbody rigidBody;
    public float jumpForce;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if (Input.GetButton("Jump"))
        {
            rigidBody.AddForce(new Vector3 (0, jumpForce, 0));
        }
    }
}

        //if (Input.GetKey(KeyCode.W))

//        {
//            transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));
//        }
//        if (Input.GetKey(KeyCode.S))

//        {
//            transform.Translate(Vector3.back * (Time.deltaTime * moveSpeed));
//        }
//        if (Input.GetKey(KeyCode.A))

//        {
//            transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
//        }
//        if (Input.GetKey(KeyCode.D))

//        {
//            transform.Translate(Vector3.right * (Time.deltaTime * moveSpeed));
//        }
//        if (Input.GetKey(KeyCode.Space))

//        {
//            transform.Rotate(Vector3.up * (Time.deltaTime * rotSpeed));
//        }
//    }
//}

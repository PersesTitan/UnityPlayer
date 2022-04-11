using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    protected Rigidbody rb;
    public float moveSpeed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.forward * moveSpeed);
        if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.back * moveSpeed);
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * moveSpeed);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * moveSpeed);
        
        // if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.forward * moveSpeed, Space.World);
        // if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.back * moveSpeed, Space.World);
        // if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * moveSpeed, Space.World);
        // if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * moveSpeed, Space.World);
        

        if (Input.GetKey(KeyCode.O)) transform.Translate(Vector3.up * moveSpeed);
        if (Input.GetKey(KeyCode.P)) transform.Translate(Vector3.down * moveSpeed);

        //오른쪽 회전
        if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.up * rotateSpeed);
        //왼쪽 회전
        if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.down * rotateSpeed);
        //아래로 회전
        if (Input.GetKey(KeyCode.S)) transform.Rotate(Vector3.right * rotateSpeed);
        //위로 회전
        if (Input.GetKey(KeyCode.W)) transform.Rotate(Vector3.left * rotateSpeed);

    }
}

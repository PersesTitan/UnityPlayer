using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;
using System;

public class PlayerController : MonoBehaviour {

    protected Rigidbody rb;
    public float moveSpeed;
    public float rotateSpeed;
    public string port; //포트 넣기
    private SerialPort sp = new SerialPort();

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        sp.PortName = "COM" + port;
        sp.BaudRate = 19200;
        sp.DataBits = 8;
        sp.Parity = Parity.None;
        sp.StopBites - StopBites.ONe;
        sp.Open();
    }

    // Update is called once per frame
    void Update() {

        string[] lines = Input.inputString.Split(' ');
        int x = Int32.Parse(lines[0]);
        int y = Int32.Parse(lines[1]);
        int z = Int32.Parse(lines[2]);

        transform.Rotate(Vector3.up * moveSpeed * x);
        transform.Rotate(Vector3.right * moveSpeed * y);

    }
}

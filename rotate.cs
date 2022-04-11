using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    
    // 센서로부터 x, y, z 값 받아서 넣기
    public float x_value;
    public float y_value;
    public float z_value;

    void Start() {
        
    }

    void Update() {
        // 임시 테스트 용으로 R 버튼을 눌렀을때 입력 받은 값인 x,y,z 값을 받아옴
        if (Input.GetKey(KeyCode.R)) {
            transform.rotation = Quaternion.Euler(x_value,y_value,z_value);
        }
    }
}
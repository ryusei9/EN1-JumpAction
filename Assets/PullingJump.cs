using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Physics.gravity = new Vector3(0, -50.0f, 0);
public class PullingJump : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10.0f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0)) 
        {
            // �N���b�N�������W�Ɨ��������W�̍������擾
            Vector3 dist = clickPosition - Input.mousePosition;
            // �N���b�N�������W�ƃ����[�X���������W�Ȃ�Ζ���
            if (dist.sqrMagnitude == 0) { return; }
            // ������W�������AjumpPower���������킹���l����l�Ƃ���
            rb.velocity = dist.normalized * jumpPower;

        }
    }
}

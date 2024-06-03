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
            // クリックした座標と離した座標の差分を取得
            Vector3 dist = clickPosition - Input.mousePosition;
            // クリックした座標とリリースが同じ座標ならば無視
            if (dist.sqrMagnitude == 0) { return; }
            // 差分を標準化し、jumpPowerをかけ合わせた値を基準値とする
            rb.velocity = dist.normalized * jumpPower;

        }
    }
}

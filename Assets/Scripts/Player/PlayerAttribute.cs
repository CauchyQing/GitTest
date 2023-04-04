using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    [Header("基本参数")]
    public float speed; //速度
    public float jumpForce; //跳跃力


    public float checkRaduis;
    public Vector2 bottomOffset;
    public LayerMask groundLayer;

    [Header("检测参数")]
    public bool isGround;    //是否在地面
    public bool isAttack;   //是否被攻击




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

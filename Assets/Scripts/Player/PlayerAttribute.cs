using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    [Header("��������")]
    public float speed; //�ٶ�
    public float jumpForce; //��Ծ��


    public float checkRaduis;
    public Vector2 bottomOffset;
    public LayerMask groundLayer;

    [Header("������")]
    public bool isGround;    //�Ƿ��ڵ���
    public bool isAttack;   //�Ƿ񱻹���




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

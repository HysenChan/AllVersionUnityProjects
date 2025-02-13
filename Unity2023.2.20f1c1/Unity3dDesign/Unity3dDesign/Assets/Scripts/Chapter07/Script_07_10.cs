using UnityEngine;

public class Script_07_10 : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private float m_Speed = 2.0f;

    private float m_JumpHeight = 3.0f;
    private float m_Gravity = -9.81f;
    private float m_Velocity;

    private void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //跳跃逻辑
        bool isGround = m_CharacterController.isGrounded;
        if (isGround)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //接触地面后才能跳起来
                m_Velocity = 0f;
                m_Velocity += Mathf.Sqrt(-(m_JumpHeight * m_Gravity));
            }
        }

        //移动逻辑
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //控制角色的朝向
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }

        m_Velocity += m_Gravity * Time.deltaTime;
        //将移动的坐标和Y轴的坐标统一交给角色控制器移动
        move.y = m_Velocity;
        m_CharacterController.Move(move * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((hit.controller.collisionFlags & CollisionFlags.Sides) != 0)
        {
            Debug.Log($"两侧碰撞:{hit.gameObject.name}");
        }

        if ((hit.controller.collisionFlags & CollisionFlags.Below) != 0)
        {
            Debug.Log($"脚底部碰撞:{hit.gameObject.name}");
        }

        if ((hit.controller.collisionFlags & CollisionFlags.Above) != 0)
        {
            Debug.Log($"头顶部碰撞:{hit.gameObject.name}");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"进入触发器:{other.name}");
    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }
}

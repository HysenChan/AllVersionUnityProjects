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
        //��Ծ�߼�
        bool isGround = m_CharacterController.isGrounded;
        if (isGround)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //�Ӵ���������������
                m_Velocity = 0f;
                m_Velocity += Mathf.Sqrt(-(m_JumpHeight * m_Gravity));
            }
        }

        //�ƶ��߼�
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //���ƽ�ɫ�ĳ���
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }

        m_Velocity += m_Gravity * Time.deltaTime;
        //���ƶ��������Y�������ͳһ������ɫ�������ƶ�
        move.y = m_Velocity;
        m_CharacterController.Move(move * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((hit.controller.collisionFlags & CollisionFlags.Sides) != 0)
        {
            Debug.Log($"������ײ:{hit.gameObject.name}");
        }

        if ((hit.controller.collisionFlags & CollisionFlags.Below) != 0)
        {
            Debug.Log($"�ŵײ���ײ:{hit.gameObject.name}");
        }

        if ((hit.controller.collisionFlags & CollisionFlags.Above) != 0)
        {
            Debug.Log($"ͷ������ײ:{hit.gameObject.name}");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"���봥����:{other.name}");
    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }
}

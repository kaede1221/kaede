using System.Diagnostics.CodeAnalysis;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterData_SO characterData;
    public static PlayerMovement instance;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public bool isMoving = false; // �����жϽ�ɫ�Ƿ������ƶ�
    public AudioClip footstepSound; // �Ų�����Ч
    [SerializeField]
    SoundManager soundManager;
    public string scenePassword;//����������
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        
        }
        else
        {
            if (instance != this)
            {   Destroy(gameObject);
           
            }
        }
        DontDestroyOnLoad(gameObject);
     
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        
        MoveandJump();
    }

    private void MoveandJump()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2();
        movement.x = horizontalInput * moveSpeed;

        if (Input.GetKey(KeyCode.W))
        {
            movement.y = jumpForce;
          
        }
        if (Mathf.Abs(horizontalInput) > 0.1f && movement.y < 0.1f && movement.y > -0.1f)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        rb.velocity = movement;
    }



    public bool GETifplayerMoving()
    {
        return isMoving;
    }
}

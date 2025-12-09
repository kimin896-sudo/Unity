using UnityEngine;


enum PlayerDirection
{
    Left,
    Right,
    Up,
    Down
}
enum State
{
    Idle,
    Move,
    Skill
}

public class PlayerSciprtSprite : MonoBehaviour
{
    PlayerDirection playerDirection;
    State state;
    Animator animator;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator.Play("Player_Idle");
    }

    void Update()
    {
        UpDateInput();
       
        UpDateAnimation();
    }
    bool isAttack = false;
    public float speed = 10f;
    void UpDateInput()
    {
        Vector3 moveDirestion = Vector3.zero;

        float moveSpeed = speed * Time.deltaTime;
        if(!isAttack)
        if (Input.GetKey(KeyCode.A))
        {
            state = State.Move;
            moveDirestion += Vector3.left;
            playerDirection = PlayerDirection.Left;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            state = State.Move;
            moveDirestion += Vector3.up;
            playerDirection = PlayerDirection.Up;
        }
        else  if (Input.GetKey(KeyCode.D))
        {
            state = State.Move;
            moveDirestion += Vector3.right;
            playerDirection = PlayerDirection.Right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            state = State.Move;

            moveDirestion += Vector3.down;
            playerDirection = PlayerDirection.Down;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            state = State.Skill;
                isAttack = true;
        }
        else
        {
            if (state == State.Skill)
                return;

                state = State.Idle;

        }
        gameObject.transform.position += moveDirestion.normalized * moveSpeed;
    }

 
    void PlayerIdle()
    {
        state = State.Idle;
        isAttack = false;
    }

  
    void UpDateAnimation()
    {
        if(state == State.Move )
        {
            switch(playerDirection)
            {
                case PlayerDirection.Left:
                    spriteRenderer.flipX = true;
                    animator.Play("Player_Side_Walk");
                    break;
                case PlayerDirection.Up:
                    animator.Play("Player_Up_Walk");
                    break;
                case PlayerDirection.Right:
                    spriteRenderer.flipX = false;
                    animator.Play("Player_Side_Walk");
                    break;
                case PlayerDirection.Down:
                      animator.Play("Player_Walk");
                    break;
                default:
                    break;
            }
        }
        else if(state == State.Skill)
        {
            animator.Play("Player_SIde_Attack");
        }
        else if(state == State.Idle)
        {
            animator.Play("Player_Idle");
        }
    }
}

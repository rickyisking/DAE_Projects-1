using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        if (move != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Attack
        {
            animator.SetTrigger("Attack");
        }
    }
}

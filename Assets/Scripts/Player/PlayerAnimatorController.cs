using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator mAnimator;
    private SpriteRenderer mSpriteRenderer;
    private PlayerInputController mPlayerInputController;
   

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
        mSpriteRenderer = GameManager.gameManager.player.GetComponent<SpriteRenderer>();
        mPlayerInputController = GameManager.gameManager.player.GetComponent<PlayerInputController>();

        Debug.Assert(mAnimator != null);
        Debug.Assert(mSpriteRenderer != null);
        Debug.Assert(mPlayerInputController != null);
    }

    private void Update()
    {
        if(mPlayerInputController.Direction.x != 0 || mPlayerInputController.Direction.y != 0)
        {
            mAnimator.SetBool("Input", true);
            mSpriteRenderer.flipX = mPlayerInputController.Direction.x < 0;
        }
        else
        {
            mAnimator.SetBool("Input", false);
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleOscar : StateMachineBehaviour
{
    public LifeNStatusOscar LifeMan;
    public EnemyControlOscar Me;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        LifeMan = animator.GetComponent<LifeNStatusOscar>();
        Me = animator.GetComponent<EnemyControlOscar>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Me.TarDist <= Me.RangedDist)
        {
            if ((Me.Target.transform.position.x < animator.transform.position.x && animator.transform.localScale.x > 0) || (Me.Target.transform.position.x > animator.transform.position.x && animator.transform.localScale.x < 0))
            {
                animator.transform.localScale = new Vector3(animator.transform.localScale.x * -1, animator.transform.localScale.y, animator.transform.localScale.z);
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}

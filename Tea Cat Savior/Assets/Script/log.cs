using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Mathf;

public class log : Enemy
{
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    private Animator anim;
    private Rigidbody2D myRigidBody;



    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        myRigidBody = gameObject.GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    void CheckDistanceToTarget()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius
        && Vector3.Distance(target.position, transform.position) > attackRadius){
            anim.SetBool("wakeUp", true);
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            changeAnim(temp - transform.position);
            myRigidBody.MovePosition(temp);
        }else{
            anim.SetBool("wakeUp", false);
        }
    }

    private void SetAnimFloat(Vector2 setVector){
        anim.SetFloat("moveX", setVector.x);
        anim.SetFloat("moveY", setVector.y);
    }

    private void changeAnim(Vector2 direction){
        // Debug.Log(direction);
        if(Mathf.Abs(direction.x) > Mathf.Abs(direction.y)){
            // Debug.Log("x is greater");
            if(direction.x > 0){
                SetAnimFloat(Vector2.right);

            }else if(direction.x < 0){
                SetAnimFloat(Vector2.left);
            }
        }else if(Mathf.Abs(direction.x) < Mathf.Abs(direction.y)){
            // Debug.Log("y is greater");
            if(direction.y > 0){
                SetAnimFloat(Vector2.up);
            }else if(direction.y < 0){
                SetAnimFloat(Vector2.down);
            }

        }


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckDistanceToTarget();
    }
}

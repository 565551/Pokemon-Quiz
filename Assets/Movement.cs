using HeneGames.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float Hoz;
    private float Vert;
    private float OldHoz;
    private float OldVert;
	public GameObject NpcInteractingWith;
	public DialogueManager DialogSystem;
	public bool FreezePlayer;

    public float Speed;
    private Rigidbody2D RB;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        RB = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponentInChildren<Animator>();
    }

	private void Update()
	{
		animator.SetFloat("Hoz", Hoz);
		animator.SetFloat("Vert", Vert);
		if (Hoz != 0)
		{
			animator.SetFloat("OldHoz", Hoz);
			animator.SetFloat("Vert", 0);
			animator.SetFloat("OldVert", 0);
		}
		if (Vert != 0)
		{
			animator.SetFloat("OldVert", Vert);
			animator.SetFloat("Hoz", 0);
			animator.SetFloat("OldHoz", 0);
		}
	}

	// Update is called once per frame
	void FixedUpdate()
    {
        Hoz = Input.GetAxisRaw("Horizontal");

		Vert = Input.GetAxisRaw("Vertical");

		RB. linearVelocity = new Vector2(Hoz,Vert).normalized *Speed;


    }
}

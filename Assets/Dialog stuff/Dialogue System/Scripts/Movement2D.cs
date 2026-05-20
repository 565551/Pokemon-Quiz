using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeneGames.DialogueSystem
{
    public class Movement2D : MonoBehaviour
    {
        float horizontal;
        Rigidbody2D rb2D;
        public GameObject NpcInteractingWith;
        public DialogueManager DialogSystem;

        private void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
        }

        private void FixedUpdate()
        {
            if(DialogSystem != null)
            {
                if (DialogSystem.FreezePlayer != true)
                {
                    rb2D.linearVelocity = new Vector2(horizontal * 10f, rb2D.linearVelocity.y);
                    
                }
                else
                {
                    rb2D.linearVelocity = Vector2.zero;
                }
                

            }
            else
            {
                rb2D.linearVelocity = new Vector2(horizontal * 10f, rb2D.linearVelocity.y);
            }
    

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVS
{
    public class ContactPooler
    {
        private Collider2D _collider;
        private ContactPoint2D[] _contact = new ContactPoint2D[5];
        private int _contactCount = 0;
        private float _treshold = 0.2f;

        public bool IsGrounded { get; private set; }
        public bool LeftContact { get; private set; }
        public bool RightContact { get; private set; }

        public ContactPooler(Collider2D collider)
        {
            _collider= collider;
        }

        public void Update()
        {
            IsGrounded = false;
            LeftContact= false;
            RightContact= false;

            _contactCount = _collider.GetContacts(_contact);

            for (int i=0; i< _contactCount; i++) 
            {
                if (_contact[i].normal.y > _treshold) IsGrounded= true;
                if (_contact[i].normal.x > _treshold) LeftContact= true;
                if (_contact[i].normal.x < -_treshold) RightContact = true;
            }
        }
    }
}
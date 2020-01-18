﻿using UnityEngine;
namespace Animators {
    public class CharacterAnimator : MonoBehaviour, ICharacterAnimator {
        private Animator animator;
        private static readonly int InputMagnitude = Animator.StringToHash("inputMagnitude");
        private static readonly int VerInput = Animator.StringToHash("verInput");
        private static readonly int HorInput = Animator.StringToHash("horInput");
        private static readonly int GroundVelocity = Animator.StringToHash("groundVelocity");

        private void Start() {
            animator = GetComponent<Animator>();
        }

        public void setHorInput(float horInput) {
            animator.SetFloat(HorInput, horInput);
        }

        public void setVerInput(float verInput) {
            animator.SetFloat(VerInput, verInput);
        }

        public void setInputMagnitude(float inputMagnitude) {
            animator.SetFloat(InputMagnitude, inputMagnitude);
        }
        
        public void setGroundVelocity(float groundVelocity) {
            animator.SetFloat(GroundVelocity, groundVelocity);
        }
    }
}
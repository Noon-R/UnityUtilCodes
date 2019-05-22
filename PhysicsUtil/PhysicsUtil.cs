using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PhysicsUtil{
     public class ForceCulculater{
        
        private float mMass = 0;
        private float mDrag = 0;
        public ForceCulculater(float mass, float drag){
            mMass = mass;
            mDrag = drag;

        }
        public Vector3 GetNeededForceToTerminalVelocity(Vector3 targetVelocity){
            return new Vector3(
                GetNeededForceToTerminalSpeed(targetVelocity.x),
                GetNeededForceToTerminalSpeed(targetVelocity.y),
                GetNeededForceToTerminalSpeed(targetVelocity.z)
            );
        }

        public float GetNeededForceToTerminalSpeed(float targetSpeed){
            return (targetSpeed * mMass * mDrag )/( 1 - mDrag * Time.fixedDeltaTime);
        }
    }
}
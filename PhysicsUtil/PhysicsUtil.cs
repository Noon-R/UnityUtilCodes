using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PhysicsUtil{
    public static class Force{
        
        public static Vector3 GetNeededForceToTerminalVelocity( Vector3 targetVelocity,float mass, float drug ){


        }

        public static float GetNeededForceToTerminalSpeed(float targetSpeed, float mass , float drug){
            return targetSpeed * mass * drug / 1 - drug *  Time
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public interface IBattleInputEventProvider {

    IReadOnlyReactiveProperty<Vector2> MoveDirection { get; }
    IReadOnlyReactiveProperty<bool> IsJump { get; }
    
	
}

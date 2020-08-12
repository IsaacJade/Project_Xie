using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{

[SerializeField]private int hp;//血量
[SerializeField]private int san;
[SerializeField]private int karma;//善恶值

private void Start() {
    hp = 100;
    san = 0;
    karma = 0;
}
private void Update() {
    
}
}

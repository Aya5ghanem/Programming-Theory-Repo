using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting Fire Spell 🔥");
    }

    private void Update()
    {
        Move();
    }
}

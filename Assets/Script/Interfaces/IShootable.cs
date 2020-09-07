﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    void OnGetShot(GameObject from, float damage);
    void OnGetBombed(float damage);

}

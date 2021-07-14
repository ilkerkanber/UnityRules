using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionClass 
{
    public static void ResetTransform(this Transform Objecttransform)
    {
        Objecttransform.position = Vector3.zero;
        Objecttransform.localRotation = Quaternion.identity;
        Objecttransform.localScale = new Vector3(1, 1, 1);
    }
}

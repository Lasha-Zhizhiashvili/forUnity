using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Spline : Editor {
    [DrawGizmo(GizmoType.InSelectionHierarchy)]
    static void drawGizmo2(Transform transform, GizmoType gizmoType)
    {
        if (transform.root.name != "LevelSpline") return;

        Gizmos.color = Color.green;

        for (var i = 0; i < transform.root.childCount - 1; i++)
        {
            ;
            Gizmos.DrawLine(transform.root.GetChild(i).position, transform.root.GetChild(i + 1).position);
        }

        Vector3 position = transform.position;
        Gizmos.DrawSphere(position, 0.15f);
    }
}

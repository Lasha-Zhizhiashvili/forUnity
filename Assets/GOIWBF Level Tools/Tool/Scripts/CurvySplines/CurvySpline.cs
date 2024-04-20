using UnityEngine;
using System.Collections.Generic;

namespace FluffyUnderware.Curvy
{
	public class CurvySpline : CurvySplineBase
	{
        [SerializeField]
        private CurvyInterpolation m_Interpolation;
        [SerializeField]
		private bool m_RestrictTo2D;
		[SerializeField]
		private bool m_Closed;
		[SerializeField]
		private bool m_AutoEndTangents;
        [SerializeField]
        private CurvyOrientation m_Orientation;
        [SerializeField]
		private float m_AutoHandleDistance;
		[SerializeField]
		private float m_Tension;
		[SerializeField]
		private float m_Continuity;
		[SerializeField]
		private float m_Bias;
		[SerializeField]
		private Color m_GizmoColor;
		[SerializeField]
		private Color m_GizmoSelectionColor;
		[SerializeField]
		private int m_CacheDensity;
		[SerializeField]
		private float m_MaxPointsPerUnit;
		[SerializeField]
		private bool m_UsePooling;
		[SerializeField]
		private bool m_UseThreading;
		[SerializeField]
		private bool m_CheckTransform;
        [SerializeField]
        private CurvyUpdateMethod m_UpdateIn;
        [SerializeField]
		public List<CurvySplineSegment> ControlPoints;
	}
}

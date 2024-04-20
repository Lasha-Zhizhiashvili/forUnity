using UnityEngine;

namespace FluffyUnderware.Curvy
{
	public class CurvySplineSegment : MonoBehaviour
	{
        [SerializeField]
        private bool m_AutoBakeOrientation;
        [SerializeField]
        private bool m_OrientationAnchor;
        [SerializeField]
        private CurvyOrientationSwirl m_Swirl;
        [SerializeField]
        private float m_SwirlTurns;
        [SerializeField]
        private bool m_AutoHandles;
        [SerializeField]
        private float m_AutoHandleDistance;
        [SerializeField]
        private Vector3 m_HandleIn;
        [SerializeField]
        private Vector3 m_HandleOut;
        [SerializeField]
        private bool m_OverrideGlobalTension;
        [SerializeField]
        private bool m_OverrideGlobalContinuity;
        [SerializeField]
        private bool m_OverrideGlobalBias;
        [SerializeField]
        private bool m_SynchronizeTCB;
        [SerializeField]
        private float m_StartTension;
        [SerializeField]
        private float m_EndTension;
        [SerializeField]
        private float m_StartContinuity;
        [SerializeField]
        private float m_EndContinuity;
        [SerializeField]
        private float m_StartBias;
        [SerializeField]
        private float m_EndBias;
        [SerializeField]
        private CurvySplineSegment m_FollowUp;
        [SerializeField]
        private ConnectionHeadingEnum m_FollowUpHeading;
        [SerializeField]
        private bool m_ConnectionSyncPosition;
        [SerializeField]
        private bool m_ConnectionSyncRotation;
    }
}

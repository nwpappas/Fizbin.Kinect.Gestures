using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fizbin.Kinect.Gestures
{
    /// <summary>
    /// the gesture part result
    /// </summary>
    public enum GesturePartResult
    {
        /// <summary>
        /// Gesture part fail
        /// </summary>
        Fail,

        /// <summary>
        /// Gesture part suceed
        /// </summary>
        Succeed,

        /// <summary>
        /// Gesture part result undetermined
        /// </summary>
        Pausing
    }

    /// <summary>
    /// The gesture type
    /// </summary>
    public enum GestureType
    {
        None,
        JoinedHands,
        WaveRight,
        WaveLeft,
        Menu,
        SwipeLeft,
        SwipeRight,
        SwipeUp,
        SwipeDown,
        ZoomIn,
        ZoomOut
    }
}

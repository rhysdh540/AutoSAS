using UnityEngine;

namespace AutoRCS
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class AutoRCS : MonoBehaviour
    {
        public void Start()
        {
            if (FlightGlobals.ActiveVessel.situation == Vessel.Situations.PRELAUNCH)
            {
                FlightGlobals.ActiveVessel.ActionGroups.SetGroup(KSPActionGroup.RCS, true);
            }
        }
    }
}

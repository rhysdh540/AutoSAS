using UnityEngine;

namespace AutoSAS
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class AutoSAS : MonoBehaviour
    {
        public void Start()
        {
            if (FlightGlobals.ActiveVessel.situation == Vessel.Situations.PRELAUNCH)
            {
                FlightGlobals.ActiveVessel.ActionGroups.SetGroup(KSPActionGroup.SAS, true);
            }
        }
    }
}

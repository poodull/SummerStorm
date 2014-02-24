using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerStorm
{
    class ConfigConstants
    {
        /// <summary>
        /// Get the baudrate we need to talk to the device with.
        /// </summary>
        public const string BAUDRATE = "BAUDRATE";
        /// <summary>
        /// Make sure we're dealing with a delta or not.
        /// </summary>
        public const string DELTA = "DELTA";

        /// <summary>
        /// Not sure we need this
        /// </summary>
        public const string DELTA_SEGMENTS_PER_SECOND = "DELTA_SEGMENTS_PER_SECOND";

        public const string DELTA_DIAGONAL_ROD = "DELTA_DIAGONAL_ROD";

        public const string DELTA_SMOOTH_ROD_OFFSET = "DELTA_SMOOTH_ROD_OFFSET";

        public const string DELTA_EFFECTOR_OFFSET = "DELTA_EFFECTOR_OFFSET";

        public const string DELTA_CARRIAGE_OFFSET = "DELTA_CARRIAGE_OFFSET";

        public const string DELTA_RADIUS = "DELTA_RADIUS";

        public const string DELTA_RADIUS_DEFAULT = "(DELTA_SMOOTH_ROD_OFFSET-DELTA_EFFECTOR_OFFSET-DELTA_CARRIAGE_OFFSET)";

        public const string ENABLE_AUTO_BED_LEVELING = "ENABLE_AUTO_BED_LEVELING";

        public const string LEFT_PROBE_BED_POSITION = "LEFT_PROBE_BED_POSITION";

        public const string RIGHT_PROBE_BED_POSITION = "RIGHT_PROBE_BED_POSITION";

        public const string BACK_PROBE_BED_POSITION = "BACK_PROBE_BED_POSITION";

        public const string FRONT_PROBE_BED_POSITION = "FRONT_PROBE_BED_POSITION";

        public const string MANUAL_Z_HOME_POS = "MANUAL_Z_HOME_POS";
    }
}

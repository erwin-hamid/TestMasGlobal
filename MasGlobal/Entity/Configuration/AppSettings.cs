namespace Entity.Configuration
{
    /// <summary>
    /// Class AppSettings.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Instance.
        /// </summary>
        public static AppSettings Instance { get; set; } = new AppSettings();

        /// <summary>
        /// Get - Set Service Endopoints.
        /// </summary>
        public ServiceEnpointsSettings ServiceEnpoints { get; set; }

        /// <summary>
        /// Service endpoints structure.
        /// </summary>
        public struct ServiceEnpointsSettings
        {
            /// <summary>
            /// Get - Set EmployeeService
            /// </summary>
            public string EmployeeService { get; set; }
        }
    }
}

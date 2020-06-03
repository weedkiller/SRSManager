using System;

namespace SrsApis.SrsManager.Apis.ApiModules
{
    [Serializable]
    public class ReqDvrPlan
    {
        private string _deviceId;
        private string? _vhostDomain;
        private string? _stream;

        public string DeviceId
        {
            get => _deviceId;
            set => _deviceId = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string? VhostDomain
        {
            get => _vhostDomain;
            set => _vhostDomain = value;
        }

        public string? Stream
        {
            get => _stream;
            set => _stream = value;
        }
    }
}
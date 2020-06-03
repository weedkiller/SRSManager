using System;
using System.Collections.Generic;
using FreeSql.DataAnnotations;
using Newtonsoft.Json;

namespace SrsManageCommon.ApisStructs
{
   
    [Serializable]
    /// <summary>
    /// 星期枚举
    /// </summary>
    public enum WeekdayEnum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    } ;
    
    
    [Serializable]
    [Table(Name = "DvrDayTimeRange")]
    /// <summary>
    /// 用于每周的记录时间
    /// </summary>
    public class DvrDayTimeRange
    {
        private long _id;
        private long _dvrDayTimeRangeStreamDvrPlanId;
        private WeekdayEnum _weekday;
        private DateTime _startTime;
        private DateTime _endTime;
        
        [Column(IsPrimary = true,IsIdentity = true)]
        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public long DvrDayTimeRangeStreamDvrPlanId
        {
            get => _dvrDayTimeRangeStreamDvrPlanId;
            set => _dvrDayTimeRangeStreamDvrPlanId = value;
        }

        [Column(MapType = typeof(string))]
        public WeekdayEnum WeekDay
        {
            get => _weekday;
            set => _weekday = value;
        }

        public DateTime StartTime
        {
            get => _startTime;
            set => _startTime = value;
        }

        public DateTime EndTime
        {
            get => _endTime;
            set => _endTime = value;
        }
    }
    

    [Serializable]
    /// <summary>
    /// 超过限制时怎么处理
    /// </summary>
    public enum OverStepPlan
    {
        StopDvr,
        DeleteFile,
    }
    [Table(Name = "StreamDvrPlan")]
    [Index("uk_dvrPlan_DeviceId", "DeviceId", false)]
    [Index("uk_dvrPlan_VhostDomain", "VhostDomain", false)]
    [Index("uk_dvrPlan_Stream", "Stream", false)]
    [Serializable]
    /// <summary>
    /// 录制计划
    /// </summary>
    public class StreamDvrPlan
    {
        private long _id;
        private string _deviceId;
        private string _vhostDomain;
        private string _app;
        private string _stream;
        private long? _limitSpace;
        private ushort? _limitDays;
        private OverStepPlan? _overStepPlan;
        private List<DvrDayTimeRange> _dvrDayTimeRange;

        public string DeviceId
        {
            get => _deviceId;
            set => _deviceId = value;
        }
        [Column(IsPrimary = true,IsIdentity = true)]

        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public string VhostDomain
        {
            get => _vhostDomain;
            set => _vhostDomain = value;
        }

        public string App
        {
            get => _app;
            set => _app = value;
        }

        public string Stream
        {
            get => _stream;
            set => _stream = value;
        }

        public long? LimitSpace
        {
            get => _limitSpace;
            set => _limitSpace = value;
        }

        public ushort? LimitDays
        {
            get => _limitDays;
            set => _limitDays = value;
        }
        [Column(MapType = typeof(string))]
        public OverStepPlan? OverStepPlan
        {
            get => _overStepPlan;
            set => _overStepPlan = value;
        }

        public List<DvrDayTimeRange> DvrDayTimeRange
        {
            get => _dvrDayTimeRange;
            set => _dvrDayTimeRange = value;
        }
    }
}
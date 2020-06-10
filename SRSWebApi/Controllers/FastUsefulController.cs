using Microsoft.AspNetCore.Mvc;
using SrsApis.SrsManager.Apis;
using SrsManageCommon;
using SRSManageCommon.DBMoudle;
using SRSManageCommon.ManageStructs;
using SrsWebApi.Attributes;

namespace SrsWebApi.Controllers
{
    
    /// <summary>
    /// 快速使用接口类
    /// </summary>
    [ApiController]
    [Route("")]
    public class FastUsefulController : ControllerBase
    { 
        /// <summary>
        /// 获取onvif设备信息ByIngestInfo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetOnvifMonitorInfoByIngest")]
        public JsonResult GetOnvifMonitorInfoByIngest(string deviceId,string vhostDomain,string ingestName)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId,vhostDomain,ingestName});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetOnvifMonitorInfoByIngest(deviceId,vhostDomain,ingestName,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 获取流信息ByIngestName
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetStreamInfoByVhostIngestName")]
        public JsonResult GetStreamInfoByVhostIngestName(string deviceId,string vhostDomain,string ingestName)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId,vhostDomain,ingestName});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetStreamInfoByVhostIngestName(deviceId,vhostDomain,ingestName,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 获取Ingest列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetAllIngestByDeviceId")]
        public JsonResult GetAllIngestByDeviceId(string deviceId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetAllIngestByDeviceId(deviceId,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 获取录像文件ByDeviceId
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetDvrList")]
        public JsonResult GetDvrList(string deviceId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetDvrList(deviceId,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 删除一个录制计划ById
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/DeleteDvrPlanById")]
        public JsonResult DeleteDvrPlanById(long id)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{id});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.DeleteDvrPlanById(id,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 启用或停用一个录制计划
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/OnOrOffDvrPlanById")]
        public JsonResult OnOrOffDvrPlanById(long id,bool enable)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{id,enable});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.OnOrOffDvrPlanById(id,enable,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        
        /// <summary>
        /// 修改录制计划ById
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/SetDvrPlanById")]
        public JsonResult SetDvrPlanById(StreamDvrPlan sdp)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{sdp});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.SetDvrPlanById(sdp,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        /// <summary>
        /// 修改或创建一个录制计划
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/SetDvrPlan")]
        public JsonResult SetDvrPlan(StreamDvrPlan sdp)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{sdp});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.SetDvrPlan(sdp,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 获取录制计划ById
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetDvrPlanById")]
        public JsonResult GetDvrPlanById(long id)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{id});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetDvrPlanById(id,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 获取录制计划
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetDvrPlan")]
        public JsonResult GetDvrPlan(ReqGetDvrPlan rdp)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{rdp});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetDvrPlan(rdp,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        
        /// <summary>
        /// 对某个vhost设置成低时延模式/正常模式
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/OnOrOffVhostMinDelay")]
        public JsonResult OnOrOffVhostMinDelay(string deviceId,string vhostDomain,bool enable)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId,vhostDomain,enable});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.OnOrOffVhostMinDelay(deviceId,vhostDomain,enable,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        
        /// <summary>
        /// 用于gb28181的云台镜头缩放控制
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/PtzZoomForGb28181")]
        public JsonResult PtzZommForGb28181(SrsGBT28181PtzZoomModule obj)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{obj});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.PtzZoomForGb28181(obj.DeviceId!,obj,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 用于gb28181的云台移动控制
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/PtzMoveForGb28181")]
        public JsonResult PtzMoveForGb28181(SrsGBT28181PtzMoveModule obj)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{obj});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.PtzMoveForGb28181(obj.DeviceId!,obj,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 通过stream的值获取摄像头连接信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetClientInfoByStreamValue")]
        public JsonResult GetClientInfoByStreamValue(string stream)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{stream});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetClientInfoByStreamValue(stream,out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
        
        /// <summary>
        /// 获取所有运行中srs实例的信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetRunningSrsInfoList")]
        public JsonResult GetRunningSrsInfoList()
        {
            var rt = FastUsefulApis.GetRunningSrsInfoList(out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 停止所有运行中的srs实例
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/StopAllSrs")]
        public JsonResult StopAllSrs()
        {
            var rt = FastUsefulApis.StopAllSrs(out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 启动所有未启动的srs实例
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/InitAndStartAllSrs")]
        public JsonResult InitAndStartAllSrs()
        {
            var rt = FastUsefulApis.InitAndStartAllSrs(out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 从Client列表中踢掉一个摄像头或一个播放者
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/KickoffClient")]
        public JsonResult KickoffClient(string deviceId, string streamId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId,streamId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.KickoffClient(deviceId, streamId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }


        /// <summary>
        /// 获取SRS中Stream的状态信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetStreamStatusById")]
        public JsonResult GetStreamStatusById(string deviceId, string streamId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId,streamId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetStreamStatusByDeviceIdAndStreamId(deviceId, streamId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }


        /// <summary>
        /// 获取SRS中StreamList的状态信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetStreamListStatusByDeviceId")]
        public JsonResult GetStreamListStatusByDeviceId(string deviceId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetStreamListStatusByDeviceId(deviceId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取SRS中Vhost的状态信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetVhostStatusById")]
        public JsonResult GetVhostStatusById(string deviceId, string vhostId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{vhostId,deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetVhostStatusByDeviceIdAndVhostId(deviceId, vhostId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }


        /// <summary>
        /// 获取SRS中VhostList的状态信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetVhostListStatusByDeviceId")]
        public JsonResult GetVhostListStatusByDeviceId(string deviceId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetVhostListStatusByDeviceId(deviceId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }


        /// <summary>
        /// 获取在线播放客户端通过srs实例id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetOnOnlinePlayerByDeviceId")]
        public JsonResult GetOnOnlinePlayerByDeviceId(string deviceId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetOnlinePlayerByDeviceId(deviceId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }


        /// <summary>
        /// 获取在线播放客户端
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetOnOnlinePlayer")]
        public JsonResult GetOnOnlinePlayer()
        {
            var rt = FastUsefulApis.GetOnlinePlayer(out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取在线摄像头列表通过srs实例id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetOnPublishMonitorListById")]
        public JsonResult GetOnPublishMonitorListById(string deviceId)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{deviceId});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetOnPublishMonitorListByDeviceId(deviceId, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取在线摄像头列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetOnPublishMonitorList")]
        public JsonResult GetOnPublishMonitorList()
        {
            var rt = FastUsefulApis.GetOnPublishMonitorList(out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取一个用于rtsp拉流的ingest配置
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetOnvifMonitorIngestTemplate")]
        public JsonResult GetOnvifMonitorIngestTemplate(string username,string password ,string rtspUrl)
        {
            ResponseStruct rss = CommonFunctions.CheckParams(new object[]{username,password,rtspUrl});
            if (rss.Code != ErrorNumber.None)
            {
                return Program.CommonFunctions.DelApisResult(null!, rss);
            }
            var rt = FastUsefulApis.GetOnvifMonitorIngestTemplate(username,password,rtspUrl, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;
using SRSApis;
using SRSApis.SRSManager;
using SRSApis.SRSManager.Apis;
using SRSApis.SRSManager.Apis.ApiModules;
using SRSConfFile.SRSConfClass;
using SRSWebApi.Attributes;
using System.Net;

namespace SRSWebApi.Controllers
{
    [ApiController]
    [Route("")]
    public class VhostIngestController
    {
        /// <summary>
        /// 通过VhostDomain和IngestInstanceName删除一个Ingest
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Route("/VhostIngest/DeleteVhostIngestByIngestInstanceName")]
        public JsonResult DeleteVhostIngestByIngestInstanceName(string deviceId, string vhostDomain, string ingestInstanceName)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null) return new JsonResult("无法找到deviceId对应的SrsManager实例") { StatusCode = (int)HttpStatusCode.NotFound };
            var rt = VhostIngestApis.DeleteVhostIngestByIngestInstanceName(srsManager, vhostDomain, ingestInstanceName, out ResponseStruct rs);
            return Program.common.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取所有或者指定vhost中的ingest实例名称
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Route("/VhostIngest/GetVhostIngestNameList")]
        public JsonResult GetVhostIngestNameList(string deviceId, string vhostDomain = "")
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null) return new JsonResult("无法找到deviceId对应的SrsManager实例") { StatusCode = (int)HttpStatusCode.NotFound };
            var rt = VhostIngestApis.GetVhostIngestNameList(srsManager, out ResponseStruct rs, vhostDomain);
            return Program.common.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取一个Ingest配置
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="ingestInstanceName"></param>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Route("/VhostIngest/GetVhostIngest")]
        public JsonResult GetVhostIngest(string deviceId, string vhostDomain, string ingestInstanceName)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null) return new JsonResult("无法找到deviceId对应的SrsManager实例") { StatusCode = (int)HttpStatusCode.NotFound };
            var rt = VhostIngestApis.GetVhostIngest(srsManager, vhostDomain, ingestInstanceName, out ResponseStruct rs);
            return Program.common.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 设置Ingest
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Route("/VhostIngest/SetVhostIngest")]
        public JsonResult SetVhostIngest(string deviceId, string vhostDomain, string ingestInstanceName, Ingest ingest, bool createIfNotFound = false)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null) return new JsonResult("无法找到deviceId对应的SrsManager实例") { StatusCode = (int)HttpStatusCode.NotFound };
            var rt = VhostIngestApis.SetVhostIngest(srsManager, vhostDomain, ingestInstanceName, ingest, out ResponseStruct rs, createIfNotFound);
            return Program.common.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 创建Ingest
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Route("/VhostIngest/CreateVhostIngest")]
        public JsonResult CreateVhostIngest(string deviceId, string vhostDomain, Ingest ingest)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null) return new JsonResult("无法找到deviceId对应的SrsManager实例") { StatusCode = (int)HttpStatusCode.NotFound };
            var rt = VhostIngestApis.CreateVhostIngest(srsManager, vhostDomain, ingest, out ResponseStruct rs);
            return Program.common.DelApisResult(rt, rs);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SrsApis.SrsManager.Apis;
using SrsManageCommon.ApisStructs;
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
        /// 通过stream的值获取摄像头连接信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/FastUseful/GetClientInfoByStreamValue")]
        public JsonResult GetClientInfoByStreamValue(string stream)
        {
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
        public JsonResult GetOnvifMonitorIngestTemplate(string rtspUrl)
        {
            var rt = FastUsefulApis.GetOnvifMonitorIngestTemplate(rtspUrl, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
    }
}
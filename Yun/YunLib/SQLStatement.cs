using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunLib
{
    class SQLStatement
    {
        internal static readonly string SelectProjectByUser = @"
SELECT a.[ID]
      ,[UserID]
      ,b.[Name]
      ,[ProjectID]
      ,c.[ProjectName]
      ,c.[ProjectState]
      ,c.[ProjectComment]
      ,[LimitLevel]
  FROM [UserProject] as a
  inner join [User] as b
  on a.[UserID] = b.[ID]
  inner join [ProjectInfo] as c
  on a.[ProjectID] = c.[ID]
  where b.[Name] = @UserName
";


        internal static readonly string SelectDeviceByProject = @"
SELECT 
b.[ProjectName]
,a.[ID]
      ,[ProjectID]
      ,[DeviceUID]
      ,[DeviceState]
      ,[LastLoginTime]
  FROM [ProjectDevice] as a
  inner join [ProjectInfo] as b
  on a.[ProjectID] = b.[ID]
  Where b.[ProjectName] = @ProjectName
";

        internal static readonly string SelectSensorByProject = @"
SELECT 
b.[ProjectName]
,a.[ID]
      ,[ProjectID]
      ,[SID]
      ,[SenName]
      ,[SenEnable]
      ,[SenRunFreq]
      ,[SenType]
      ,[SenBalance]
      ,[ConvertFunc]
      ,[ValueUnit]
      ,[SenDesc]
  FROM [ProjectSensor] as a
  inner join [ProjectInfo] as b
  on a.[ProjectID] = b.[ID]
  Where [ProjectName] = @ProjectName
  ";

        internal static readonly string SelectProject = @"
SELECT [ID]
      ,[ProjectName]
      ,[ProjectState]
      ,[WelcomePic]
      ,[ProjectComment]
  FROM [ProjectInfo]
";

        internal static readonly string ProjectUnitSensorSelectProjectUnit = @"
SELECT a.[ID] as 断面编号
      ,[ProjectID] as 项目编号
      ,b.[ProjectName] as 项目名
      ,[UnitName] as 断面名
      ,[UnitDesc] as 描述
      ,[Enable] as 启用状态
  FROM [UnitInfo] as a
  inner join [ProjectInfo] as b
  on a.[ProjectID] = b.[ID]
  Where [ProjectName] = @ProjectName";

        internal static readonly string SelectProjectSensorByProjectUnit = @"
SELECT 
      b.[UnitName]
      ,a.[ID]
      ,[UnitID]
      ,[SIdx]
      ,[SenName] 传感器名
      ,[SenEnable] 启用状态
      ,[SenRunFreq] as 采集频率
      ,[SenType] as 类型
      ,[SenBalance] as 平衡值
      ,[ConvertFunc] as 公式
      ,[ValueUnit] as 单位
      ,[SenDesc] as 描述
  FROM [UnitSensor] as a
  inner join [UnitInfo] as b
  on a.[UnitID] = b.[ID]
  inner join [ProjectSensor] as c
  on a.[SIdx] = c.[ID]
  inner join [SensorInfo] as d
  on c.[SID] = d.[SID]
  where a.[UnitID] = @ProjectUnitID
";
    }
}

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
    }
}

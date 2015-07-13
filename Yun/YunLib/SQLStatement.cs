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
    }
}

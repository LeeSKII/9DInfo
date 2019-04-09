using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Navisworks.Api.Plugins;

namespace _9DInfo
{
    [PluginAttribute("9DInfo","CIEPMIP",DisplayName ="9D信息",ToolTip ="BIM模型9D信息管理")]
    public class Start:AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            Form9D form9D = new Form9D();
            form9D.Show();
            return 0;
        }
    }
}

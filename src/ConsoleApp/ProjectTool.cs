using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ProjectTool
    {
        internal static void 干系人分析(项目章程 项目章程, 采购 采购, 事业环境因素 事业环境因素, 组织过程资产 组织过程资源)
        {
            会议();
            专家判断();
        }

        internal static void 制定项目章程(项目章程 项目章程, 商业认证 商业认证, 协议 协议, 事业环境因素 事业环境因素, 组织过程资产 组织过程资源)
        {
            会议();
            专家判断();
        }

        internal static void 会议()
        {

        }

        internal static void 专家判断()
        {
            throw new NotImplementedException();
        }

        internal static WBS WBS(管理计划 管理计划, SOW sow, 需求 需求, 事业环境因素 事业环境因素, 组织过程资产 组织过程资源)
        {
            会议();
            专家判断();
            //分解是一种把项目范围和项目可交付成果逐步划分为更小、更便于管理的组成部分的技术
            return new WBS();
        }
        internal static void 备选方案生成() { }
        internal static SOW 产品分析(管理计划 管理计划, 项目章程 项目章程, 需求 需求, 组织过程资产 组织过程资源)
        {

            会议();
            专家判断();
            备选方案生成();
            return new SOW();
        }

        internal static 需求 收集需求(管理计划 管理计划, 项目章程 项目章程)
        {
            /*
        访谈
        焦点小组
        引导式讨论会
        群体创新技术
        群体决定技术
        问卷调查
        观察法
        原型法
        标杆对照法
        系统交互图
        文件分析法
        */
            return new 需求();
        }


    }

    public class 项目章程
    {

    }
    public class 商业认证 { }
    public class 协议 { }
    public class 采购 { }

    public class 事业环境因素 { }
    public class 组织过程资产 { }

    public class 干系人登记册
    { }
    public class 风险登记册
    { }

    public class 变更日志
    { }
    public class 需求 { }
    public class SOW { }
    public class WBS { }

    public class 管理计划 { }
}
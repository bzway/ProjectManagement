using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// 一个项目或阶段
    /// </summary>
    public class Project
    {

        项目章程 项目章程 = new 项目章程();
        协议 协议 = new 协议();
        商业认证 商业认证 = new 商业认证();
        事业环境因素 事业环境因素 = new 事业环境因素();
        组织过程资产 组织过程资源 = new 组织过程资产();
        管理计划 管理计划;
        SOW SOW;
        需求 需求;
        WBS WBS;
        /// <summary>
        /// 初始化一个项目
        /// </summary>
        public Project()
        {
            //其实这里需要做的事有很多包括了事业环境因素，组织过程资产等的准备
        }
        /// <summary>
        /// 项目启动过程组
        /// </summary>
        public void 启动()
        {
            this.制定项目章程();
            this.识别干系人();
        }

        public void 制定项目章程()
        {
            ProjectTool.制定项目章程(项目章程, 商业认证, 协议, 事业环境因素, 组织过程资源);
        }


        public void 制定项目管理计划()
        {
            this.规划范围管理();
            this.规划进度管理();
            this.规划成本管理();
            this.规划质量管理();
            this.规划人力资源管理();
            this.规划沟通管理();
            this.规划风险管理();
            this.规划采购管理();
            this.规划干系人管理();
        }
        public void 规划范围管理()
        {
            this.收集需求();
            this.定义范围();
            this.创建工作分解结构();

        }

        public void 收集需求()
        {
            this.需求 = ProjectTool.收集需求(this.管理计划, this.项目章程);
        }
        public void 定义范围()
        {
            this.SOW = ProjectTool.产品分析(this.管理计划, this.项目章程, this.需求, this.组织过程资源);

        }
        public void 创建工作分解结构()
        {

            this.WBS = ProjectTool.WBS(this.管理计划, this.SOW, this.需求, this.事业环境因素, this.组织过程资源);
        }
        public void 定义活动() { }
        public void 排列活动顺序() { }
        public void 估算活动资源() { }
        public void 估算活动持续时间() { }
        public void 制定进度计划() { }
        public void 估算成本() { }
        public void 制定预算() { }
        public void 规划进度管理()
        {
            this.定义活动();
            this.排列活动顺序();
            this.估算活动资源();
            this.估算活动持续时间();
            this.制定进度计划();
        }
        public void 规划成本管理()
        {
            this.估算成本();
            this.制定预算();
        }
        public void 规划质量管理() { }
        public void 规划人力资源管理() { }
        public void 规划沟通管理() { }
        public void 规划风险管理()
        {
            this.识别风险();
            this.实施风险定性分析();
            this.实施风险定量分析();
            this.规划风险管理();
        }

        public void 实施风险定量分析()
        {
            throw new NotImplementedException();
        }

        public void 实施风险定性分析()
        {
            throw new NotImplementedException();
        }

        public void 识别风险()
        {
            throw new NotImplementedException();
        }

        public void 规划采购管理() { }
        public void 规划干系人管理() { }
        public bool 监控()
        {
            this.监控项目工作();
            this.实施整体变量控制();


            return true;
        }

        public void 实施整体变量控制()
        {
            this.确认范围();

        }

        public void 确认范围()
        {
            throw new NotImplementedException();
        }

        public void 监控项目工作()
        {
            this.控制范围();
            this.控制进度();
            this.控制成本();
            this.控制质量();
            this.控制沟通();
            this.控制风险();
            this.控制采购();
            this.控制干系人参与();

        }

        public void 控制采购()
        {
            throw new NotImplementedException();
        }

        public void 控制质量()
        {
            throw new NotImplementedException();
        }

        public void 控制成本()
        {
            throw new NotImplementedException();
        }

        public void 控制进度()
        {
            throw new NotImplementedException();
        }

        public void 控制范围()
        {
            throw new NotImplementedException();
        }

        public void 控制沟通()
        {
            throw new NotImplementedException();
        }

        public void 控制风险()
        {
            throw new NotImplementedException();
        }

        public void 控制干系人参与()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 干系人分析是系统地收集和分析各种定量与定性信息，以便确定在整个项目中应该考虑哪些人的利益。通过干系人分析，识别出干系人的利益、期望和影响，并把他们与项目的目的联系起来。干系人分析也有助于了解干系人之间的关系（包括干系人与项目的关系，干系人相互之间的关系），以便利用这些关系来建立联盟和伙伴合作，从而提高项目成功的可能性。在项目或阶段的不同时期，应该对干系人之间的关系施加不同的影响。
        /// 干系人分析通常应遵循以下步骤：
        /// 识别全部潜在项目干系人及其相关信息，如他们的角色、部门、利益、知识、期望和影响力。关键干系人通常很容易识别，包括所有受项目结果影响的决策者或管理者，如项目发起人、项目经理和主要客户。通常可对已识别的干系人进行访谈，来识别其他干系人，扩充干系人名单，直至列出全部潜在干系人。
        /// 分析每个干系人可能的影响或支持，并把他们分类，以便制定管理策略。在干系人很多的情况下，就必须对干系人进行排序，以便有效分配精力，来了解和管理干系人的期望。
        /// 评估关键干系人对不同情况可能做出的反应或应对，以便策划如何对他们施加影响，提高他们的支持，减轻他们的潜在负面影响。
        /// 有多种分类模型可用于干系人分析，如：
        /// 权力/利益方格。根据干系人的职权（权力）大小及对项目结果的关注（利益）程度进行分类。
        /// 权力/影响方格。根据干系人的职权（权力）大小及主动参与（影响）项目的程度进行分类。
        /// 影响/作用方格。根据干系人主动参与（影响）项目的程度及改变项目计划或执行的能力（作用）进行分类。
        /// 凸显模型。根据干系人的权力（施加自己意愿的能力）、紧急程度（需要立即关注）和合法性（有权参与），对干系人进行分类。
        /// </summary>
        public void 识别干系人()
        {
            项目章程 项目章程 = new 项目章程();
            采购 采购 = new 采购();
            事业环境因素 事业环境因素 = new 事业环境因素();
            组织过程资产 组织过程资源 = new 组织过程资产();
            ProjectTool.干系人分析(项目章程, 采购, 事业环境因素, 组织过程资源);
            ProjectTool.专家判断();
            ProjectTool.会议();


        }
        public void 规划()
        {
            this.制定项目管理计划();
        }
        /// <summary>
        /// 项目执行过程组
        /// </summary>
        public void 执行()
        {
            this.指导和管理项目工作();
            this.实施质量保证();
            this.管理人力资源();
            this.管理沟通();
            this.实施采购();
            this.管理干系人参与();

        }

        public void 管理人力资源()
        {
            this.组建项目团队();
            this.建设项目团队();
            this.管理项目团队();
        }

        public void 管理项目团队()
        {
            throw new NotImplementedException();
        }

        public void 建设项目团队()
        {
            throw new NotImplementedException();
        }

        public void 组建项目团队()
        {
            throw new NotImplementedException();
        }

        public void 实施采购()
        {
            throw new NotImplementedException();
        }

        public void 管理干系人参与()
        {
            throw new NotImplementedException();
        }

        public void 实施质量保证()
        {
            ProjectTool.专家判断();
            throw new NotImplementedException();
        }

        public void 管理沟通()
        {
            throw new NotImplementedException();
        }

        public void 指导和管理项目工作()
        {
            throw new NotImplementedException();
        }

        public void 收尾()
        {
            this.结束采购();
            this.结束项目();
        }

        public void 结束采购()
        {
            throw new NotImplementedException();
        }

        public void 结束项目()
        {
            throw new NotImplementedException();
        }
    }
}

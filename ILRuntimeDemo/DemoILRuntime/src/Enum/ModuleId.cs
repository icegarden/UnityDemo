namespace DemoILRuntime
{
    public enum ModuleId
    {
        Loading,
        /**
         * 登录
         */
        Login,
        /**
         * 选择服务器
         */
        SelectServer,
        /**
         * 公告
         */
        Bulletin,
        /**
         * 主界面底部菜单
         */
        MainUIBottom,
        /**
         * 主城界面
         */
        MainCity,
        /**
         * 顶部角色信息
         */
        TopRoleInfo,
        /**
         * 角色列表面板
         */
        RoleList,
        /**
         * 角色面板
         */
        Role,
        /**
         * 背包面板
         */
        Bag,
        /**
         * 战斗
         */
        Battle,
        /**
         * 魔宠
         */
        Pet,
        /**
         * 背包扩容
         */
        AddBagCount,
        /**
         * 分享
         */
        Share,
        /**
         * 道具批量使用
         */
        ItemBatchUse,
        /**
         * 道具选择使用
         */
        ItemSelectUse,
        /**
         * 道具合成
         */
        ItemCompose,
        /**
         * 道具分解
         */
        ItemDecompose,
        /**
         * 道具获取途径
         */
        ItemGetway,
        /**
         * 道具获得
         */
        RewardTips,
        /**
         * 装备批量分解
         */
        EquipDecomposeBatch,
        /**
         * 警报
         */
        Alert,
        /**
         * 道具tips
         */
        ItemTips,
        /**
         * 装备tips
         */
        EquipTips,
        /**
         * GM
         */
        GM,
        /**
         * 属性详情
         */
        AttrDetail,
        /**
         * 神器
         */
        Artifact,
        /**
         * 神器技能
         */
        ArtifactSkillTips,
        /**
         * 天赋详情tips
         */
        TalentTips,
        /**
         * 没有装备
         */
        EquipEmpty,
        /**
         * 没有装备
         */
        EquipSelect,
        /**
         * 选择的装备详情界面
         */
        SelectEquipTips,
        /**
         * 宠物背包
         */
        PetBag,
        /**
         * 宠物孵化
         */
        PetProduce,
        /**
         * 宠物获得动画
         */
        PetGet,
        /**
         * 宠物批量分解
         */
        PetDecomposeBatch,
        /**
         * 宠物技能tips
         */
        PetSkillTips,
        /**
         * 宠物性格
         */
        PetNature,
        /**
         * 宠物亲密度
         */
        PetIntimate,
        /**
         * 宠物重生
         */
        PetReborn,
        /**
         * 宠物技能升级
         */
        PetSkillUpgradeTips,
        /**
         * 选择宠物
         */
        PetSelect,
        /**
         * 解锁宠物魂石槽位提示
         */
        OpenStoneSlot,
        /**
         * 选择魂石界面
         */
        PetSelectStone,
        /**
         * 魂石tips
         */
        PetStoneTips,
        /**
         * 魂石合成
         */
        StoneCompose,
        /**
         * 魂石筛选
         */
        StoneFilter,
        /**
         * 推荐魂石组合
         */
        RecommendStoneCombine,
        /**
         * 二次觉醒
         */
        PetSecondWake,
        /**
         * 宠物布阵
         */
        PetFormation,
        /**
         * 家园
         */
        Home,
        /**
         * 大厅管理界面
         */
        HomeHall,
        /**
         * 建筑详情
         */
        BuildInfo,
        /**
         * 清理杂物
         */
        ClearDebris,
        /**
         * 农田
         */
        Farm,
        /**
         *  战斗胜利
         */
        BattleWin,
        /**
         * 战斗失败
         */
        BattleFail,
        /*
         * 消耗提示
         */
        CostTips,
        /**
         * 作物详情
         */
        PlantTips,
        /**
         * 催熟作物
         */
        PlantSpeedup,
        /**
         * 收获作物
         */
        PlantHarvest,
        /**
         * 浇水提示
         */
        WaterTips,
        /**
         * 宠物进化
         */
        PetEvolution,
        /**
         * 宠物觉醒
         */
        PetWake,
        /**
         * 宠物进化/觉醒成功
         */
        PetUpgradeAni,
        /**
         * 宠物专属属性tips
         */
        PetOwnSkillTips,
        /**
         * 角色晋升
         */
        RolePromote,
        /**
         * 角色晋升成功
         */
        RolePromoteSuccess,
        /**
          * 圣物
          */
        Halidom,
        /**
          * 圣物详情
          */
        HalidomTips,
        /**
         * 圣物升级升星
         */
        HalidomUpgrade,
        /**
         * 圣物碎片合成
         */
        HalidomChipCompose,
        /**
         * 图书馆
         */
        Library,
        /**
         * 宠物图鉴
         */
        PetBook,
        /**
         * 商城
         */
        Shop,
        /**
         * 罐子tips
         */
        PotTips,
        /**
         * 批量购买
         */
        BatchBuy,
        /**
         * 派遣
         */
        Assign,
        /**
         * 任务详情
         */
        AssignTaskDetail,
        /**
         * 已派遣的任务信息
         */
        AssigningTask,
        /**
         * 派遣区域列表
         */
        AssignTaskList,
        /**
         * 派遣成功后小人出场动画
         */
        AssignRunning,
        /**
         * 派遣成功字
         */
        AssignSuccess,
        /**
         * 派遣奖励
         */
        AssignResult,
        /**
         * 布阵界面选择出战主角
         */
        RoleSelect,
        /**
         * 竞技场入口列表
         */
        ArenaEntryList,
        /**
         * 竞技场
         */
        Arena,
        /**
         * 竞技场挑战确认
         */
        ArenaConfirm,
        /**
         * 挑战记录
         */
        ArenaRecord,
        /**
         * 挑战数据
         */
        ArenaData,
        /**
         * 竞技场排行榜
         */
        ArenaRank,
        /**
         * 竞技场奖励
         */
        ArenaReward,
        /**
         * 邮箱
         */
        Mail,
        /**
         * 邮件内容
         */
        MailContent,
        /**
         * 日常任务
         */
        Mission,
        /**
         * 装备鉴定
         */
        EquipIdentify,
        /**
        * 选择装备鉴定
        */
        EquipIdentifySelect,
        /**
         * 装备鉴定结果
         */
        EquipIdentifyResult,
        /**
         * 装备鉴定辅助材料选择
         */
        EquipIdentifyMaterial,
        /**
         * 角色专长
         */
        RoleSpecialSkill,
        /**
         * 角色升星
         */
        RoleUpstar,
        /**
         * 碎片转换
         */
        ChipExchange,
        /**
         * 获得角色
         */
        RoleGet,
        /**
         * 世界
         */
        World,
        /**
         * 世界位面探索
         */
        WorldCity,
        /**
         * 世界限时事件列表
         */
        WorldEventList,
        /**
         * 世界事件详情
         */
        WorldEventInfo,
        /**
         * 世界位面天赋
         */
        WorldTalent,
        /**
         * 世界天赋tips
         */
        WorldTalentTips,
        /**
         * 增加能量
         */
        WorldEnegy,
        /**
         * 世界战斗事件
         */
        WorldChallenge,
        /**
         * 世界交易事件
         */
        WorldShop,
        /**
         * 世界副本事件
         */
        WorldDungeon,
        /**
         * 世界任务事件
         */
        WorldTask,
        /**
         * 世界采集事件
         */
        WorldMining,
        /**
         * 世界领取奖励事件
         */
        WorldReward,
        /**
         * 载具列表
         */
        Ship,
        /**
         * 载具详情
         */
        ShipInfo,
        /**
         * 载具改造
         */
        ShipRemould,
        /**
         * 载具零件改造
         */
        ShipPartRemould,
        /**
         * 载具升星
         */
        ShipUpstar,
        /**
         * 挂机收益
         */
        GuankaReward,
        /* 
         * 爬塔
         */
        Pata,
        /**
         * 英灵探险列表
         */
        DungeonPanel,
        /**
         * 英灵探险场景
         */
        DungeonScene,
        /**
         * 宠物专属装备
         */
        PetExclusiveEquip,
        /**
         * 宠物专属装备升级
         */
        PetExclusiveEquipUpgrade,
        /**
         * 英灵探险战斗事件
         */
        DungeonFightEvent,
        /**
         * 英灵探险遗物事件
         */
        DungeonRelicsEvent,
        /**
         * 英灵探险背包
         */
        DungeonBag,
        /**
         * 英灵探险互动事件
         */
        DungeonInteractEvent,
        /**
         * 副本结算
         */
        DungeonPass,
        /**
         * 英灵探险机关事件
         */
        DungeonCollectEvent,
        /**
         * 英灵探险商店事件
         */
        DungeonShopEvent,
        /**
         * NPC剧情对话
         */
        NPCDialogue,
        /**
         * Boss界面暂停
         */
        BattlePause,
        /**
         * 星图
         */
        StarSign,
        /**
         * 羁绊图鉴
         */
        StarFetterBook,
        /**
         * 羁绊之力
         */
        StarFetter,
        /**
         * 宠物星座
         */
        PetStarSign,
        /**
         * 星等奖励
         */
        StarSignReward,
        /**|
         * 设置
         */
        Setting,
        /**
         * 更换头像
         */
        SettingHead,
        /**
         * 兑换码
         */
        CDKey,
        /**
         * 通知管理
         */
        SettingNotice,
        /**
         * 语言设置
         */
        SettingLanguage,
        /**
         * 改名
         */
        SettingName,
        /**
         * 账号
         */
        LoginAccount,
        /**
         * 世界boss列表
         */
        BossListPanel,
        /**
         * 恐魔领主
         */
        KongMoBoss,
        /**
         * 恐魔领主结算
         */
        KongMoBossWin,
        /**
         * 领主之邀boss
         */
        InvitationBoss,
        /**
         * 领主之邀任务
         */
        InvitationBossTask,
        /**
         * 领主之邀结算
         */
        InvitationBossWin,
        /**
         * 冒险界面
         */
        Adventure,
        /**
         * 装备强化
         */
        EquipStarUpgrade,

        /**创建公会 */
        GuildCreate,
        /**公会列表 */
        GuildList,
        /**公会申请 */
        GuildApply,
        /**申请本公会的玩家列表 */
        GuildApplyList,
        /**公会大厅 */
        GuildHall,
        /**公会日志 */
        GuildLog,
        /**公会徽章列表 */
        GuildLogo,
        /**公会设置 */
        GuildSetting,
        /**公会改名 */
        GuildChangeName,
        /**公会改公告 */
        GuildChangeNotice,
        /**公会邮件 */
        GuildMail,
        /**公会主界面 */
        Guild,
        /**公会悬赏大厅 */
        GuildRewardHall,
        /**公会悬赏提示 */
        GuildAlert,

        /**
         * 宠物进阶列表
         */
        PetEvolutionList,
        /**
         * 宠物进阶提示
         */
        PetEvolutionTips,
        /**
         * 一键进阶
         */
        PetEvoSmart,
        /**公会高级悬赏等级界面 */
        GuildRewardLevel,
        /**公会订单界面 */
        GuildOrder,
        /**公会高级悬赏开启界面 */
        GuildRewardNpc,

        /**
         * 宠物升级后解锁新技能
         */
        PetNewSkillTips,
        /**
         * 宠物快速升级确认
         */
        PetUpgradeTips,


        /**
         * 生命之树
         */
        Tree,
        /**
        * 生命之树 宠物选择列表
        */
        TreePetList,
        /**
        * 生命之树 信息提示
        */
        TreeAlert,
        /**
       * 生命之树 祝福等级预览
       */
        TreeGrowPreview,
        /**
      * 生命之树 祝福成长精华
*/
        TreeGrow,
        /**
      * 生命之树 放入宠物
*/
        TreePetUp,
        /**
      * 生命之树 卸下宠物
*/
        TreePetDown,
        /**
         * 对话（可自动）
         */
        NPCDialogueAuto,
        /**
         * 快速领取战斗奖励
         */
        BattleQuickAward,
        /**
         * 挂机章节地图
         */
        BattleMap,
        /**
         * 章节详情
         */
        ChapterDetail,
        /**
         * 当着章节关卡玩家
         */
        GuanKaPlayer,
        /**好友 */
        Friend,
        /**好友管理 */
        FriendManager,
        /**租借管理 */
        BorrowManager,
        /**申请支援 */
        ApplyHelp,
        /**租借选择英雄 */
        BorrowSelectPet,

        /**
         * 英魂殿
         */
        PetCamp,
        /**
         * 升级提示
         */
        LevelUpTip
    }
}
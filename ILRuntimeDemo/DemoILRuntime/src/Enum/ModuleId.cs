namespace DemoILRuntime
{
    public enum ModuleId
    {
        Loading,
        /**
         * ��¼
         */
        Login,
        /**
         * ѡ�������
         */
        SelectServer,
        /**
         * ����
         */
        Bulletin,
        /**
         * ������ײ��˵�
         */
        MainUIBottom,
        /**
         * ���ǽ���
         */
        MainCity,
        /**
         * ������ɫ��Ϣ
         */
        TopRoleInfo,
        /**
         * ��ɫ�б����
         */
        RoleList,
        /**
         * ��ɫ���
         */
        Role,
        /**
         * �������
         */
        Bag,
        /**
         * ս��
         */
        Battle,
        /**
         * ħ��
         */
        Pet,
        /**
         * ��������
         */
        AddBagCount,
        /**
         * ����
         */
        Share,
        /**
         * ��������ʹ��
         */
        ItemBatchUse,
        /**
         * ����ѡ��ʹ��
         */
        ItemSelectUse,
        /**
         * ���ߺϳ�
         */
        ItemCompose,
        /**
         * ���߷ֽ�
         */
        ItemDecompose,
        /**
         * ���߻�ȡ;��
         */
        ItemGetway,
        /**
         * ���߻��
         */
        RewardTips,
        /**
         * װ�������ֽ�
         */
        EquipDecomposeBatch,
        /**
         * ����
         */
        Alert,
        /**
         * ����tips
         */
        ItemTips,
        /**
         * װ��tips
         */
        EquipTips,
        /**
         * GM
         */
        GM,
        /**
         * ��������
         */
        AttrDetail,
        /**
         * ����
         */
        Artifact,
        /**
         * ��������
         */
        ArtifactSkillTips,
        /**
         * �츳����tips
         */
        TalentTips,
        /**
         * û��װ��
         */
        EquipEmpty,
        /**
         * û��װ��
         */
        EquipSelect,
        /**
         * ѡ���װ���������
         */
        SelectEquipTips,
        /**
         * ���ﱳ��
         */
        PetBag,
        /**
         * �������
         */
        PetProduce,
        /**
         * �����ö���
         */
        PetGet,
        /**
         * ���������ֽ�
         */
        PetDecomposeBatch,
        /**
         * ���＼��tips
         */
        PetSkillTips,
        /**
         * �����Ը�
         */
        PetNature,
        /**
         * �������ܶ�
         */
        PetIntimate,
        /**
         * ��������
         */
        PetReborn,
        /**
         * ���＼������
         */
        PetSkillUpgradeTips,
        /**
         * ѡ�����
         */
        PetSelect,
        /**
         * ���������ʯ��λ��ʾ
         */
        OpenStoneSlot,
        /**
         * ѡ���ʯ����
         */
        PetSelectStone,
        /**
         * ��ʯtips
         */
        PetStoneTips,
        /**
         * ��ʯ�ϳ�
         */
        StoneCompose,
        /**
         * ��ʯɸѡ
         */
        StoneFilter,
        /**
         * �Ƽ���ʯ���
         */
        RecommendStoneCombine,
        /**
         * ���ξ���
         */
        PetSecondWake,
        /**
         * ���ﲼ��
         */
        PetFormation,
        /**
         * ��԰
         */
        Home,
        /**
         * �����������
         */
        HomeHall,
        /**
         * ��������
         */
        BuildInfo,
        /**
         * ��������
         */
        ClearDebris,
        /**
         * ũ��
         */
        Farm,
        /**
         *  ս��ʤ��
         */
        BattleWin,
        /**
         * ս��ʧ��
         */
        BattleFail,
        /*
         * ������ʾ
         */
        CostTips,
        /**
         * ��������
         */
        PlantTips,
        /**
         * ��������
         */
        PlantSpeedup,
        /**
         * �ջ�����
         */
        PlantHarvest,
        /**
         * ��ˮ��ʾ
         */
        WaterTips,
        /**
         * �������
         */
        PetEvolution,
        /**
         * �������
         */
        PetWake,
        /**
         * �������/���ѳɹ�
         */
        PetUpgradeAni,
        /**
         * ����ר������tips
         */
        PetOwnSkillTips,
        /**
         * ��ɫ����
         */
        RolePromote,
        /**
         * ��ɫ�����ɹ�
         */
        RolePromoteSuccess,
        /**
          * ʥ��
          */
        Halidom,
        /**
          * ʥ������
          */
        HalidomTips,
        /**
         * ʥ����������
         */
        HalidomUpgrade,
        /**
         * ʥ����Ƭ�ϳ�
         */
        HalidomChipCompose,
        /**
         * ͼ���
         */
        Library,
        /**
         * ����ͼ��
         */
        PetBook,
        /**
         * �̳�
         */
        Shop,
        /**
         * ����tips
         */
        PotTips,
        /**
         * ��������
         */
        BatchBuy,
        /**
         * ��ǲ
         */
        Assign,
        /**
         * ��������
         */
        AssignTaskDetail,
        /**
         * ����ǲ��������Ϣ
         */
        AssigningTask,
        /**
         * ��ǲ�����б�
         */
        AssignTaskList,
        /**
         * ��ǲ�ɹ���С�˳�������
         */
        AssignRunning,
        /**
         * ��ǲ�ɹ���
         */
        AssignSuccess,
        /**
         * ��ǲ����
         */
        AssignResult,
        /**
         * �������ѡ���ս����
         */
        RoleSelect,
        /**
         * ����������б�
         */
        ArenaEntryList,
        /**
         * ������
         */
        Arena,
        /**
         * ��������սȷ��
         */
        ArenaConfirm,
        /**
         * ��ս��¼
         */
        ArenaRecord,
        /**
         * ��ս����
         */
        ArenaData,
        /**
         * ���������а�
         */
        ArenaRank,
        /**
         * ����������
         */
        ArenaReward,
        /**
         * ����
         */
        Mail,
        /**
         * �ʼ�����
         */
        MailContent,
        /**
         * �ճ�����
         */
        Mission,
        /**
         * װ������
         */
        EquipIdentify,
        /**
        * ѡ��װ������
        */
        EquipIdentifySelect,
        /**
         * װ���������
         */
        EquipIdentifyResult,
        /**
         * װ��������������ѡ��
         */
        EquipIdentifyMaterial,
        /**
         * ��ɫר��
         */
        RoleSpecialSkill,
        /**
         * ��ɫ����
         */
        RoleUpstar,
        /**
         * ��Ƭת��
         */
        ChipExchange,
        /**
         * ��ý�ɫ
         */
        RoleGet,
        /**
         * ����
         */
        World,
        /**
         * ����λ��̽��
         */
        WorldCity,
        /**
         * ������ʱ�¼��б�
         */
        WorldEventList,
        /**
         * �����¼�����
         */
        WorldEventInfo,
        /**
         * ����λ���츳
         */
        WorldTalent,
        /**
         * �����츳tips
         */
        WorldTalentTips,
        /**
         * ��������
         */
        WorldEnegy,
        /**
         * ����ս���¼�
         */
        WorldChallenge,
        /**
         * ���罻���¼�
         */
        WorldShop,
        /**
         * ���縱���¼�
         */
        WorldDungeon,
        /**
         * ���������¼�
         */
        WorldTask,
        /**
         * ����ɼ��¼�
         */
        WorldMining,
        /**
         * ������ȡ�����¼�
         */
        WorldReward,
        /**
         * �ؾ��б�
         */
        Ship,
        /**
         * �ؾ�����
         */
        ShipInfo,
        /**
         * �ؾ߸���
         */
        ShipRemould,
        /**
         * �ؾ��������
         */
        ShipPartRemould,
        /**
         * �ؾ�����
         */
        ShipUpstar,
        /**
         * �һ�����
         */
        GuankaReward,
        /* 
         * ����
         */
        Pata,
        /**
         * Ӣ��̽���б�
         */
        DungeonPanel,
        /**
         * Ӣ��̽�ճ���
         */
        DungeonScene,
        /**
         * ����ר��װ��
         */
        PetExclusiveEquip,
        /**
         * ����ר��װ������
         */
        PetExclusiveEquipUpgrade,
        /**
         * Ӣ��̽��ս���¼�
         */
        DungeonFightEvent,
        /**
         * Ӣ��̽�������¼�
         */
        DungeonRelicsEvent,
        /**
         * Ӣ��̽�ձ���
         */
        DungeonBag,
        /**
         * Ӣ��̽�ջ����¼�
         */
        DungeonInteractEvent,
        /**
         * ��������
         */
        DungeonPass,
        /**
         * Ӣ��̽�ջ����¼�
         */
        DungeonCollectEvent,
        /**
         * Ӣ��̽���̵��¼�
         */
        DungeonShopEvent,
        /**
         * NPC����Ի�
         */
        NPCDialogue,
        /**
         * Boss������ͣ
         */
        BattlePause,
        /**
         * ��ͼ
         */
        StarSign,
        /**
         * �ͼ��
         */
        StarFetterBook,
        /**
         * �֮��
         */
        StarFetter,
        /**
         * ��������
         */
        PetStarSign,
        /**
         * �ǵȽ���
         */
        StarSignReward,
        /**|
         * ����
         */
        Setting,
        /**
         * ����ͷ��
         */
        SettingHead,
        /**
         * �һ���
         */
        CDKey,
        /**
         * ֪ͨ����
         */
        SettingNotice,
        /**
         * ��������
         */
        SettingLanguage,
        /**
         * ����
         */
        SettingName,
        /**
         * �˺�
         */
        LoginAccount,
        /**
         * ����boss�б�
         */
        BossListPanel,
        /**
         * ��ħ����
         */
        KongMoBoss,
        /**
         * ��ħ��������
         */
        KongMoBossWin,
        /**
         * ����֮��boss
         */
        InvitationBoss,
        /**
         * ����֮������
         */
        InvitationBossTask,
        /**
         * ����֮������
         */
        InvitationBossWin,
        /**
         * ð�ս���
         */
        Adventure,
        /**
         * װ��ǿ��
         */
        EquipStarUpgrade,

        /**�������� */
        GuildCreate,
        /**�����б� */
        GuildList,
        /**�������� */
        GuildApply,
        /**���뱾���������б� */
        GuildApplyList,
        /**������� */
        GuildHall,
        /**������־ */
        GuildLog,
        /**��������б� */
        GuildLogo,
        /**�������� */
        GuildSetting,
        /**������� */
        GuildChangeName,
        /**����Ĺ��� */
        GuildChangeNotice,
        /**�����ʼ� */
        GuildMail,
        /**���������� */
        Guild,
        /**�������ʹ��� */
        GuildRewardHall,
        /**����������ʾ */
        GuildAlert,

        /**
         * ��������б�
         */
        PetEvolutionList,
        /**
         * ���������ʾ
         */
        PetEvolutionTips,
        /**
         * һ������
         */
        PetEvoSmart,
        /**����߼����͵ȼ����� */
        GuildRewardLevel,
        /**���ᶩ������ */
        GuildOrder,
        /**����߼����Ϳ������� */
        GuildRewardNpc,

        /**
         * ��������������¼���
         */
        PetNewSkillTips,
        /**
         * �����������ȷ��
         */
        PetUpgradeTips,


        /**
         * ����֮��
         */
        Tree,
        /**
        * ����֮�� ����ѡ���б�
        */
        TreePetList,
        /**
        * ����֮�� ��Ϣ��ʾ
        */
        TreeAlert,
        /**
       * ����֮�� ף���ȼ�Ԥ��
       */
        TreeGrowPreview,
        /**
      * ����֮�� ף���ɳ�����
*/
        TreeGrow,
        /**
      * ����֮�� �������
*/
        TreePetUp,
        /**
      * ����֮�� ж�³���
*/
        TreePetDown,
        /**
         * �Ի������Զ���
         */
        NPCDialogueAuto,
        /**
         * ������ȡս������
         */
        BattleQuickAward,
        /**
         * �һ��½ڵ�ͼ
         */
        BattleMap,
        /**
         * �½�����
         */
        ChapterDetail,
        /**
         * �����½ڹؿ����
         */
        GuanKaPlayer,
        /**���� */
        Friend,
        /**���ѹ��� */
        FriendManager,
        /**������ */
        BorrowManager,
        /**����֧Ԯ */
        ApplyHelp,
        /**���ѡ��Ӣ�� */
        BorrowSelectPet,

        /**
         * Ӣ���
         */
        PetCamp,
        /**
         * ������ʾ
         */
        LevelUpTip
    }
}
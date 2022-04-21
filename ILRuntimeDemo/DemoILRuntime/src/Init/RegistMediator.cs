using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairyGUI;

namespace DemoILRuntime
{
    public class RegistMediator
    {
        public static void Init(Dictionary<ModuleId, Type> dic)
        {
            dic[ModuleId.Loading] = typeof(LoadingMediator);
            dic[ModuleId.Login] = typeof(LoginMediator);
        }

        public static void BindUI()
        {

            Adventure.AdventureBinder.BindAll();
            Arena.ArenaBinder.BindAll();
            Artifact.ArtifactBinder.BindAll();
            Assign.AssignBinder.BindAll();
            Bag.BagBinder.BindAll();
            Battle.BattleBinder.BindAll();
            Boss.BossBinder.BindAll();
            Chat.ChatBinder.BindAll();
            CommonComponents.CommonComponentsBinder.BindAll();
            CommonImages.CommonImagesBinder.BindAll();
            Dungeon.DungeonBinder.BindAll();
            Equip.EquipBinder.BindAll();
            FairyFont.FontBinder.BindAll();
            Formation.FormationBinder.BindAll();
            Friend.FriendBinder.BindAll();
            Guild.GuildBinder.BindAll();
            GuildReward.GuildRewardBinder.BindAll();
            Halidom.HalidomBinder.BindAll();
            Home.HomeBinder.BindAll();
            Library.LibraryBinder.BindAll();
            Login.LoginBinder.BindAll();
            Mail.MailBinder.BindAll();
            MainCity.MainCityBinder.BindAll();
            MainUI.MainUIBinder.BindAll();
            Mission.MissionBinder.BindAll();
            NPCDialogue.NPCDialogueBinder.BindAll();
            Pata.PataBinder.BindAll();
            Pet.PetBinder.BindAll();
            Role.RoleBinder.BindAll();
            Setting.SettingBinder.BindAll();
            Ship.ShipBinder.BindAll();
            Shop.ShopBinder.BindAll();
            StarSign.StarSignBinder.BindAll();
            Tree.TreeBinder.BindAll();
            World.WorldBinder.BindAll();
            DoFairyExtension();
        }

        private static void DoFairyExtension()
        {
            //按钮缩放
            var scaleBtntype = typeof(ScaleButton);
            registComponent("CommonComponents", "BackBtn", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn1Blue", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn1Brown", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn1Red", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn1Yellow", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn2Brown", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn2Yellow", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn3", scaleBtntype);
            registComponent("CommonComponents", "CommonBtn4", scaleBtntype);
            registComponent("CommonComponents", "Icon1Btn", scaleBtntype);
            registComponent("CommonComponents", "Icon2Btn", scaleBtntype);
            registComponent("CommonComponents", "Icon3Btn", scaleBtntype);
            registComponent("CommonComponents", "RichTFBtn", scaleBtntype);
        }

        private static void registComponent(string pkgName, string skinName,Type type)
        {
            Game.BindFairyGui(UIPackage.GetItemURL(pkgName, skinName), type.FullName);
        }
    }
}

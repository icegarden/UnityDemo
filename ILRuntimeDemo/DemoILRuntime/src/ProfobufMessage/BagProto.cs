using ET;
using ProtoBuf;
using System.Collections.Generic;
[Message(CMD.GetBag_C)]
[ProtoContract]
public partial class GetBag_C: Object,IMessage
{
}

[Message(CMD.GetBag_S)]
[ProtoContract]
public partial class GetBag_S: Object,IMessage
{
	
	/// <summary>装备集合</summary>///
	[ProtoMember(1)]
	public EquipListDTO equipList { get; set; }

	/// <summary>道具集合</summary>///
	[ProtoMember(2)]
	public PropListDTO propList { get; set; }

}

[ProtoContract]
public partial class ItemIdListDTO: Object
{
	/// <summary>物品唯一实例id</summary>///
	[ProtoMember(1)]
	public List<int> itemId = new List<int>();

}

[ProtoContract]
public partial class EquipListDTO: Object
{
	/// <summary>装备集合</summary>///
	[ProtoMember(1)]
	public List<EquipDTO> equips = new List<EquipDTO>();

}

[ProtoContract]
public partial class PropListDTO: Object
{
	/// <summary>道具集合</summary>///
	[ProtoMember(1)]
	public List<PropDTO> props = new List<PropDTO>();

}

[ProtoContract]
public partial class EquipDTO: Object
{
	/// <summary>物品通用结构体</summary>///
	[ProtoMember(1)]
	public ItemDTO item { get; set; }

	/// <summary>道具数量</summary>///
	[ProtoMember(2)]
	public int count { get; set; }

	/// <summary>装备经验</summary>///
	[ProtoMember(3)]
	public int exp { get; set; }

	/// <summary>装备亲和元素</summary>///
	[ProtoMember(4)]
	public int element { get; set; }

}

[ProtoContract]
public partial class PropDTO: Object
{
	/// <summary>物品通用结构体</summary>///
	[ProtoMember(1)]
	public ItemDTO item { get; set; }

	/// <summary>道具数量</summary>///
	[ProtoMember(2)]
	public int count { get; set; }

}

[ProtoContract]
public partial class ItemDTO: Object
{
	/// <summary>物品配置编号</summary>///
	[ProtoMember(1)]
	public int cfgId { get; set; }

	/// <summary>物品唯一实例id</summary>///
	[ProtoMember(2)]
	public int itemId { get; set; }

}


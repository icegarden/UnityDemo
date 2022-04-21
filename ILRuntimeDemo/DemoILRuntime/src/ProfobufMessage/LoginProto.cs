using ET;
using ProtoBuf;
using System.Collections.Generic;
[Message(CMD.GetUser_C)]
[ProtoContract]
public partial class GetUser_C: Object,IMessage
{
	/// <summary>平台用户id</summary>///
	[ProtoMember(1)]
	public string puid { get; set; }

	/// <summary>平台id</summary>///
	[ProtoMember(2)]
	public string pid { get; set; }

	/// <summary>服务器标识id</summary>///
	[ProtoMember(3)]
	public int sid { get; set; }

	/// <summary>服务器验证用Token</summary>///
	[ProtoMember(4)]
	public string token { get; set; }

}

[Message(CMD.GetUser_S)]
[ProtoContract]
public partial class GetUser_S: Object,IMessage
{
	/// <summary>错误码 0登录成功 1未知错误</summary>///
	[ProtoMember(1)]
	public int code { get; set; }

	/// <summary>唯一实例id</summary>///
	[ProtoMember(2)]
	public long guid { get; set; }

	/// <summary>名字</summary>///
	[ProtoMember(3)]
	public string name { get; set; }

	/// <summary>沉迷时间(单位：ms)，被防沉迷的用户，记录沉迷时间，不被防沉迷的用户，`不传此值`</summary>///
	[ProtoMember(4)]
	public int cmTime { get; set; }

}


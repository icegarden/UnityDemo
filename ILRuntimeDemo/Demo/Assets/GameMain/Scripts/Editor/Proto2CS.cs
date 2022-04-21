using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ET
{
    internal class OpcodeInfo
    {
        public string Name;
        public int Opcode;
    }
    public static class InnerProto2CS
    {
        private const string protoPath = ".";
        private const string clientMessagePath = "../DemoILRuntime/src/ProfobufMessage/";
        private static readonly char[] splitChars = { ' ', '\t' };
        private static readonly List<OpcodeInfo> msgOpcode = new List<OpcodeInfo>();

        public static void Proto2CS()
        {
            msgOpcode.Clear();
            var paths = Directory.GetFiles("ProtoFiles");
            foreach (var url in paths)
            {
                if (Path.GetExtension(url) == ".proto")
                {
                    Proto2CS("", url, clientMessagePath, "CMD");
                }
            }
            if (msgOpcode.Count > 0)
            {
                msgOpcode.Sort((a, b) =>
                {
                    return a.Opcode - b.Opcode;
                });
            }
            GenerateOpcode("", "CMD", clientMessagePath);
        }

        private static void Proto2CS(string ns, string protoName, string outputPath, string opcodeClassName)
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            string proto = Path.Combine(protoPath, protoName);
            string csPath = Path.Combine(outputPath, Path.GetFileNameWithoutExtension(proto) + ".cs");

            string s = File.ReadAllText(proto);

            StringBuilder sb = new StringBuilder();
            var isNormal = false;
            if (ns == null || ns == "")
            {
                isNormal = true;
            }

            sb.Append("using ET;\n");
            sb.Append("using ProtoBuf;\n");
            sb.Append("using System.Collections.Generic;\n");
            string _t = "";
            if (!isNormal)
            {
                _t = "\t";
                sb.Append($"namespace {ns}\n");
                sb.Append("{\n");
            }


            bool isMsgStart = false;
            string msgName = null;
            foreach (string line in s.Split('\n'))
            {
                string newline = line.Trim();

                if (newline == "")
                {
                    continue;
                }

                if (newline.StartsWith("//"))
                {
                    sb.Append($"{newline}\n");
                    continue;
                }

                if (newline.StartsWith("message"))
                {
                    isMsgStart = true;
                    msgName = newline.Split(splitChars, StringSplitOptions.RemoveEmptyEntries)[1];
                    
                    if (msgName.EndsWith("_C") || msgName.EndsWith("_S"))
                    {
                        sb.Append($"{_t}[Message({opcodeClassName}.{msgName})]\n");
                    }
                    sb.Append($"{_t}[ProtoContract]\n");
                    if (msgName.EndsWith("_C") || msgName.EndsWith("_S"))
                    {
                        sb.Append($"{_t}public partial class {msgName}: Object,IMessage");
                    }
                    else
                    {
                        sb.Append($"{_t}public partial class {msgName}: Object");
                    }

                    sb.Append("\n");


                    continue;
                }

                if (isMsgStart)
                {
                    if (newline == "{")
                    {
                        sb.Append($"{_t}"+"{\n");
                        continue;
                    }

                    if (newline.StartsWith("option (cmd)"))
                    {
                        int index = newline.IndexOf(";");
                        newline = newline.Remove(index);
                        var tmparr = newline.Split('=');
                        int cmd;
                        cmd = int.Parse(tmparr[1]);
                        msgOpcode.Add(new OpcodeInfo() { Name = msgName, Opcode = cmd });
                        msgName = null;
                        continue;
                    }

                    if (newline == "}")
                    {
                        isMsgStart = false;
                        sb.Append($"{_t}"+"}\n\n");
                        continue;
                    }

                    if (newline.Trim().StartsWith("//"))
                    {
                        sb.AppendLine(newline);
                        continue;
                    }

                    if (newline.Trim() != "" && newline != "}")
                    {
                        string[] ss = newline.Split(new[] { "//" }, StringSplitOptions.RemoveEmptyEntries);

                        if (ss.Length >= 2)
                        {
                            if (ss[1] != null && ss[1] != "")
                            {
                                sb.Append($"{_t}\t/// <summary>{ss[1]}</summary>///");
                                sb.Append("\n");
                            }
                        }
                        if (newline.StartsWith("repeated"))
                        {
                            Repeated(sb, _t, newline);
                        }
                        else
                        {
                            if (newline.StartsWith("optional"))
                            {
                                Members(sb, newline, false,_t);
                            }
                            else if (newline.StartsWith("required"))
                            {
                                Members(sb, newline, true,_t);
                            }

                        }
                    }
                }
            }
            if (!isNormal)
            {
                sb.Append("}\n");
            }
            using FileStream txt = new FileStream(csPath, FileMode.Create, FileAccess.ReadWrite);
            using StreamWriter sw = new StreamWriter(txt);
            sw.Write(sb.ToString());
        }

        private static void GenerateOpcode(string ns, string outputFileName, string outputPath)
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            StringBuilder sb = new StringBuilder();
            var _t = "\t";
            var isNormal = false;
            if (ns == null || ns == "")
            {
                _t = "";
                isNormal = true;
            }
            if (!isNormal)
            {
                sb.AppendLine($"namespace {ns}");
                sb.AppendLine("{");
            }

            sb.AppendLine($"{_t}public static partial class {outputFileName}");
            sb.AppendLine($"{_t}" + "{");
            foreach (OpcodeInfo info in msgOpcode)
            {
                sb.AppendLine($"{_t}\t public const short {info.Name} = {info.Opcode};");
            }

            sb.AppendLine($"{_t}" + "}");
            if (!isNormal)
            {
                sb.AppendLine("}");
            }


            string csPath = Path.Combine(outputPath, outputFileName + ".cs");

            using FileStream txt = new FileStream(csPath, FileMode.Create);
            using StreamWriter sw = new StreamWriter(txt);
            sw.Write(sb.ToString());
        }

        private static void Repeated(StringBuilder sb, string _t, string newline)
        {
            try
            {
                int index = newline.IndexOf(";");
                newline = newline.Remove(index);
                string[] ss = newline.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
                string type = ss[1];
                type = ConvertType(type);
                string name = ss[2];
                int n = int.Parse(ss[4]);

                sb.Append($"{_t}\t[ProtoMember({n})]\n");
                sb.Append($"{_t}\tpublic List<{type}> {name} = new List<{type}>();\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{newline}\n {e}");
            }
        }

        private static string ConvertType(string type)
        {
            string typeCs = "";
            switch (type)
            {
                case "int16":
                    typeCs = "short";
                    break;
                case "int32":
                    typeCs = "int";
                    break;
                case "bytes":
                    typeCs = "byte[]";
                    break;
                case "uint32":
                    typeCs = "uint";
                    break;
                case "long":
                    typeCs = "long";
                    break;
                case "int64":
                    typeCs = "long";
                    break;
                case "uint64":
                    typeCs = "ulong";
                    break;
                case "uint16":
                    typeCs = "ushort";
                    break;
                default:
                    typeCs = type;
                    break;
            }

            return typeCs;
        }

        private static void Members(StringBuilder sb, string newline, bool isRequired,string _t)
        {
            try
            {
                int index = newline.IndexOf(";");
                newline = newline.Remove(index);
                string[] ss = newline.Split('=');
                string[] tmp = ss[0].Split(' ');
                string type = tmp[1];
                string name = tmp[2];
                int n = int.Parse(ss[1]);
                string typeCs = ConvertType(type);

                sb.Append($"{_t}\t[ProtoMember({n})]\n");
                sb.Append($"{_t}\tpublic {typeCs} {name} {{ get; set; }}\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{newline}\n {e}");
            }
        }
    }
}
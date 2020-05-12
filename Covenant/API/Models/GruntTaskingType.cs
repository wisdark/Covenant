// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GruntTaskingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GruntTaskingType
    {
        [EnumMember(Value = "assembly")]
        Assembly,
        [EnumMember(Value = "setDelay")]
        SetDelay,
        [EnumMember(Value = "setJitter")]
        SetJitter,
        [EnumMember(Value = "setConnectAttempts")]
        SetConnectAttempts,
        [EnumMember(Value = "setKillDate")]
        SetKillDate,
        [EnumMember(Value = "exit")]
        Exit,
        [EnumMember(Value = "connect")]
        Connect,
        [EnumMember(Value = "disconnect")]
        Disconnect,
        [EnumMember(Value = "tasks")]
        Tasks,
        [EnumMember(Value = "taskKill")]
        TaskKill
    }
    internal static class GruntTaskingTypeEnumExtension
    {
        internal static string ToSerializedValue(this GruntTaskingType? value)
        {
            return value == null ? null : ((GruntTaskingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GruntTaskingType value)
        {
            switch( value )
            {
                case GruntTaskingType.Assembly:
                    return "assembly";
                case GruntTaskingType.SetDelay:
                    return "setDelay";
                case GruntTaskingType.SetJitter:
                    return "setJitter";
                case GruntTaskingType.SetConnectAttempts:
                    return "setConnectAttempts";
                case GruntTaskingType.SetKillDate:
                    return "setKillDate";
                case GruntTaskingType.Exit:
                    return "exit";
                case GruntTaskingType.Connect:
                    return "connect";
                case GruntTaskingType.Disconnect:
                    return "disconnect";
                case GruntTaskingType.Tasks:
                    return "tasks";
                case GruntTaskingType.TaskKill:
                    return "taskKill";
            }
            return null;
        }

        internal static GruntTaskingType? ParseGruntTaskingType(this string value)
        {
            switch( value )
            {
                case "assembly":
                    return GruntTaskingType.Assembly;
                case "setDelay":
                    return GruntTaskingType.SetDelay;
                case "setJitter":
                    return GruntTaskingType.SetJitter;
                case "setConnectAttempts":
                    return GruntTaskingType.SetConnectAttempts;
                case "setKillDate":
                    return GruntTaskingType.SetKillDate;
                case "exit":
                    return GruntTaskingType.Exit;
                case "connect":
                    return GruntTaskingType.Connect;
                case "disconnect":
                    return GruntTaskingType.Disconnect;
                case "tasks":
                    return GruntTaskingType.Tasks;
                case "taskKill":
                    return GruntTaskingType.TaskKill;
            }
            return null;
        }
    }
}

using System.Text.Json.Serialization;

namespace Flatie.Shared.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InvitationStatus
    {
        Pending = 0,
        Accepted = 1,
        Declined = 2
    }
}
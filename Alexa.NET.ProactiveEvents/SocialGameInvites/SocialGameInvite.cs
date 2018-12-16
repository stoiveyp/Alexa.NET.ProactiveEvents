using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.SocialGameInvites
{
    public class SocialGameInvite : ProactiveEvent<SocialGameInvitePayload>
    {
        public SocialGameInvite() : base("AMAZON.SocialGameInvite.Available") { }

        public SocialGameInvite(string inviter, RelationshipToInvitee relationship, InviteType inviteType, Game game) : this(
            new Invite(inviter, relationship, inviteType), game)
        {

        }

        public SocialGameInvite(Invite invite, Game game) : this()
        {
            Payload = new SocialGameInvitePayload(invite, game);
        }

        [JsonProperty("localizedAttributes")]
        public List<LocalizedGameAttributes> LocalizedAttributes { get; set; } = new List<LocalizedGameAttributes>();

        public bool ShouldSerializeLocalizedAttributes()
        {
            return LocalizedAttributes?.Any() ?? false;
        }
    }

    public class LocalizedGameAttributes
    {
        public LocalizedGameAttributes()
        {
        }

        public LocalizedGameAttributes(string locale, string gameName)
        {
            Locale = locale;
            Name = gameName;
        }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("gameName")]
        public string Name { get; set; }
    }

    public class SocialGameInvitePayload
    {
        [JsonProperty("invite")]
        public Invite Invite { get; set; }

        [JsonProperty("game")]
        public Game Game { get; set; }
        public SocialGameInvitePayload(Invite invite, Game game)
        {
            Invite = invite;
            Game = game;
        }
    }

    public class Invite
    {
        public Invite() { }
        public Invite(string inviter, RelationshipToInvitee relationship, InviteType inviteType)
        {
            Inviter = new EntityName(inviter);
            Relationship = relationship;
            Type = inviteType;
        }

        [JsonProperty("inviter")]
        public EntityName Inviter { get; set; }

        [JsonProperty("relationshipToInvitee"),JsonConverter(typeof(StringEnumConverter))]
        public RelationshipToInvitee Relationship { get; set; }

        [JsonProperty("inviteType"), JsonConverter(typeof(StringEnumConverter))]
        public InviteType Type { get; set; }

    }

    public class Game : EntityName
    {
        public Game() { }

        public Game(string name, OfferType offer) : base(name)
        {
            Offer = offer;
        }

        [JsonProperty("offer"), JsonConverter(typeof(StringEnumConverter))]
        public OfferType Offer { get; set; }
    }

    public enum OfferType
    {
        [EnumMember(Value = "MATCH")] Match,
        [EnumMember(Value = "REMATCH")] Rematch,
        [EnumMember(Value = "GAME")] Game

    }

    public enum RelationshipToInvitee
    {
        [EnumMember(Value = "FRIEND")] Friend,
        [EnumMember(Value = "CONTACT")] Contact
    }

    public enum InviteType
    {
        [EnumMember(Value = "CHALLENGE")] Challenge,
        [EnumMember(Value = "INVITE")] Invite
    }
}

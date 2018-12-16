using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.TrashCollectionReminders
{
    public enum GarbageType
    {
        [EnumMember(Value = "BOTTLES")] Bottles,
        [EnumMember(Value = "BULKY")] Bulky,
        [EnumMember(Value = "BURNABLE")] Burnable,
        [EnumMember(Value = "CANS")] Cans,
        [EnumMember(Value = "CLOTHING")] Clothing,
        [EnumMember(Value = "COMPOSTABLE")] Compostable,
        [EnumMember(Value = "CRUSHABLE")] Crushable,
        [EnumMember(Value = "GARDEN_WASTE")] GardenWaste,
        [EnumMember(Value = "GLASS")] Glass,
        [EnumMember(Value = "HAZARDOUS")] Hazardous,
        [EnumMember(Value = "HOME_APPLIANCES")] HomeAppliances,
        [EnumMember(Value = "KITCHEN_WASTE")] KitchenWaste,
        [EnumMember(Value = "LANDFILL")] Landfill,
        [EnumMember(Value = "PET_BOTTLES")] PetBottles,
        [EnumMember(Value = "RECYCLABLE_PLASTICS")] RecyclablePlastics,
        [EnumMember(Value = "WASTE_PAPER")] WastePaper
    }
}
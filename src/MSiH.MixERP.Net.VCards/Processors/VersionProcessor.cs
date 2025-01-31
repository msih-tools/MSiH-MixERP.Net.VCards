using MSiH.MixERP.Net.VCards.Lookups;
using MSiH.MixERP.Net.VCards.Models;
using MSiH.MixERP.Net.VCards.Serializer;

namespace MSiH.MixERP.Net.VCards.Processors
{
    public static class VersionProcessor
    {
        public static string Serialize(VCard vcard)
        {
            return DefaultSerializer.GetVCardString("VERSION", vcard.Version.ToVCardString(), false, vcard.Version);
        }

        public static void Parse(Token token, ref VCard vcard)
        {
            string version = token.Values[0];
            vcard.Version = VersionLookup.Parse(version);
        }
    }
}
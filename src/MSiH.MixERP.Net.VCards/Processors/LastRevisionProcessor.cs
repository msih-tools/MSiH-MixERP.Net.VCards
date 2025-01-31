﻿using MSiH.MixERP.Net.VCards.Models;

namespace MSiH.MixERP.Net.VCards.Processors
{
    public static class LastRevisionProcessor
    {
        public static string Serialize(VCard vcard)
        {
            if (vcard.LastRevision == null)
            {
                return string.Empty;
            }

            return DateTimeProcessor.Serialize(vcard.LastRevision, "REV", vcard.Version);
        }

        public static void Parse(Token token, ref VCard vcard)
        {
            string value = token.Values[0];
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var date = DateTimeProcessor.Parse(value);
            vcard.LastRevision = date;
        }
    }
}
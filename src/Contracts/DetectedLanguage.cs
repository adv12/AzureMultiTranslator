﻿// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

namespace AzureMultiTranslator.Contracts
{
    public class DetectedLanguage
    {
        public string Language { get; set; }
        public float Score { get; set; }
    }
}

﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license.txt
 */

using Thinktecture.IdentityModel.Owin;

namespace Owin
{
    public static class TokenLocation
    {
        public static QueryStringOAuthBearerProvider QueryString(string name)
        {
            return new QueryStringOAuthBearerProvider(name);
        }

        public static HeaderOAuthBearerProvider Header(string name)
        {
            return new HeaderOAuthBearerProvider(name);
        }
    }
}
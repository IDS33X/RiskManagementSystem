﻿using System;

namespace Util.Support.Responses.User
{
    public class EditUserLoginResponse
    {
        public Guid Id { get; set; }
        public bool WasUserUpdated { get; set; }
    }
}

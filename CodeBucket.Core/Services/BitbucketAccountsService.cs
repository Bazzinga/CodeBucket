﻿using System;
using CodeFramework.Core.Services;
using CodeBucket.Core.Data;

namespace CodeBucket.Core.Services
{
	public class BitbucketAccountsService : AccountsService<BitbucketAccount>
    {
        public BitbucketAccountsService(IDefaultValueService defaults, IAccountPreferencesService accountPreferences) 
            : base(defaults, accountPreferences)
        {
        }
    }
}
